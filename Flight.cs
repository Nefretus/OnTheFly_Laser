using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FlightLib;
using System.Globalization;
using global::Flight.Properties;
using Engine;
using System.Linq;
using System.Collections.Generic;
using Thorlabs.MotionControl.DeviceManagerCLI;
using System.Threading.Tasks;
using Thorlabs.MotionControl.GenericMotorCLI;
using System.Dynamic;
using MathNet.Numerics.LinearAlgebra;
using System.Text;
using System.Xml.Serialization;
using System.Threading;
using System.Xml;
using System.IO;

namespace Flight {
    enum FlightReferenceType {
        TopLeft = 0,
        TopRight = 1,
        ButtomRight = 2,
        BottomLeft = 3,
        Center = 4
    }

    enum MarkingMode {
        NORMAL = 0,
        LOOP,
        FLASH_JOB,
        OTF_LAYOUT,
        STEP_AND_REPEAT,
        EXTENDED_OTF
    }

    public partial class Flight : Form {
        const decimal timeStep = 0.000005M;

        public MotorController controller { get; set; } = null;
        EnginePanel EngineForm = null;
        public bool engineFormClosed { get; set; } = true;

        private string _FileName;
        private long _Tick;
        private rhothorLink _Link = new rhothorLink();

        private (decimal x, decimal y) deviceRefencePos;
        double resolverPosX = 0;
        double resolverPosY = 0;

        private List<Layout> cacheLayout = new List<Layout>();
        private List<Tuple<double, double>> positionsFilteredOut = new List<Tuple<double, double>>();
        Dictionary<string, double[]> paramsCache = new Dictionary<string, double[]>();
        CancellationTokenSource tokenSource = null;
        private int repetitions = 0;

        //flags
        public bool multipleHatching { get; set; }
        private bool _Connected;
        private bool _Marking;
        private int handleToProcessedGroup;
        private bool stepAndRepeatOTF = false;
        private bool extendedOTF = false;
        private bool jobDone = false;
        private bool abortProcess = false;
        private bool tableMovementON = true;

        private decimal CountStepSize(ChannelType type, TABLE_DIRECTION direction) {
            var channel = type == ChannelType.xAxis ? controller.channelX : controller.channelY;
            decimal stepSize = (channel.GetVelocityParams().MaxVelocity) * timeStep;
            switch (direction) {
                case TABLE_DIRECTION.Forward:
                    return stepSize;
                case TABLE_DIRECTION.Backward:
                    return -stepSize;
                default:
                    return 0;
            }
        }

        private void UpdateTableInfo() {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(new object[] {
                "Type: " + Settings.Default.TableInfo.TableType,
                "X limit: " + Settings.Default.TableInfo.MaxForwardLimitX,
                "Y Limit: " + Settings.Default.TableInfo.MaxForwardLimitY,
                "Actuator: " + Settings.Default.TableInfo.Actuator,
                "Controller: " + Settings.Default.TableInfo.Controller
            });
        }

        public Flight() {
            InitializeComponent();
            UpdateTableInfo();
            Settings.Default.Address = "172.16.224.20";
            SerialPortTxt.DataBindings.Add(new Binding("Text", Settings.Default, "LaserSerialPort"));
            PowerTrackBar.DataBindings.Add(new Binding("Value", Settings.Default, "LaserPower"));
            PRFTrackBar.DataBindings.Add(new Binding("Value", Settings.Default, "PRF"));
            BurstTrackBar.DataBindings.Add(new Binding("Value", Settings.Default, "BurstSize"));
            PoDBox.DataBindings.Add(new Binding("Checked", Settings.Default, "PoDEnabled"));
            PodTrackBar.DataBindings.Add(new Binding("Value", Settings.Default, "PoD"));
            PodTrackBar.Enabled = Settings.Default.PoDEnabled;
            textBox5.Enabled = Settings.Default.PoDEnabled;
        }

        private DialogResult InputBox(string title, string promptText, ref string value) {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;
            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        string TranslateMessage(int code) {
            switch (code) {
                case 0:
                    return "Unknown error";
                case -1:
                    return "Control command added to the list successfully";
                case 2:
                    return "The control system is processing a job";
                case 3:
                    return "There is no open list, call “rtListOpen";
                case 5:
                    return "The deflection control system is not responding";
                case 15:
                    return "Can't allocate memory";
                case 13:
                    return "The control command holds invalid parameters";
                case 23:
                    return "The command is not supported";
                case 42:
                    return "Insufficient laser power";
                case 43:
                    return "System is not running";
                case 47:
                    return "File in use in bootstart";
                case 48:
                    return "Missing group object in step and repeat mode";
                case 49:
                    return "All entered layout positions are invalid";
                default:
                    return "Unknown error code";
            }
        }

        private void LoadSettings() {
            // view
            View.FieldWidth = Settings.Default.FieldWidth;
            View.FieldHeight = Settings.Default.FieldHeight;
            View.FieldTop = Settings.Default.FieldTop;
            View.FieldLeft = Settings.Default.FieldLeft;

            // view
            View3D.FieldWidth = Settings.Default.FieldWidth;
            View3D.FieldHeight = Settings.Default.FieldHeight;
            View3D.FieldTop = Settings.Default.FieldTop;
            View3D.FieldLeft = Settings.Default.FieldLeft;
            View3D.FieldDepth = Settings.Default.FieldDepth;
            View3D.FieldFront = Settings.Default.FieldFront;

            // hardware
            FlightMarker.FieldSize = Settings.Default.FieldSize;
            FlightMarker.Address = Settings.Default.Address;
            FlightMarker.Resolution = Settings.Default.Resolution;
            FlightMarker.TableAxisX = false;
            FlightMarker.TableAxisY = false;
            FlightMarker.TableAxisZ = false;
            FlightMarker.TableMode = FlightMarkerTableMode.SetTable;
            FlightMarker.TableOptimize = 0;
            FlightMarker.UpdateData();
            PropTree.Refresh();
            InitLaserParams();

            Fonts.FontHeightDefinition = 1;
        }

        private void Flight_Load(object sender, EventArgs e) {
            Application.CurrentCulture = new CultureInfo("en-us");
            FlightMarker.Attach(Colors);
            FlightMarker.Attach(Pens);
            FlightMarker.Attach(Fonts);
            FlightMarker.Attach(Layouts);
            FlightMarker.Attach(Surfaces);
            FlightMarker.Attach(Tree);
            FlightMarker.Attach(PropColors);
            FlightMarker.Attach(PropPens);
            FlightMarker.Attach(PropFonts);
            FlightMarker.Attach(PropLayouts);
            FlightMarker.Attach(PropSurfaces);
            FlightMarker.Attach(PropTree);
            FlightMarker.Attach(View);
            FlightMarker.Attach(View3D);
            FlightMarker.Attach(Editor);
            _Connected = false;
            _Marking = false;
            _FileName = "";
            _Tick = 0;

            ObjectsInit();
            this.Height = 650;
            LoadSettings();
            View.Focus();
            SetViewMode(FlightViewMode.Select);
            UpdateDocTitle();
            MultiHatchingChBox.DataBindings.Add(new Binding("Checked", this, "multipleHatching"));
            UpdateUI();
        }

        private void Flight_FormClosing(object sender, FormClosingEventArgs e) {
            if (_Marking == true) {
                e.Cancel = true;
                return;
            }

            DialogResult res = MessageBox.Show("Save document before closing?", "Closing",
              MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (res != DialogResult.Cancel) {
                FlightMarker.Address = "";
                if (res == DialogResult.Yes) ObjectsSave();
                Timer.Enabled = false;
                FlightMarker.Detach(Colors);
                FlightMarker.Detach(Pens);
                FlightMarker.Detach(Fonts);
                FlightMarker.Detach(Layouts);
                FlightMarker.Detach(Tree);
                FlightMarker.Detach(Surfaces);
                FlightMarker.Detach(PropColors);
                FlightMarker.Detach(PropPens);
                FlightMarker.Detach(PropFonts);
                FlightMarker.Detach(PropLayouts);
                FlightMarker.Detach(PropSurfaces);
                FlightMarker.Detach(PropTree);
                FlightMarker.Detach(View);
                FlightMarker.Detach(View3D);
                FlightMarker.Detach(Editor);

                FlightMarker.Detach(_Link);
            }
            else e.Cancel = true;
        }

        private void InitLaserParams() {
            Colors.LaserEvent = FlightColorsLaserEvent.Never;
            Colors.PowerDutyCycle0 = Settings.Default.PowerDC0;
            Colors.PowerDutyCycle100 = Settings.Default.PowerDC100;
            Colors.PowerPulseRate = Settings.Default.PowerPulseRate;
            Colors.PowerMode = Settings.Default.PowerMode;
            Colors.Grayscale = FlightColorsGrayscale.PowerModulation;
        }

        private void ObjectsInit() {
            // global laser parameters
            Colors.Speed = 1000;
            Colors.JumpSpeed = 1000;
            Colors.QswPulseRate = 50000;
            Colors.QswPulseWidth = 10;
            Colors.BurstRate = 50000;
            Colors.BurstTime = 15;
            InitLaserParams();

            Colors.AddColor();
            Colors.Height = 200;
            Colors.ListIndex = 0;
            Fonts.AddTruetypeFont();
            Fonts.ListIndex = 0;
            Pens.AddPen();
            Pens.ListIndex = 0;
            Layouts.AddLayout();
            Layouts.ListIndex = 0;
            Surfaces.AddSurface();
            Surfaces.ListIndex = 0;
            PropColors.PropSrc = Colors.get_Data(0);
            PropFonts.PropSrc = Fonts.get_Data(0);
            PropPens.PropSrc = Pens.get_Data(0);
            PropLayouts.PropSrc = Layouts.get_Data(0);
            PropSurfaces.PropSrc = Surfaces.get_Data(0);
            PropTree.Clear();
            Colors.get_Data(0).RGB = 0xFF;
        }

        private void ObjectsNew() {
            DialogResult res = MessageBox.Show("Save previous document?", "New",
              MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (res != DialogResult.Cancel) {
                if (res == DialogResult.OK) ObjectsSave();
                Tree.DeleteAllItems();
                Pens.Clear();
                Fonts.Clear();
                Colors.Clear();
                Layouts.Clear();
                ObjectsInit();
                _FileName = "";
                UpdateDocTitle();
                FlightMarker.UpdateData();
            }
        }

        private void ObjectsSave() {
            if (_FileName != "") ObjectsSaveToFile(_FileName);
            else ObjectsSaveAs();
        }

        private void ObjectsSaveAs() {
            using (SaveFileDialog dlg = new SaveFileDialog()) {
                dlg.Filter = "flight xml files|*.xml|All files|*.*";
                dlg.Title = "Save flight xml File";
                dlg.DefaultExt = "xml";
                dlg.InitialDirectory = _FileName;
                dlg.FileName = (_FileName != "") ? _FileName : "FlightJob1.xml";
                dlg.RestoreDirectory = true;
                dlg.AddExtension = true;
                if (dlg.ShowDialog() == DialogResult.OK) ObjectsSaveToFile(dlg.FileName);
            }
        }

        private void ObjectsSaveToFile(String FileName) {
            _FileName = FileName;
            Tree.Store(_FileName);
            Colors.Store(_FileName);
            Pens.Store(_FileName);
            Fonts.Store(_FileName);
            Layouts.Store(_FileName);
            Surfaces.Store(_FileName);
            if (paramsCache.Count != 0) SaveExtraData();
            UpdateDocTitle();
        }

        private void SaveExtraData() {
            XmlDocument flightXML = new XmlDocument();
            flightXML.Load(_FileName);
            Func<double[], string> serialize = (double[] layoutParameter) => {
                XmlSerializer serializer = new XmlSerializer(layoutParameter.GetType());
                using (StringWriter writer = new StringWriter()) {
                    serializer.Serialize(writer, layoutParameter);
                    return writer.ToString();
                }
            };
            List<XmlDocument> data = new List<XmlDocument>();
            var existingParamNodes = flightXML.SelectNodes("/Flight/ArrayOfDouble");
            foreach(XmlNode node in existingParamNodes) flightXML.DocumentElement.RemoveChild(node);
            for (int i = 0; i < paramsCache.Count; i++) {
                data.Add(new XmlDocument());
                data[i].LoadXml(serialize(paramsCache.ElementAt(i).Value));
                XmlAttribute attrX = data[i].CreateAttribute("ParamName");
                attrX.Value = paramsCache.ElementAt(i).Key;
                data[i].SelectSingleNode("//*").Attributes.Append(attrX);
                XmlNode importNode = flightXML.DocumentElement.OwnerDocument.ImportNode(data[i].SelectSingleNode("//*"), true);
                flightXML.DocumentElement.AppendChild(importNode);
            }
            flightXML.Save(_FileName);
        }
         
        private void ObjectsLoad() {
            using (OpenFileDialog dlg = new OpenFileDialog()) {
                dlg.Filter = "flight xml files|*.xml|All files|*.*";
                dlg.Title = "Load flight xml File";
                dlg.RestoreDirectory = true;
                if (dlg.ShowDialog() == DialogResult.OK) {
                    _FileName = dlg.FileName;
                    Tree.Load(_FileName);
                    Colors.Load(_FileName);
                    Pens.Load(_FileName);
                    Fonts.Load(_FileName);
                    Layouts.Load(_FileName);
                    Surfaces.Load(_FileName);
                    XmlDocument doc = new XmlDocument();
                    doc.Load(dlg.FileName);
                    XmlSerializer serializer = new XmlSerializer(typeof(double[]));
                    XmlNodeList nodeList = doc.SelectNodes("/Flight/ArrayOfDouble");
                    if (nodeList != null) {
                        paramsCache.Clear();
                        for (int i = 0; i < nodeList.Count; i++) {
                            XmlNode node = nodeList[i];
                            using (XmlNodeReader reader = new XmlNodeReader(node)) {
                                paramsCache.Add(node.Attributes["ParamName"].Value, (double[])serializer.Deserialize(reader));
                            }
                        }
                    }
                    UpdateData();
                    PropTree.Refresh();
                    Colors.ListIndex = 0;
                    PropColors.PropSrc = Colors.get_Data(0);
                    Fonts.ListIndex = 0;
                    PropFonts.PropSrc = Fonts.get_Data(0);
                    Pens.ListIndex = 0;
                    PropPens.PropSrc = Pens.get_Data(0);
                    Layouts.ListIndex = 0;
                    PropLayouts.PropSrc = Layouts.get_Data(0);
                    if (Surfaces.ListCount > 0) {
                        Surfaces.ListIndex = 0;
                        PropSurfaces.PropSrc = Surfaces.get_Data(0);
                    }
                    else PropSurfaces.Clear();
                    PropTree.Clear();
                    UpdateDocTitle();
                }
            }
        }

        private void tbColors_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            if (e.ClickedItem == CmdAddColor) {
                Colors.AddColor();
                Colors.ListIndex = Colors.ListCount - 1;
                PropColors.PropSrc = Colors.get_Data(Colors.ListIndex);
                Colors.get_Data(Colors.ListIndex).RGB = 0xFF;
            }
            else if (e.ClickedItem == CmdRemoveColor) {
                Colors.RemoveColor();
                Colors.ListIndex = Colors.ListCount - 1;
                if (Colors.ListCount > 0) PropColors.PropSrc = Colors.get_Data(Colors.ListIndex);
                else PropColors.Clear();
            }
            else if (e.ClickedItem == CmdChangeColor) {
                FlightColor clr = Colors.get_Data(Colors.ListIndex);
                using (ColorDialog dlg = new ColorDialog()) {
                    dlg.AllowFullOpen = false;
                    dlg.Color = ColorTranslator.FromOle((int)clr.RGB);
                    dlg.ShowDialog();
                    clr.RGB = (uint)ColorTranslator.ToOle(dlg.Color);
                }
            }
            UpdateData();
        }

        private void tbPens_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            if (e.ClickedItem == CmdAddPen) {
                Pens.AddPen();
                Pens.ListIndex = Pens.ListCount - 1;
                PropPens.PropSrc = Pens.get_Data(Pens.ListIndex);
            }
            else if (e.ClickedItem == CmdRemovePen) {
                Pens.RemovePen();
                Pens.ListIndex = Pens.ListCount - 1;
                if (Pens.ListCount > 0) PropPens.PropSrc = Pens.get_Data(Pens.ListIndex);
                else PropPens.Clear();
            }
            UpdateData();
        }

        private void tbFonts_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            if (e.ClickedItem == CmdAddTrueTypeFont) {
                Fonts.AddTruetypeFont();
                Fonts.ListIndex = Fonts.ListCount - 1;
                PropFonts.PropSrc = Fonts.get_Data(Fonts.ListIndex);
            }
            else if (e.ClickedItem == CmdAddSinglestrokeFont) {
                Fonts.AddSinglestrokeFont();
                Fonts.ListIndex = Fonts.ListCount - 1;
                PropFonts.PropSrc = Fonts.get_Data(Fonts.ListIndex);
            }
            else if (e.ClickedItem == CmdAddBarcodeFont) {
                Fonts.AddBarcodeFont();
                Fonts.ListIndex = Fonts.ListCount - 1;
                PropFonts.PropSrc = Fonts.get_Data(Fonts.ListIndex);
            }
            else if (e.ClickedItem == CmdRemoveFont) {
                Fonts.RemoveFont();
                Fonts.ListIndex = Fonts.ListCount - 1;
                if (Fonts.ListCount < 0) PropFonts.PropSrc = Fonts.get_Data(Fonts.ListIndex);
                else PropFonts.Clear();
            }
            UpdateData();
        }

        private void tbLayouts_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            if (e.ClickedItem == CmdAddLayout) {
                Layouts.AddLayout();
                Layouts.ListIndex = Layouts.ListCount - 1;
                PropLayouts.PropSrc = Layouts.get_Data(Layouts.ListIndex);
            }
            else if (e.ClickedItem == CmdRemoveLayout) {
                Layouts.RemoveLayout();
                Layouts.ListIndex = Layouts.ListCount - 1;
                if (Layouts.ListCount > 0) PropLayouts.PropSrc = Layouts.get_Data(Layouts.ListIndex);
                else PropLayouts.Clear();
            }
            else if (e.ClickedItem == StepRepeatGenerator) {
                using (StepRepeatDlg dlg = new StepRepeatDlg()) {
                    if (Layouts.ListIndex != FlightError.ErrOK) {
                        FlightLayout fl = Layouts.get_Data(Layouts.ListIndex);
                        int i = 0;
                        if (dlg.ShowDialog() == DialogResult.OK) {
                            if ((dlg.SelectedParamX == dlg.SelectedParamY) && (dlg.SelectedParamX != null)) {
                                MessageBox.Show("Cant set the same parameter on both axis");
                                return;
                            }
                            paramsCache.Clear();
                            fl.Positions = dlg.LayoutColumns * dlg.LayoutRows;
                            if (dlg.SelectedParamX != null) paramsCache.Add(dlg.SelectedParamX, new double[fl.Positions]);
                            if (dlg.SelectedParamY != null) paramsCache.Add(dlg.SelectedParamY, new double[fl.Positions]);
                            for (int r = 0; r < dlg.LayoutRows; r++) {
                                for (int c = 0; c < dlg.LayoutColumns; c++) {
                                    fl.X[i] = c * dlg.LayoutDeltaX + dlg.LayoutStartX;
                                    fl.Y[i] = r * dlg.LayoutDeltaY + dlg.LayoutStartY;
                                    fl.Enabled[i] = true;
                                    if (dlg.SelectedParamX != null) paramsCache[dlg.SelectedParamX][i] = c * dlg.LayoutParamDeltaX + dlg.LayoutStartParamX;
                                    if (dlg.SelectedParamY != null) paramsCache[dlg.SelectedParamY][i] = r * dlg.LayoutParamDeltaY + dlg.LayoutStartParamY;
                                    i++;
                                }
                            }
                        }
                    }
                }
            }
            UpdateData();
        }

        private void StoreOrGetLayouts(bool bringBack = false) {
            Action<FlightLayout, Layout> AssignLayout = (FlightLayout layout, Layout savedLayout) => {
                layout.Positions = savedLayout.Positions;
                layout.Tag = savedLayout.Tag;
                for (int j = 0; j < savedLayout.Positions; j++) {
                    layout.X[j] = savedLayout.X[j];
                    layout.Y[j] = savedLayout.Y[j];
                    layout.Rotation[j] = savedLayout.Rotation[j];
                    layout.Enabled[j] = savedLayout.Enabled[j];
                }
            };
            if (bringBack) {
                if (cacheLayout.Count == 0) return; // no prevoiusly stored layout
                for (int i = 0; i < cacheLayout.Count; i++) {
                    Layouts.ListIndex = Layouts.ListCount - 1;
                    FlightLayout oldLayout = Layouts.get_Data(Layouts.ListIndex);
                    AssignLayout(oldLayout, cacheLayout[Layouts.ListIndex]);
                }
                cacheLayout.Clear();
            }
            else {
                for (int i = 0; i < Layouts.ListCount; i++) 
                    cacheLayout.Add(new Layout(Layouts.get_Data(i)));
            }
            return;
        }

        private void tbSurface_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            if (e.ClickedItem == CmdAddSurface) {
                Surfaces.AddSurface();
                Surfaces.ListIndex = Surfaces.ListCount - 1;
                PropSurfaces.PropSrc = Surfaces.get_Data(Surfaces.ListIndex);
            }
            else if (e.ClickedItem == CmdRemoveSurface) {
                Surfaces.RemoveSurface();
                Surfaces.ListIndex = Surfaces.ListCount - 1;
                if (Surfaces.ListCount > 0)
                    PropSurfaces.PropSrc = Surfaces.get_Data(Surfaces.ListIndex);
                else
                    PropSurfaces.Clear();
            }
            UpdateData();
        }

        private void tbObjects_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            FlightObject obj = new FlightObject();
            bool b = false;

            if (e.ClickedItem == CmdAddBitmap)
                b = obj.CreateBitmap("");
            else if (e.ClickedItem == CmdAddStruct)
                b = obj.CreateStruct("", 0);
            else if (e.ClickedItem == CmdAddText)
                b = obj.CreateText("Caption");
            else if (e.ClickedItem == CmdAddCircularText)
                b = obj.CreateCircularText("Caption");
            else if (e.ClickedItem == CmdAdd3DStruct)
                b = obj.CreateStruct3D("");
            else if (e.ClickedItem == CmdAdd3DScript)
                b = obj.CreateScript3D("", 0);
            else if (e.ClickedItem == CmdAddEvent)
                b = obj.CreateAutomationEvent(FlightObjectEventType.EventSetIO);
            else if (e.ClickedItem == CmdAddGroup)
                b = obj.CreateGroup();
            else if (e.ClickedItem == CmdAddDrawing)
                b = obj.CreateEmptyStruct();
            else if (e.ClickedItem == CmdAddSection) {
                b = obj.CreateSection(FlightObjectSectionType.SectionSetLoop);
                obj.Counter = 0;
            }
            else if (e.ClickedItem == CmdRemoveObject) {
                Tree.RemoveObject(Tree.GetSelectedItem());
                obj = Tree.GetFlightObject(Tree.GetSelectedItem());
                if (obj != null) PropTree.PropSrc = obj;
                else PropTree.Clear();
                View.Select(obj);
            }
            if (b) {
                int handle = Tree.InsertObject(obj, FlightTreeViewItem.Root, FlightTreeViewItem.Last);
                Tree.SelectItem(handle);
                if (e.ClickedItem == CmdAddDrawing) ShowEditor(obj);
            }
            else if (e.ClickedItem == CmdCopy) DuplicateSelectedItem();
            UpdateData();
        }

        private void SortTreeData() {
            IEnumerable<int> groupObjList = FindGroupObjects();
            int temp = Tree.GetRootItem();
            int hToGroupObj = 0, deletedHandle = 0;
            if (groupObjList.Any()) {
                hToGroupObj = groupObjList.First();
                while (temp != 0) {
                    int nextSiblingItem = 0;
                    if (Tree.GetFlightObject(temp).Type != (short)FlightObjectType.Group) {
                        deletedHandle = temp;
                        Tree.InsertObject(Tree.RemoveObject(temp), hToGroupObj, FlightTreeViewItem.Last);
                        deletedHandle = Tree.GetNextSiblingItem(deletedHandle);
                    }
                    if (nextSiblingItem != 0) {
                        temp = deletedHandle;
                    }
                    else
                        temp = Tree.GetNextSiblingItem(temp);
                }
            }
            else {
                FlightObject groupObj = new FlightObject();
                List<FlightObject> objList = new List<FlightObject>();
                int elementHandle = Tree.GetRootItem();
                while (elementHandle != 0) {
                    FlightObject copyObj = new FlightObject();
                    copyObj.CreateCopy(Tree.GetFlightObject(elementHandle));
                    objList.Add(copyObj);
                    temp = Tree.GetNextSiblingItem(elementHandle);
                    Tree.RemoveObject(elementHandle);
                    elementHandle = temp;
                }
                if (groupObj.CreateGroup())
                    hToGroupObj = Tree.InsertObject(groupObj, FlightTreeViewItem.Root, FlightTreeViewItem.Last);
                foreach (FlightObject obj in objList)
                    Tree.InsertObject(obj, hToGroupObj, FlightTreeViewItem.Last);
            }
        }

        private IEnumerable<int> FindGroupObjects() {
            int handle = Tree.GetRootItem();
            List<int> groupList = new List<int>();
            while (handle != 0) {
                if (Tree.GetFlightObject(handle).Type == (short)FlightObjectType.Group) 
                    groupList.Add(handle);
                handle = Tree.GetNextSiblingItem(handle);
            }
            if (groupList.Count == 0) return Enumerable.Empty<int>();
            else return groupList;
        }

        private void Colors_ClickEvent(object sender, EventArgs e) {
            PropColors.PropSrc = Colors.get_Data(Colors.ListIndex);
        }

        private void Pens_ClickEvent(object sender, EventArgs e) {
            PropPens.PropSrc = Pens.get_Data(Pens.ListIndex);
        }

        private void Fonts_ClickEvent(object sender, EventArgs e) {
            PropFonts.PropSrc = Fonts.get_Data(Fonts.ListIndex);
        }

        private void Layouts_ClickEvent(object sender, EventArgs e) {
            PropLayouts.PropSrc = Layouts.get_Data(Layouts.ListIndex);
        }

        private void Surfaces_ClickEvent(object sender, EventArgs e) {
            PropSurfaces.PropSrc = Surfaces.get_Data(Surfaces.ListIndex);
        }

        private void Flight_Validating(object sender, CancelEventArgs e) {
            UpdateData();
        }

        private void Flight_PropertyChanged(object sender, EventArgs e) {
            UpdateData();
        }

        private void Flight_SizeChanged(object sender, EventArgs e) {
            PropTree.Height = 255;
            FlightTab2.Height = Math.Max(300, this.Height - FlightTab.Height - 46);
            Tree.Height = Math.Max(10, FlightTab2.Height - PropTree.Height - 46);
            PropTree.Location = new Point(PropTree.Location.X, Tree.Location.Y + Tree.Height + 6);
        }

        private void Tree_Change(object sender, EventArgs e) {
            FlightObject obj = Tree.GetFlightObject(Tree.GetSelectedItem());
            if (obj != null)
                PropTree.PropSrc = obj;
            else
                PropTree.Clear();
            View.Select(obj);
            View3D.Select(obj);
            Editor.Edit(obj);
        }

        private void View_ObjectClick(object sender, AxFlightLib._DFlightViewEvents_ObjectClickEvent e) {
            Tree.SelectItem(Tree.FindFlightObject(e.flightObject));
        }

        private void View_MouseMoveEvent(object sender, AxFlightLib._DFlightViewEvents_MouseMoveEvent e) {
            LabelCoX.Text = "X: " + View.ClientToDocX((short)e.x).ToString("0.0");
            LabelCoY.Text = "Y: " + View.ClientToDocY((short)e.y).ToString("0.0");
        }

        private void FlightMarker_MarkingFinished(object sender, AxFlightLib._DFlightMarkerEvents_MarkingFinishedEvent e) {
            FlightMarker.TargetFileName = "";
            _Tick = 0;
            _Marking = false;
            if (jobDone) Reset();
            UpdateUI();
        }

        private void Timer_Tick(object sender, EventArgs e) {
            Timer.Enabled = false;
            if (_Tick > 0) {
                double seconds = 0.0000001 * (double)(DateTime.Now.Ticks - _Tick);
                if (seconds >= 60.0) {
                    int minutes = (int)Math.Floor(seconds / 60);
                    seconds = seconds - minutes * 60.0;
                    LabelTime.Text = "T: " + minutes.ToString("0") + "m " + seconds.ToString("0.0") + "s";
                }
                else LabelTime.Text = "T: " + seconds.ToString("0.0") + "s";
            }
        }

        private void menuMain_Click(object sender, EventArgs e) {
            View.Focus();
            if (sender == menuNew || sender == tbNew)
                ObjectsNew();
            else if (sender == menuOpen || sender == tbOpen)
                ObjectsLoad();
            else if (sender == menuSave || sender == tbSave)
                ObjectsSave();
            else if (sender == menuSaveAs)
                ObjectsSaveAs();
            else if (sender == menuExit)
                Close();
            else if (sender == menuToolbar)
                tbDocument.Visible = menuToolbar.Checked;
            else if (sender == menuStatusBar)
                StatusBar.Visible = menuStatusBar.Checked;
            else if (sender == menuSelect || sender == tbSelect)
                SetViewMode(FlightViewMode.Select);
            else if (sender == menuPan || sender == tbPan)
                SetViewMode(FlightViewMode.Pan);
            else if (sender == menuZoomIn || sender == tbZoomIn || sender == tbZoom)
                SetViewMode(FlightViewMode.ZoomIn);
            else if (sender == menuZoomOut || sender == tbZoomOut)
                SetViewMode(FlightViewMode.ZoomOut);
            else if (sender == menuZoomOut || sender == tbRotate)
                SetViewMode(FlightViewMode.Rotate);
            else if (sender == tbGrid)
                View3D.ShowGrid = !View3D.ShowGrid;
            else if (sender == tbFrontView)
                SetView3D(1);
            else if (sender == tbSideView)
                SetView3D(2);
            else if (sender == tbTopView)
                SetView3D(3);
            else if (sender == tbViewSelection)
                SetView3D(-1);
            else if (sender == menuEdit || sender == tbEdit)
                SetViewMode(8);
            else if (sender == menuRefresh || sender == tbRefresh)
                OnRefresh();
            else if (sender == menuSettingsEdit || sender == tbSettings)
                OnSettings();
            else if (sender == tbEditor)
                ShowEditor(Tree.GetFlightObject(Tree.GetSelectedItem()));
            else if (sender == tbMark)
                OnMark(MarkingMode.NORMAL);
            else if (sender == tbInfinite)
                OnMark(MarkingMode.LOOP);
            else if (sender == tbUpload)
                OnMark(MarkingMode.FLASH_JOB);
            else if (sender == tbSimulate)
                OnSimulate();
            else if (sender == onTheFlyBt)
                OnMark(MarkingMode.OTF_LAYOUT);
            else if (sender == tbStepAndRepeatBt)
                OnMark(MarkingMode.STEP_AND_REPEAT);
            else if (sender == tbAbort)
                OnAbort();
            else if (sender == tbCalibrate)
                OnCalibrate();
            else if (sender == tbFlashExplorer)
                OnFlashExplorer();
            else if (sender == menuAbout)
                using (AboutFlight dlg = new AboutFlight()) dlg.ShowDialog();
        }

        private void OnCalibrate() {
            FlightMarker.SelectColor(0);
            if (FlightMarker.Attach(_Link) == FlightError.ErrOK) {
                using (CalibrationDlg cd = new CalibrationDlg(ref _Link))
                    cd.ShowDialog();
                FlightMarker.Detach(_Link);
            }
        }

        private void OnAbort() {
            FlightMarker.Attach(_Link);
            _Link.rtListOpen(4);
            _Link.rtAbort();
            _Link.rtListClose();
            FlightMarker.Detach(_Link);
            if (_Marking == true)
            {
                FlightMarker.Abort();
            }
            if (tokenSource != null)
                tokenSource.Cancel();
            abortProcess = true;
            if (controller != null)
            {
                if (controller.IsMoving(controller.channelX))
                    controller.Stop(controller.channelX, ChannelType.xAxis);
                if (controller.IsMoving(controller.channelY))
                    controller.Stop(controller.channelY, ChannelType.yAxis);
            }
            _Marking = false;
            if (extendedOTF || stepAndRepeatOTF || MarkingParamsChBox.Checked)
                StoreOrGetLayouts(true);
            OnRefresh();
            UpdateUI();
            // poll abort event
            while (Reset() != FlightError.ErrOK) Application.DoEvents();
            return;
        }

        private void OnSimulate() {
            if (_Marking == true) return;
            if (AreaSimChBox.Checked) {
                var hList = FindGroupObjects();
                if (!hList.Any()) return;
                FlightObject obj = Tree.GetFlightObject(Tree.GetChildItem(hList.First()));
                var data = TransformData(GetDataFromLayout(hList.First()).ToList());
                PointD[] points = new PointD[4]; // implement compare operator

                points[0].X = data.First().Min().Item1 - obj.Width / 2;
                points[0].Y = data.First().Min().Item2 + obj.Height / 2;

                points[1].X = data.First().Max().Item1 + obj.Width / 2;
                points[1].Y = data.First().Max().Item2 + obj.Height / 2;

                points[2].X = data.Last().Max().Item1 + obj.Width / 2;
                points[2].Y = data.Last().Max().Item2 - obj.Height / 2;

                points[3].X = data.Last().Min().Item1 - obj.Width / 2;
                points[3].Y = data.Last().Min().Item2 - obj.Height / 2;

                FlightMarker.Attach(_Link);
                _Link.rtListOpen(4);
                _Link.rtSetLoop(0);
                _Link.rtJumpTo(points[0].X, points[0].Y);
                _Link.rtLineTo(points[1].X, points[1].Y);
                _Link.rtLineTo(points[2].X, points[2].Y);
                _Link.rtLineTo(points[3].X, points[3].Y);
                _Link.rtLineTo(points[0].X, points[0].Y);
                _Link.rtDoLoop();
                _Link.rtListClose();
            }
            else {
                FlightMarker.TargetFileName = "";
                FlightMarker.Loop = 0;
                int res = FlightMarker.Simulate(0);
                if (res == FlightError.ErrOK) {
                    _Marking = true;
                    _Tick = DateTime.Now.Ticks;
                }
                else
                    MessageBox.Show(TranslateMessage(res));
            }
        }

        private void OnFlashExplorer() {
            if (FlightMarker.Attach(_Link) == -1) {
                using (FlashExplorer fe = new FlashExplorer(ref _Link))
                    fe.ShowDialog();
                FlightMarker.Detach(_Link);
            }
        }

        private void TurnOnLaser()
        {
            int result = FlightMarker.SetIO(112, 112);
            if (result != FlightError.ErrOK)
                MessageBox.Show(TranslateMessage(result));
        }

        private void OnMark(MarkingMode mode) {
                if (MessageBox.Show("Are you sure you want to start process?\n" +
                    "This will cause laser to be turned on", "Warning", MessageBoxButtons.OKCancel) == DialogResult.Cancel) {
                return;
            }
            int result = 0;
            Colors.OperationMode = FlightColorsOperationMode.Scanner;
            Pens.TileMode = FlightPensTileMode.InfiniteField;
            if (_Marking == true) return;


            abortProcess = false;
            string s = "Job1";
            LabelTime.Text = "";
            FlightMarker.TargetFileName = "";
            FlightMarker.Loop = 1;
            InitLaserParams();
            if (mode == MarkingMode.NORMAL) {
                tableMovementON = false;
                if (MarkingParamsChBox.Checked) {
                    IEnumerable<int> hList = FindGroupObjects();
                    if (hList.Any()) {
                        foreach (var handle in hList)
                            RunStepAndRepeat(TransformData(GetDataFromLayout(handle).ToList()));
                    }
                    else result = 48; // missing group 
                }
                else
                {
                    TurnOnLaser();
                    result = FlightMarker.Mark();
                }
            }
            else if (mode == MarkingMode.LOOP) {
                FlightMarker.Loop = 0;
                result = FlightMarker.Mark();
            }
            else if (mode == MarkingMode.FLASH_JOB) {
                FlightMarker.TargetFileName = s;
                if (InputBox("Enter Flash Job Name", "Upload Flash Job", ref s) == DialogResult.OK)
                    FlightMarker.TargetFileName = s;
                if (FlightMarker.TargetFileName == "")
                    FlightMarker.TargetFileName = "Job1";
                result = FlightMarker.Mark();
            }
            else if (mode == MarkingMode.OTF_LAYOUT || mode == MarkingMode.STEP_AND_REPEAT) {
                tableMovementON = true;
                StartOTF(mode);
            }
            if (result != FlightError.ErrOK) {
                MessageBox.Show(TranslateMessage(result));
                FlightMarker.TargetFileName = "";
            }
            else if(mode != MarkingMode.OTF_LAYOUT && mode != MarkingMode.STEP_AND_REPEAT) {
                _Marking = true;
                _Tick = DateTime.Now.Ticks;
                Timer.Enabled = true;
            }
            UpdateUI();
        }

        private void OnRefresh() {
            UpdateData();
            PropTree.Refresh();
        }

        private void OnSettings() {
            if (!_Connected)
                using (SettingDlg dlg = new SettingDlg()) {
                    if (dlg.ShowDialog() == DialogResult.OK) {
                        dlg.ApplySettings();
                        LoadSettings();
                    }
                }
        }

        private void DuplicateSelectedItem() {
            FlightObject Obj = new FlightObject();
            int Item = Tree.GetSelectedItem();
            int Parent;

            if (Item != 0) {
                Parent = Tree.GetParentItem(Item);
                if (Parent == 0) Parent = FlightTreeViewItem.Root;
                Obj.CreateCopy(Tree.GetFlightObject(Item));
                Tree.InsertObject(Obj, Parent, Item);
                UpdateData();
            }
        }

        private void SetView3D(int Axis) {
            if (Axis == FlightError.ErrOK && Tree.GetSelectedItem() != 0 && Tree.GetFlightObject(Tree.GetSelectedItem()).Type != FlightObjectType.Event) {
                FlightObject obj = Tree.GetFlightObject(Tree.GetSelectedItem());
                View3D.SetView(0, 0, 0);
                View3D.ViewportPivotpointX = obj.X;
                View3D.ViewportPivotpointY = obj.Y;
                View3D.ViewportPivotpointZ = obj.Z;
                View3D.ViewportZoom = 2;
            }
            else {
                if (Axis == 1)
                    View3D.SetView(-90, 0, 0);
                else if (Axis == 2)
                    View3D.SetView(-90, 0, -90);
                else
                    View3D.SetView(0, 0, 0);
                View3D.ViewportPivotpointX = 0;
                View3D.ViewportPivotpointY = 0;
                View3D.ViewportPivotpointZ = 0;
                View3D.ViewportZoom = 1;
            }
        }

        private void SetViewMode(int Mode) {
            menuSelect.Checked = tbSelect.Checked = (Mode == FlightViewMode.Select);
            menuPan.Checked = tbPan.Checked = (Mode == FlightViewMode.Pan);
            menuZoomIn.Checked = tbZoomIn.Checked = (Mode == FlightViewMode.ZoomIn);
            menuZoomOut.Checked = tbZoomOut.Checked = (Mode == FlightViewMode.ZoomOut);
            menuEdit.Checked = tbEdit.Checked = (Mode == 8);
            tbRotate.Checked = (Mode == FlightViewMode.Rotate);
            tbZoom.Checked = (Mode == FlightViewMode.ZoomIn);

            if (tabViews.SelectedIndex == 0) {
                View.ViewMode = Mode;
                View.Refresh();
                menuZoomIn.Visible = tbZoomIn.Visible = true;
                menuZoomOut.Visible = tbZoomOut.Visible = true;
                menuZoom.Visible = tbZoom.Visible = false;
                menuRotate.Visible = tbRotate.Visible = false;
                tbTopView.Visible = false;
                tbSideView.Visible = false;
                tbFrontView.Visible = false;
                tbViewSelection.Visible = false;
                tbEdit.Visible = true;
                tbGrid.Visible = false;
            }
            else {
                View3D.ViewMode = Mode;
                View3D.Refresh();
                menuZoomIn.Visible = tbZoomIn.Visible = false;
                menuZoomOut.Visible = tbZoomOut.Visible = false;
                menuZoom.Visible = tbZoom.Visible = true;
                menuRotate.Visible = tbRotate.Visible = true;
                tbTopView.Visible = true;
                tbSideView.Visible = true;
                tbFrontView.Visible = true;
                tbViewSelection.Visible = true;
                tbEdit.Visible = false;
                tbGrid.Visible = true;
            }
        }

        private void ShowEditor(FlightObject Obj) {
            Editor.Edit(Obj);
            Editor.ShowEditor();
        }

        private void OnBtnConnect_Click(object sender, EventArgs e) {
            if (controller != null) {
                if (engineFormClosed) {
                    EngineForm = new EnginePanel(this);
                    EngineForm.Show();
                }
            }
        }

        private void UpdateData() {
            int mode = View.ViewMode;
            View.ViewMode = FlightViewMode.Static;
            this.Cursor = Cursors.WaitCursor;
            FlightMarker.UpdateData();
            View.ViewMode = mode;
            this.Cursor = Cursors.Default;
        }

        private void UpdateDocTitle() {
            string s = (_FileName != "") ? _FileName.Substring(_FileName.LastIndexOf("\\") + 1) : "Untitled";
            this.Text = s + " - Flight marker";
        }

        private void UpdateUI() {
            ConnectTableBt.Enabled = !_Marking;
            ConnectTableBt.Text = _Connected ? "Disconnect" : "Connect to table";
            onTheFlyBt.Enabled = _Connected && !_Marking;
            TableControlBt.Enabled = _Connected && !_Marking;
            tbUpload.Enabled = _Connected && !_Marking;
            tbCalibrate.Enabled = !_Marking;
            tbFlashExplorer.Enabled = !_Marking;
            ConfigBt.Enabled = controller == null;
            tbStepAndRepeatBt.Enabled = _Connected && !_Marking;
        }

        private void View_ObjectChanged(object sender, AxFlightLib._DFlightViewEvents_ObjectChangedEvent e) {
            UpdateData();
        }

        private void View3D_ObjectClick(object sender, AxFlightLib._DFlightView3DEvents_ObjectClickEvent e) {
            Tree.SelectItem(Tree.FindFlightObject(e.flightObject));
        }

        private void FlightMarker_SimulationFinished(object sender, AxFlightLib._DFlightMarkerEvents_SimulationFinishedEvent e) {
            FlightMarker.TargetFileName = "";
            _Tick = 0;
            _Marking = false;
            UpdateUI();
        }

        private void tabViews_SelectedIndexChanged(object sender, EventArgs e) {
            SetViewMode(FlightViewMode.Select);
        }

        private IEnumerable<Tuple<double, double>> GetDataFromLayout(int handle) {
            handleToProcessedGroup = handle;
            FlightLayout layoutData = Layouts.get_Data(Tree.GetFlightObject(handle).Layout);
            List<Tuple<double, double>> data = new List<Tuple<double, double>>();
            for (int i = 0; i < layoutData.Positions; i++)
                data.Add(new Tuple<double, double>(layoutData.X[i], layoutData.Y[i]));
            if (data.Count == 0) return Enumerable.Empty<Tuple<double, double>>();
            return data;
        }

        private int StartOTF(MarkingMode mode) {
            SortTreeData();
            IEnumerable<int> hList = FindGroupObjects();
            if (!hList.Any()) return 48;
            foreach (int handle in hList) Tree.GetFlightObject(handle).Enabled = false;
            deviceRefencePos.x = controller.channelX.DevicePosition;
            deviceRefencePos.y = controller.channelY.DevicePosition;
            foreach (int handle in hList) { 
                Tree.GetFlightObject(handle).Enabled = true;
                extendedOTF = false;
                stepAndRepeatOTF = true; 
                switch (mode) {
                    case MarkingMode.OTF_LAYOUT:
                        RunOTF(TransformData(GetDataFromLayout(handle).ToList()));
                        break;
                    case MarkingMode.STEP_AND_REPEAT:
                        RunStepAndRepeat(TransformData(GetDataFromLayout(handle).ToList()));
                        break;
                    case MarkingMode.EXTENDED_OTF:
                        extendedOTF = true;
                        stepAndRepeatOTF = false;
                        RunExtendedOTF();
                        break;
                    default:
                        return FlightError.ErrOK;
                }
            }
            return FlightError.ErrOK;
        }

        private List<List<Tuple<double, double>>> TransformData(List<Tuple<double, double>> data) {
            IEnumerable<IGrouping<double, Tuple<double, double>>> sortedData = data
              .GroupBy(x => x.Item2)
              .OrderByDescending(x => x.Key);
            var enumerator = sortedData.GetEnumerator();
            List<List<Tuple<double, double>>> positions = new List<List<Tuple<double, double>>>();
            int count = 0;
            while (enumerator.MoveNext()) {
                List<Tuple<double, double>> row;
                row = sortedData.First(g => g.Key == enumerator.Current.Key).ToList();
                if (count % 2 == 0)
                    row.Sort((point1, point2) => Comparer<double>.Default.Compare(point1.Item1, point2.Item1));
                else
                    row.Sort((point1, point2) => Comparer<double>.Default.Compare(point2.Item1, point1.Item1));
                if (!AreaSimChBox.Checked && !MarkingParamsChBox.Checked) // not filtering for simulation and marking with params
                    row = row.Where(point => PointIsReachable(point)).ToList();
                if (row.Count != 0) {
                    positions.Add(row);
                    count++;
                }
            }
            if (positionsFilteredOut.Count != 0) {
                MessageBox.Show($"Some of the defined positions are exceeding maximum range of the table." +
                    "Remember that positions specified in layout are relative to current table position\n" +
                    "Points that were filtered out: " +
                     string.Join(" ", positionsFilteredOut));
                positionsFilteredOut.RemoveAll(x => true);
            }
            return positions;
        }
      
        private void ClearLayout() {
            Layouts.Clear();
            Layouts.AddLayout();
            Layouts.ListIndex = Layouts.ListCount - 1;
            PropLayouts.PropSrc = Layouts.get_Data(Layouts.ListIndex);
        }

        private void RunStepAndRepeat(List<List<Tuple<double, double>>> positions) {
            Action WaitForTableMovement = () => { while (!controller.AllTasksFinished()) Application.DoEvents(); };
            Action Mark = () => {
                TurnOnLaser();
                FlightMarker.Mark();
                _Marking = true;
                _Tick = DateTime.Now.Ticks;
                Timer.Enabled = true;
            };
            StoreOrGetLayouts();
            ClearLayout();
            int layoutIndex = 0;
            int countPosCurrentRow = 0;
            int countRow = 0;
            foreach (var row in positions) {
                var rowStartingPoint = new {
                    x = (decimal)row.First().Item1 + deviceRefencePos.x,
                    y = (decimal)row.First().Item2 + deviceRefencePos.y
                };
                if (tableMovementON) {
                    try {
                        while (_Marking) Application.DoEvents();
                        WaitForTableMovement();
                        controller.MoveAbsolute(controller.channelX, ChannelType.xAxis, rowStartingPoint.x);
                        controller.MoveAbsolute(controller.channelY, ChannelType.yAxis, rowStartingPoint.y);
                        WaitForTableMovement();
                    }
                    catch (MoveToInvalidPositionException ex) {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
                foreach (var pos in row) {
                    while (_Marking) Application.DoEvents();
                    if (abortProcess) return;
                    if (tableMovementON) {
                        controller.MoveAbsolute(controller.channelX, ChannelType.xAxis, deviceRefencePos.x + (decimal)pos.Item1);
                        WaitForTableMovement();
                        if (abortProcess) return;
                    }
                    else
                        FlightMarker.SetOffset(pos.Item1, pos.Item2, 0);
                    ApplyNewParams(countRow % 2 == 0 ? layoutIndex : layoutIndex + (row.Count - 1 + (countPosCurrentRow * (-2))));
                    for (int rep = 0; rep < repetitions; rep++) {
                        if (multipleHatching) {
                            const int availableHatchingModes = 4;
                            for (int i = 0; i < availableHatchingModes; i++) {
                                for (int j = 0; j < Pens.ListCount; j++) {
                                    Pens.get_Data(j).HatchStyle = i + 1;
                                    if (i == 0) Pens.get_Data(j).Outlines = 1;
                                    else Pens.get_Data(j).Outlines = 0;
                                }
                                if (abortProcess) return;
                                while (_Marking) Application.DoEvents();
                                UpdateData();
                                Mark();
                            }
                        }
                        else {
                            while (_Marking) Application.DoEvents();
                            Mark();
                        }
                    }
                    layoutIndex++;
                    countPosCurrentRow++;
                }
                countPosCurrentRow = 0;
                countRow++;
            }
            StoreOrGetLayouts(true);
            Pens.get_Data(0).Outlines = 1; // restore outlines
            UpdateData();
            OnRefresh();
        }

        private void ApplyNewParams(int index) {
            repetitions = 1; // normally only one rep is being done
            for (int i = 0; i < paramsCache.Count; i++) {
                var parameterValues = paramsCache.ElementAt(i).Value;
                switch (paramsCache.ElementAt(i).Key) {
                    case "Power":
                        if (parameterValues[index] != Settings.Default.LaserPower) {
                            Settings.Default.LaserPower = (int)parameterValues[index];
                            LaserCommunicator.SendRequest(LaserCommand.SetPower);
                            if (!LaserCommunicator.CommandsExecutedSuccesfully()) {
                                MessageBox.Show("Error while setting laser power! Job will now stop");
                                return;
                            }
                        }
                        break;
                    case "Velocity":
                        Colors.get_Data(0).Speed = parameterValues[index];
                        break;
                    case "HatchPitch":
                        Pens.get_Data(0).HatchPitch = parameterValues[index];
                        break;
                    case "PRF":
                        if (parameterValues[index] != Settings.Default.PRF) {
                            Settings.Default.PRF = (int)parameterValues[index];
                            LaserCommunicator.SendRequest(LaserCommand.SetPulseRepetition);
                            if (!LaserCommunicator.CommandsExecutedSuccesfully()) {
                                MessageBox.Show("Error while setting PRF! Job will now stop");
                                return;
                            }
                        }
                        break;
                    case "Repetitions":
                        repetitions = (int)parameterValues[index];
                        break;
                    default:
                        break;
                }
            }
            UpdateData();
            OnRefresh();
        }

        private async void RunOTF(List<List<Tuple<double, double>>> positions) {
            tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;
            int count = 0;
            int index = 0;
            bool evenRow = true;
            bool firstIteration = true;
            bool positionReset = false;
            jobDone = false;
            StoreOrGetLayouts();
            foreach (var row in positions) {
                if (abortProcess) return;
                evenRow = count % 2 == 0;
                var rowStartingPoint = new {
                    x = (decimal)row.First().Item1 + deviceRefencePos.x,
                    y = (decimal)row.First().Item2 + deviceRefencePos.y
                };
                var tableDestination = evenRow ? new {
                    x = deviceRefencePos.x + (decimal)row.Max().Item1,
                    y = deviceRefencePos.y + (decimal)row.Max().Item2
                } : new {
                    x = deviceRefencePos.x + (decimal)row.Min().Item1,
                    y = deviceRefencePos.y + (decimal)row.Min().Item2
                };
                try {
                    while (_Marking) Application.DoEvents();
                    if(!Settings.Default.ResolverX && !Settings.Default.ResolverY) { // meaning that virtual encoder is on
                        FlightMarker.GetResolvers(ref resolverPosX, ref resolverPosY);
                        ResetEncoder(ChannelType.xAxis);
                        ResetEncoder(ChannelType.yAxis);
                        FlightMarker.SetOffset(resolverPosX, resolverPosY, 0); // used to position laser beam
                    }
                    else if(positionReset) { // reset only at the beginning
                        ResetEncoder(ChannelType.xAxis);
                        ResetEncoder(ChannelType.yAxis);
                        positionReset = true;
                    }
                    while (!controller.AllTasksFinished()) Application.DoEvents();
                    controller.MoveAbsolute(controller.channelX, ChannelType.xAxis, rowStartingPoint.x);
                    controller.MoveAbsolute(controller.channelY, ChannelType.yAxis, rowStartingPoint.y);
                    while (!controller.AllTasksFinished()) Application.DoEvents();
                    if (stepAndRepeatOTF)
                        ClearLayout();
                    controller.MoveAbsolute(controller.channelX, ChannelType.xAxis, tableDestination.x);
                    controller.MoveAbsolute(controller.channelY, ChannelType.yAxis, tableDestination.y);
                }
                catch (MoveToInvalidPositionException ex) {
                    MessageBox.Show(ex.Message);
                    return;
                }   
                await Task.Run(() => {
                    if (firstIteration) { // row begins
                        if (stepAndRepeatOTF && !Settings.Default.ResolverX && !Settings.Default.ResolverY) {
                            ResetEncoder(ChannelType.xAxis, evenRow ? TABLE_DIRECTION.Backward : TABLE_DIRECTION.Forward);
                        }
                    }
                    firstIteration = false;
                    while (index != row.Count) {
                        if (token.IsCancellationRequested)
                            return;
                        var pos = row[index];
                        bool condition = evenRow ? controller.channelX.DevicePosition >= ((decimal)pos.Item1 + deviceRefencePos.x) :
                          controller.channelX.DevicePosition <= ((decimal)pos.Item1 + deviceRefencePos.x);
                        if (condition) {
                            if (!extendedOTF) {
                                FlightMarker.GetResolvers(ref resolverPosX, ref resolverPosY);
                                FlightMarker.SetOffset(resolverPosX, resolverPosY, 0);
                            }
                            TurnOnLaser();
                            FlightMarker.Mark();
                            _Marking = true;
                            index++;
                        }
                    }
                }, token).ContinueWith(result => {
                    count++;
                    index = 0;
                    firstIteration = true;
                });
            }
            if (positions.Count == count) {
                StoreOrGetLayouts(true);
                jobDone = true;
                OnRefresh();
            }
        }

        private void EnableFlightObjects(bool enabled) {
            int handle = Tree.GetRootItem();
            while (handle != 0) {
                FlightObject obj = Tree.GetFlightObject(handle);
                if (obj.Type == FlightObjectType.Group && Tree.ItemHasChildren(handle)) {
                    int scopedHandle = Tree.GetChildItem(handle);
                    while (scopedHandle != 0) {
                        Tree.GetFlightObject(scopedHandle).Enabled = enabled;
                        scopedHandle = Tree.GetNextSiblingItem(scopedHandle);
                    }
                }
                obj.Enabled = enabled;
                handle = Tree.GetNextSiblingItem(handle);
            }
        }

        private void RunExtendedOTF() {
            deviceRefencePos.x = controller.channelX.DevicePosition;
            deviceRefencePos.y = controller.channelY.DevicePosition;
            EnableFlightObjects(false);
            int handle = Tree.GetRootItem();
            int checkpoint = 0;
            Func<FlightObject> GetMarkedObj = () => {
                if (handle == 0 && checkpoint == 0)
                    return null;
                else if (handle == 0 && checkpoint != 0) {
                    handle = Tree.GetNextSiblingItem(checkpoint);
                    if (handle == 0) return null;
                    checkpoint = 0;
                }
                FlightObject obj = Tree.GetFlightObject(handle);
                while (obj.Type == FlightObjectType.Group) {
                    if (!Tree.ItemHasChildren(handle)) {
                        handle = Tree.GetNextSiblingItem(handle);
                        if (handle == 0) return null;
                        obj = Tree.GetFlightObject(handle);
                        continue;
                    }
                    checkpoint = handle;
                    Tree.GetFlightObject(checkpoint).Enabled = true;
                    handle = Tree.GetNextSiblingItem(Tree.GetChildItem(handle));
                    return Tree.GetFlightObject(Tree.GetChildItem(checkpoint));
                }
                obj.Enabled = true;
                handle = Tree.GetNextSiblingItem(handle);
                return obj;
            };
            FlightObject markedObj = GetMarkedObj();
            while (markedObj != null) {
                while (!controller.AllTasksFinished()) Application.DoEvents();
                controller.MoveAbsolute(controller.channelX, ChannelType.xAxis, controller.GetMaxPositionForChannel(ChannelType.xAxis) / 2);
                controller.MoveAbsolute(controller.channelY, ChannelType.yAxis, controller.GetMaxPositionForChannel(ChannelType.yAxis) / 2);
                while (!controller.AllTasksFinished()) Application.DoEvents();
                markedObj.Reference = (short)FlightReferenceType.Center;
                int countRows = (int)Math.Ceiling((markedObj.Width / (Settings.Default.FieldSize)));
                int countColumns = (int)Math.Ceiling((markedObj.Height / (Settings.Default.FieldSize)));
                List<Tuple<double, double>> cache = new List<Tuple<double, double>>();
                double firstRow = (countRows - 1) * -0.5;
                double firstColumn = (countColumns - 1) * -0.5;
                for (double incrementRow = firstRow; incrementRow < (firstRow + countRows); incrementRow++) {
                    for (double incrementColumn = firstColumn; incrementColumn < (firstColumn + countColumns); incrementColumn++) {
                        cache.Add(new Tuple<double, double>(incrementRow * (Settings.Default.FieldSize), incrementColumn * (Settings.Default.FieldSize)));
                    }
                }
                RunOTF(TransformData(cache));
                markedObj = GetMarkedObj();
            }
            EnableFlightObjects(true);
        }

        public bool PointIsReachable(Tuple<double, double> point) {
            var newPos = new {
                x = (decimal)point.Item1 + deviceRefencePos.x,
                y = (decimal)point.Item2 + deviceRefencePos.y
            };
            if ((newPos.x > controller.GetMaxPositionForChannel(ChannelType.xAxis)) ||
              (newPos.x < controller.channelX.AdvancedMotorLimits.LengthMinimum)) {
                positionsFilteredOut.Add(point);
                return false;
            }
            if ((newPos.y > controller.GetMaxPositionForChannel(ChannelType.yAxis)) ||
              (newPos.y < controller.channelY.AdvancedMotorLimits.LengthMinimum)) {
                positionsFilteredOut.Add(point);
                return false;
            }
            return true;
        }

        private void ConnectTableBt_Click(object sender, EventArgs e) {
            if (controller == null && !_Connected) {
                try {
                    switch (Settings.Default.TableInfo.TableType) {
                        case TableType.BentchtopStepperMotor:
                            controller = new StepperMotorController(SimulationCbox.Checked);
                            break;
                        default:
                            MessageBox.Show("You need to implement new class to init controller\n");
                            return;
                    }
                    _Connected = true;
                }
                catch (Exception) {
                    return;
                }
            }
            else if (!_Connected) {
                controller.Connect();
                _Connected = true;
            }
            else {
                controller.Disconnect();
                _Connected = false;
            }
            UpdateUI();
        }

        private void ResetEncoder(ChannelType type, TABLE_DIRECTION direction = TABLE_DIRECTION.NONE) {
            double virtualStepSize = direction != TABLE_DIRECTION.NONE ? (double)CountStepSize(type, direction) : 0;
            switch (type) {
                case ChannelType.xAxis:
                    FlightMarker.InitResolverX(Settings.Default.ResolverX ? Settings.Default.ResolverStepsizeX : virtualStepSize, 0);
                    break;
                case ChannelType.yAxis:
                    FlightMarker.InitResolverY(Settings.Default.ResolverY ? Settings.Default.ResolverStepsizeY : virtualStepSize, 0);
                    break;
            }
        }

        private void MoveMarkableObjects(List<Tuple<double, double>> row, int index) {
            if (index == row.Count - 1) return;
            Matrix<double> transformMatrix = Matrix<double>.Build.DenseIdentity(4);
            Matrix<double> nextPoint = Matrix<double>.Build.Dense(4, 1, 1.0);
            transformMatrix[0, 3] = row[index].Item1;
            transformMatrix[1, 3] = row[index].Item2;
            transformMatrix[2, 3] = 1;
            nextPoint[0, 0] = row[index + 1].Item1;
            nextPoint[1, 0] = row[index + 1].Item2;
            var result = transformMatrix.Inverse().Multiply(nextPoint);
            var trans = index == -1 ? new {
                x = row.First().Item1,
                y = row.First().Item2
            } : new {
                x = result[0, 0],
                y = result[1, 0]
            };
            ApplyTransformation(trans.x, trans.y);
            FlightMarker.UpdateData();
        }

        private void ApplyTransformation(double transX, double transY, bool returnToPointZero = false) {
            int tmp = Tree.GetChildItem(handleToProcessedGroup);
            while (tmp != 0) {
                FlightObject obj = Tree.GetFlightObject(tmp);
                if (obj.Type != (int)FlightObjectType.Group) {
                    if (returnToPointZero) {
                        obj.X += -obj.X;
                        obj.Y += -obj.Y;
                    }
                    else {
                        obj.X += transX;
                        obj.Y += transY;
                    }
                }
                tmp = Tree.GetNextSiblingItem(tmp);
            }
        }

        private int Reset() {
            FlightMarker.SetOffset(0, 0, 0);
            FlightMarker.InitResolverX(0, 0);
            FlightMarker.InitResolverY(0, 0);
            return FlightMarker.JumpTo(0, 0, 0);
        }

        private void ConfigBt_Click(object sender, EventArgs e) {
            using (var dlg = new TableConfiguration()) {
                if (dlg.ShowDialog() == DialogResult.OK) {
                    Settings.Default.TableInfo.TableType = dlg.TableType;
                    Settings.Default.TableInfo.MaxForwardLimitX = dlg.MaxForwardLimitX;
                    Settings.Default.TableInfo.MaxForwardLimitY = dlg.MaxForwardLimitY;
                    Settings.Default.TableInfo.Controller = dlg.Controller;
                    Settings.Default.TableInfo.Actuator = dlg.Actuator;
                    Settings.Default.Save();
                    UpdateTableInfo();
                }
            }
        }

        private void LaserPower_ValueChanged(object sender, EventArgs e) {
            if (sender.GetType() == typeof(TextBox)) {
                int value;
                if (!Int32.TryParse(((TextBox)sender).Text, out value)) return;
                if (sender.Equals(textBox2)) {
                    if (value <= 0 || value >= 100) return;
                    PowerTrackBar.Value = value;
                }
                else if (sender.Equals(textBox3)) {
                    if (value <= 1 || value >= 8) return;
                    BurstTrackBar.Value = value;
                }
                else if (sender.Equals(textBox4)) {
                    if (value <= 50 || value >= 8200) return;
                    PRFTrackBar.Value = value;
                }
                else if (sender.Equals(textBox5)) {
                    if (value <= 1 || value >= 100) return;
                    PodTrackBar.Value = value;
                }
            }
            else {
                string data = Convert.ToString(((Guna.UI2.WinForms.Guna2VTrackBar)sender).Value);
                if (sender.Equals(PowerTrackBar))
                    textBox2.Text = data;
                else if (sender.Equals(BurstTrackBar))
                    textBox3.Text = data;
                else if (sender.Equals(PRFTrackBar))
                    textBox4.Text = data;
                else if (sender.Equals(PodTrackBar))
                    textBox5.Text = data;
            }
            return;
        }

        private async void SetLaserConfigBt_Click(object sender, EventArgs e) {
            LaserCommunicator.ClearMessageQueue();
            await Task.Run(async delegate {
                LaserCommunicator.SendRequest(LaserCommand.SetPower);
                await Task.Delay(100);
                LaserCommunicator.SendRequest(LaserCommand.SetPulseRepetition);
                await Task.Delay(100);
                LaserCommunicator.SendRequest(LaserCommand.SetBurstSize);
                await Task.Delay(100);
                if (Settings.Default.PoDEnabled) {
                    LaserCommunicator.SendRequest(LaserCommand.SetPoDOn);
                    await Task.Delay(100);
                    LaserCommunicator.SendRequest(LaserCommand.SetPoDDivider);
                }
                else {
                    LaserCommunicator.SendRequest(LaserCommand.SetPoDOff);
                }
                await Task.Delay(100);
            }).ContinueWith(res => {
                if (!LaserCommunicator.CommandsExecutedSuccesfully()) {
                    MessageBox.Show("Error occured while trying to send data, fault status: "
                        + LaserCommunicator.GetAllMessages()
                        + "\n To get more details check documentation");
                }
            });
            Settings.Default.Save();
        }

        private async void GetLaserConfigBt_Click(object sender, EventArgs e) {
            LaserCommunicator.ClearMessageQueue();
            await Task.Run(async delegate {
                LaserCommunicator.SendRequest(LaserCommand.GetPower);
                await Task.Delay(100);
                LaserCommunicator.SendRequest(LaserCommand.GetPulseRepetition);
                await Task.Delay(100);
                LaserCommunicator.SendRequest(LaserCommand.GetBurstSize);
                await Task.Delay(100);
            }).ContinueWith(res => {
                MessageBox.Show("Settings currently set to laser "
                    + LaserCommunicator.GetAllMessages()
                    + " Check doumentation to decode messages");
            });
        }

        private void PoDBox_CheckedChanged(object sender, EventArgs e) {
            bool status = ((CheckBox)sender).Checked;
            PodTrackBar.Enabled = status;
            textBox5.Enabled = status;
        }

        private void MarkingParamsChBox_Click(object sender, EventArgs e) => MarkingParamsChBox.Checked = !MarkingParamsChBox.Checked;

        private void AreaSimChBox_Click(object sender, EventArgs e) => AreaSimChBox.Checked = !AreaSimChBox.Checked;

        private void PrintParametersBt_Click(object sender, EventArgs e) {
            List<string> data = new List<string>();
            for (int i = 0; i < paramsCache.Count; i++) {
                data.Add(string.Join(",", paramsCache.ElementAt(i).Value.Distinct()));
                if(data[i].Length == 1) data[i] += " - the same value on every element";
            }
            MessageBox.Show(string.Join(Environment.NewLine, paramsCache.Select((x, i) => x.Key + ": " +  data[i])), "Active parameters", MessageBoxButtons.OK);
        }
    }

    public struct Layout {
        public double[] X, Y, Rotation;
        public bool[] Enabled;
        public int Positions;
        public string Tag;

        public Layout(FlightLayout savedLayout) {
            Positions = savedLayout.Positions;
            Tag = savedLayout.Tag;
            X = new double[Positions];
            Y = new double[Positions];
            Rotation = new double[Positions];
            Enabled = new bool[Positions];
            for (int j = 0; j < savedLayout.Positions; j++) {
                X[j] = savedLayout.X[j];
                Y[j] = savedLayout.Y[j];
                Rotation[j] = savedLayout.Rotation[j];
                Enabled[j] = savedLayout.Enabled[j];
            }
        }
    }

    public struct PointD {
        public double X, Y;
    }
}

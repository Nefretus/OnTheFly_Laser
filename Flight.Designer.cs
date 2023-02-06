namespace Flight
{
	partial class Flight
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flight));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSeperator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRotate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.menuZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettingsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.LabelCoX = new System.Windows.Forms.ToolStripStatusLabel();
            this.LabelCoY = new System.Windows.Forms.ToolStripStatusLabel();
            this.LabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.tbDocument = new System.Windows.Forms.ToolStrip();
            this.tbNew = new System.Windows.Forms.ToolStripButton();
            this.tbOpen = new System.Windows.Forms.ToolStripButton();
            this.tbSave = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbRefresh = new System.Windows.Forms.ToolStripButton();
            this.tbInfinite = new System.Windows.Forms.ToolStripButton();
            this.tbMark = new System.Windows.Forms.ToolStripSplitButton();
            this.MarkingParamsChBox = new System.Windows.Forms.ToolStripMenuItem();
            this.tbSimulate = new System.Windows.Forms.ToolStripSplitButton();
            this.AreaSimChBox = new System.Windows.Forms.ToolStripMenuItem();
            this.onTheFlyBt = new System.Windows.Forms.ToolStripButton();
            this.tbStepAndRepeatBt = new System.Windows.Forms.ToolStripButton();
            this.tbAbort = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tbUpload = new System.Windows.Forms.ToolStripButton();
            this.tbFlashExplorer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbSelect = new System.Windows.Forms.ToolStripButton();
            this.tbEdit = new System.Windows.Forms.ToolStripButton();
            this.tbPan = new System.Windows.Forms.ToolStripButton();
            this.tbRotate = new System.Windows.Forms.ToolStripButton();
            this.tbZoom = new System.Windows.Forms.ToolStripButton();
            this.tbZoomIn = new System.Windows.Forms.ToolStripButton();
            this.tbZoomOut = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tbGrid = new System.Windows.Forms.ToolStripButton();
            this.tbViewSelection = new System.Windows.Forms.ToolStripButton();
            this.tbTopView = new System.Windows.Forms.ToolStripButton();
            this.tbFrontView = new System.Windows.Forms.ToolStripButton();
            this.tbSideView = new System.Windows.Forms.ToolStripButton();
            this.tbEditor = new System.Windows.Forms.ToolStripButton();
            this.tbCalibrate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tbSettings = new System.Windows.Forms.ToolStripButton();
            this.Leds = new System.Windows.Forms.ImageList(this.components);
            this.TabulaImg = new System.Windows.Forms.ImageList(this.components);
            this.SplitView = new System.Windows.Forms.SplitContainer();
            this.FlightTab2 = new System.Windows.Forms.TabControl();
            this.TabObjects = new System.Windows.Forms.TabPage();
            this.Tree = new AxFlightLib.AxFlightTree();
            this.PropTree = new AxFlightLib.AxFlightPropList();
            this.tbObjects = new System.Windows.Forms.ToolStrip();
            this.CmdRemoveObject = new System.Windows.Forms.ToolStripButton();
            this.CmdCopy = new System.Windows.Forms.ToolStripButton();
            this.CmdAddBitmap = new System.Windows.Forms.ToolStripButton();
            this.CmdAddStruct = new System.Windows.Forms.ToolStripButton();
            this.CmdAdd3DScript = new System.Windows.Forms.ToolStripButton();
            this.CmdAdd3DStruct = new System.Windows.Forms.ToolStripButton();
            this.CmdAddDrawing = new System.Windows.Forms.ToolStripButton();
            this.CmdAddText = new System.Windows.Forms.ToolStripButton();
            this.CmdAddCircularText = new System.Windows.Forms.ToolStripButton();
            this.CmdAddGroup = new System.Windows.Forms.ToolStripButton();
            this.CmdAddEvent = new System.Windows.Forms.ToolStripButton();
            this.CmdAddSection = new System.Windows.Forms.ToolStripButton();
            this.FlightTab = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.PropColors = new AxFlightLib.AxFlightPropList();
            this.Colors = new AxFlightLib.AxFlightColors();
            this.tbColors = new System.Windows.Forms.ToolStrip();
            this.CmdRemoveColor = new System.Windows.Forms.ToolStripButton();
            this.CmdAddColor = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CmdChangeColor = new System.Windows.Forms.ToolStripButton();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MultiHatchingChBox = new System.Windows.Forms.CheckBox();
            this.tbPens = new System.Windows.Forms.ToolStrip();
            this.CmdRemovePen = new System.Windows.Forms.ToolStripButton();
            this.CmdAddPen = new System.Windows.Forms.ToolStripButton();
            this.PropPens = new AxFlightLib.AxFlightPropList();
            this.Pens = new AxFlightLib.AxFlightPens();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.PropFonts = new AxFlightLib.AxFlightPropList();
            this.tbFonts = new System.Windows.Forms.ToolStrip();
            this.CmdRemoveFont = new System.Windows.Forms.ToolStripButton();
            this.CmdAddTrueTypeFont = new System.Windows.Forms.ToolStripButton();
            this.CmdAddSinglestrokeFont = new System.Windows.Forms.ToolStripButton();
            this.CmdAddBarcodeFont = new System.Windows.Forms.ToolStripButton();
            this.Fonts = new AxFlightLib.AxFlightFonts();
            this.TabPage4 = new System.Windows.Forms.TabPage();
            this.PropLayouts = new AxFlightLib.AxFlightPropList();
            this.tbLayouts = new System.Windows.Forms.ToolStrip();
            this.CmdRemoveLayout = new System.Windows.Forms.ToolStripButton();
            this.CmdAddLayout = new System.Windows.Forms.ToolStripButton();
            this.StepRepeatGenerator = new System.Windows.Forms.ToolStripButton();
            this.PrintParametersBt = new System.Windows.Forms.ToolStripButton();
            this.Layouts = new AxFlightLib.AxFlightLayouts();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tbSurface = new System.Windows.Forms.ToolStrip();
            this.CmdAddSurface = new System.Windows.Forms.ToolStripButton();
            this.CmdRemoveSurface = new System.Windows.Forms.ToolStripButton();
            this.PropSurfaces = new AxFlightLib.AxFlightPropList();
            this.Surfaces = new AxFlightLib.AxFlightSurfaces();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.PoDBox = new System.Windows.Forms.CheckBox();
            this.PodTrackBar = new Guna.UI2.WinForms.Guna2VTrackBar();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GetLaserConfigBt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SerialPortTxt = new System.Windows.Forms.TextBox();
            this.SetLaserConfigBt = new System.Windows.Forms.Button();
            this.PRFTrackBar = new Guna.UI2.WinForms.Guna2VTrackBar();
            this.BurstTrackBar = new Guna.UI2.WinForms.Guna2VTrackBar();
            this.PowerTrackBar = new Guna.UI2.WinForms.Guna2VTrackBar();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitView2 = new System.Windows.Forms.SplitContainer();
            this.tabViews = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.View = new AxFlightLib.AxFlightView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.View3D = new AxFlightLib.AxFlightView3D();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SimulationCbox = new System.Windows.Forms.CheckBox();
            this.ConfigBt = new System.Windows.Forms.Button();
            this.ConnectTableBt = new System.Windows.Forms.Button();
            this.TableControlBt = new System.Windows.Forms.Button();
            this.FlightMarker = new AxFlightLib.AxFlightMarker();
            this.Editor = new AxFlightLib.AxFlightEditor();
            this.menuMain.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.tbDocument.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitView)).BeginInit();
            this.SplitView.Panel1.SuspendLayout();
            this.SplitView.Panel2.SuspendLayout();
            this.SplitView.SuspendLayout();
            this.FlightTab2.SuspendLayout();
            this.TabObjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PropTree)).BeginInit();
            this.tbObjects.SuspendLayout();
            this.FlightTab.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PropColors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Colors)).BeginInit();
            this.tbColors.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.tbPens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PropPens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pens)).BeginInit();
            this.TabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PropFonts)).BeginInit();
            this.tbFonts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Fonts)).BeginInit();
            this.TabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PropLayouts)).BeginInit();
            this.tbLayouts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Layouts)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tbSurface.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PropSurfaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Surfaces)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitView2)).BeginInit();
            this.splitView2.Panel1.SuspendLayout();
            this.splitView2.Panel2.SuspendLayout();
            this.splitView2.SuspendLayout();
            this.tabViews.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.View)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.View3D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlightMarker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Editor)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Interval = 500;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // menuMain
            // 
            this.menuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuView,
            this.menuSettings,
            this.menuHelp});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuMain.Size = new System.Drawing.Size(1024, 24);
            this.menuMain.TabIndex = 15;
            this.menuMain.Text = "MenuStrip";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNew,
            this.menuOpen,
            this.menuSeparator1,
            this.menuSave,
            this.menuSaveAs,
            this.menuSeperator2,
            this.menuExit});
            this.menuFile.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "&File";
            // 
            // menuNew
            // 
            this.menuNew.Image = ((System.Drawing.Image)(resources.GetObject("menuNew.Image")));
            this.menuNew.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuNew.Name = "menuNew";
            this.menuNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuNew.Size = new System.Drawing.Size(146, 22);
            this.menuNew.Text = "&New";
            this.menuNew.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // menuOpen
            // 
            this.menuOpen.Image = ((System.Drawing.Image)(resources.GetObject("menuOpen.Image")));
            this.menuOpen.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuOpen.Size = new System.Drawing.Size(146, 22);
            this.menuOpen.Text = "&Open";
            this.menuOpen.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // menuSeparator1
            // 
            this.menuSeparator1.Name = "menuSeparator1";
            this.menuSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // menuSave
            // 
            this.menuSave.Image = ((System.Drawing.Image)(resources.GetObject("menuSave.Image")));
            this.menuSave.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuSave.Name = "menuSave";
            this.menuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuSave.Size = new System.Drawing.Size(146, 22);
            this.menuSave.Text = "&Save";
            this.menuSave.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // menuSaveAs
            // 
            this.menuSaveAs.Name = "menuSaveAs";
            this.menuSaveAs.Size = new System.Drawing.Size(146, 22);
            this.menuSaveAs.Text = "Save &As";
            this.menuSaveAs.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // menuSeperator2
            // 
            this.menuSeperator2.Name = "menuSeperator2";
            this.menuSeperator2.Size = new System.Drawing.Size(143, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(146, 22);
            this.menuExit.Text = "E&xit";
            this.menuExit.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // menuView
            // 
            this.menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolbar,
            this.menuStatusBar,
            this.menuSeparator3,
            this.menuSelect,
            this.menuPan,
            this.menuEdit,
            this.menuRotate,
            this.menuZoom,
            this.menuZoomIn,
            this.menuZoomOut,
            this.menuSeparator4,
            this.menuRefresh});
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(44, 20);
            this.menuView.Text = "&View";
            // 
            // menuToolbar
            // 
            this.menuToolbar.Checked = true;
            this.menuToolbar.CheckOnClick = true;
            this.menuToolbar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuToolbar.Name = "menuToolbar";
            this.menuToolbar.Size = new System.Drawing.Size(129, 22);
            this.menuToolbar.Text = "&Toolbar";
            this.menuToolbar.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // menuStatusBar
            // 
            this.menuStatusBar.Checked = true;
            this.menuStatusBar.CheckOnClick = true;
            this.menuStatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuStatusBar.Name = "menuStatusBar";
            this.menuStatusBar.Size = new System.Drawing.Size(129, 22);
            this.menuStatusBar.Text = "Status &Bar";
            this.menuStatusBar.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // menuSeparator3
            // 
            this.menuSeparator3.Name = "menuSeparator3";
            this.menuSeparator3.Size = new System.Drawing.Size(126, 6);
            // 
            // menuSelect
            // 
            this.menuSelect.Name = "menuSelect";
            this.menuSelect.Size = new System.Drawing.Size(129, 22);
            this.menuSelect.Text = "&Select";
            this.menuSelect.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // menuPan
            // 
            this.menuPan.Name = "menuPan";
            this.menuPan.Size = new System.Drawing.Size(129, 22);
            this.menuPan.Text = "&Pan";
            this.menuPan.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(129, 22);
            this.menuEdit.Text = "Edit";
            // 
            // menuRotate
            // 
            this.menuRotate.Name = "menuRotate";
            this.menuRotate.Size = new System.Drawing.Size(129, 22);
            this.menuRotate.Text = "&Rotate";
            // 
            // menuZoom
            // 
            this.menuZoom.Name = "menuZoom";
            this.menuZoom.Size = new System.Drawing.Size(129, 22);
            this.menuZoom.Text = "&Zoom";
            // 
            // menuZoomIn
            // 
            this.menuZoomIn.Name = "menuZoomIn";
            this.menuZoomIn.Size = new System.Drawing.Size(129, 22);
            this.menuZoomIn.Text = "&Zoom In";
            this.menuZoomIn.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // menuZoomOut
            // 
            this.menuZoomOut.Name = "menuZoomOut";
            this.menuZoomOut.Size = new System.Drawing.Size(129, 22);
            this.menuZoomOut.Text = "Zoom &Out";
            this.menuZoomOut.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // menuSeparator4
            // 
            this.menuSeparator4.Name = "menuSeparator4";
            this.menuSeparator4.Size = new System.Drawing.Size(126, 6);
            // 
            // menuRefresh
            // 
            this.menuRefresh.Name = "menuRefresh";
            this.menuRefresh.Size = new System.Drawing.Size(129, 22);
            this.menuRefresh.Text = "Refresh";
            this.menuRefresh.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // menuSettings
            // 
            this.menuSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSettingsEdit});
            this.menuSettings.Name = "menuSettings";
            this.menuSettings.Size = new System.Drawing.Size(61, 20);
            this.menuSettings.Text = "&Settings";
            // 
            // menuSettingsEdit
            // 
            this.menuSettingsEdit.Name = "menuSettingsEdit";
            this.menuSettingsEdit.Size = new System.Drawing.Size(94, 22);
            this.menuSettingsEdit.Text = "&Edit";
            this.menuSettingsEdit.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 20);
            this.menuHelp.Text = "&Help";
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(140, 22);
            this.menuAbout.Text = "&About Flight";
            this.menuAbout.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // StatusBar
            // 
            this.StatusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelCoX,
            this.LabelCoY,
            this.LabelTime});
            this.StatusBar.Location = new System.Drawing.Point(0, 546);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.StatusBar.Size = new System.Drawing.Size(1024, 22);
            this.StatusBar.TabIndex = 19;
            // 
            // LabelCoX
            // 
            this.LabelCoX.AutoSize = false;
            this.LabelCoX.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.LabelCoX.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LabelCoX.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelCoX.Margin = new System.Windows.Forms.Padding(0, 3, 2, 2);
            this.LabelCoX.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.LabelCoX.Name = "LabelCoX";
            this.LabelCoX.Size = new System.Drawing.Size(60, 17);
            this.LabelCoX.Text = "X: -";
            this.LabelCoX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelCoY
            // 
            this.LabelCoY.AutoSize = false;
            this.LabelCoY.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.LabelCoY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelCoY.Margin = new System.Windows.Forms.Padding(0, 3, 2, 2);
            this.LabelCoY.Name = "LabelCoY";
            this.LabelCoY.Padding = new System.Windows.Forms.Padding(1);
            this.LabelCoY.Size = new System.Drawing.Size(60, 17);
            this.LabelCoY.Text = "Y: -";
            this.LabelCoY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = false;
            this.LabelTime.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.LabelTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(140, 17);
            this.LabelTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(439, 474);
            // 
            // tbDocument
            // 
            this.tbDocument.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tbDocument.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tbDocument.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbNew,
            this.tbOpen,
            this.tbSave,
            this.ToolStripSeparator3,
            this.tbRefresh,
            this.tbInfinite,
            this.tbMark,
            this.tbSimulate,
            this.onTheFlyBt,
            this.tbStepAndRepeatBt,
            this.tbAbort,
            this.ToolStripSeparator5,
            this.tbUpload,
            this.tbFlashExplorer,
            this.toolStripSeparator2,
            this.tbSelect,
            this.tbEdit,
            this.tbPan,
            this.tbRotate,
            this.tbZoom,
            this.tbZoomIn,
            this.tbZoomOut,
            this.ToolStripSeparator4,
            this.tbGrid,
            this.tbViewSelection,
            this.tbTopView,
            this.tbFrontView,
            this.tbSideView,
            this.tbEditor,
            this.tbCalibrate,
            this.toolStripSeparator6,
            this.tbSettings});
            this.tbDocument.Location = new System.Drawing.Point(0, 24);
            this.tbDocument.Name = "tbDocument";
            this.tbDocument.Padding = new System.Windows.Forms.Padding(0);
            this.tbDocument.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tbDocument.Size = new System.Drawing.Size(1024, 31);
            this.tbDocument.TabIndex = 21;
            this.tbDocument.Text = "Colors";
            // 
            // tbNew
            // 
            this.tbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbNew.Image = ((System.Drawing.Image)(resources.GetObject("tbNew.Image")));
            this.tbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbNew.Name = "tbNew";
            this.tbNew.Size = new System.Drawing.Size(28, 28);
            this.tbNew.Text = "New document";
            this.tbNew.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // tbOpen
            // 
            this.tbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tbOpen.Image")));
            this.tbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbOpen.Name = "tbOpen";
            this.tbOpen.Size = new System.Drawing.Size(28, 28);
            this.tbOpen.Text = "Load document";
            this.tbOpen.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // tbSave
            // 
            this.tbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbSave.Image = ((System.Drawing.Image)(resources.GetObject("tbSave.Image")));
            this.tbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSave.Name = "tbSave";
            this.tbSave.Size = new System.Drawing.Size(28, 28);
            this.tbSave.Text = "Save document";
            this.tbSave.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // tbRefresh
            // 
            this.tbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tbRefresh.Image")));
            this.tbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbRefresh.Name = "tbRefresh";
            this.tbRefresh.Size = new System.Drawing.Size(28, 28);
            this.tbRefresh.Text = "Refresh";
            this.tbRefresh.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // tbInfinite
            // 
            this.tbInfinite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbInfinite.Image = ((System.Drawing.Image)(resources.GetObject("tbInfinite.Image")));
            this.tbInfinite.ImageTransparentColor = System.Drawing.Color.White;
            this.tbInfinite.Name = "tbInfinite";
            this.tbInfinite.Size = new System.Drawing.Size(28, 28);
            this.tbInfinite.Text = "Start Infinite Marking";
            this.tbInfinite.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // tbMark
            // 
            this.tbMark.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbMark.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MarkingParamsChBox});
            this.tbMark.Image = ((System.Drawing.Image)(resources.GetObject("tbMark.Image")));
            this.tbMark.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbMark.Name = "tbMark";
            this.tbMark.Size = new System.Drawing.Size(40, 28);
            this.tbMark.Text = "Mark";
            this.tbMark.ButtonClick += new System.EventHandler(this.menuMain_Click);
            // 
            // MarkingParamsChBox
            // 
            this.MarkingParamsChBox.Name = "MarkingParamsChBox";
            this.MarkingParamsChBox.Size = new System.Drawing.Size(214, 22);
            this.MarkingParamsChBox.Text = "Apply Marking Parameters";
            this.MarkingParamsChBox.Click += new System.EventHandler(this.MarkingParamsChBox_Click);
            // 
            // tbSimulate
            // 
            this.tbSimulate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbSimulate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AreaSimChBox});
            this.tbSimulate.Image = ((System.Drawing.Image)(resources.GetObject("tbSimulate.Image")));
            this.tbSimulate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSimulate.Name = "tbSimulate";
            this.tbSimulate.Size = new System.Drawing.Size(40, 28);
            this.tbSimulate.Text = "Simulate";
            this.tbSimulate.ButtonClick += new System.EventHandler(this.menuMain_Click);
            // 
            // AreaSimChBox
            // 
            this.AreaSimChBox.Name = "AreaSimChBox";
            this.AreaSimChBox.Size = new System.Drawing.Size(147, 22);
            this.AreaSimChBox.Text = "Simulate Area";
            this.AreaSimChBox.Click += new System.EventHandler(this.AreaSimChBox_Click);
            // 
            // onTheFlyBt
            // 
            this.onTheFlyBt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.onTheFlyBt.Image = ((System.Drawing.Image)(resources.GetObject("onTheFlyBt.Image")));
            this.onTheFlyBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.onTheFlyBt.Name = "onTheFlyBt";
            this.onTheFlyBt.Size = new System.Drawing.Size(28, 28);
            this.onTheFlyBt.Text = "Start On The Fly";
            this.onTheFlyBt.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // tbStepAndRepeatBt
            // 
            this.tbStepAndRepeatBt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbStepAndRepeatBt.Image = ((System.Drawing.Image)(resources.GetObject("tbStepAndRepeatBt.Image")));
            this.tbStepAndRepeatBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbStepAndRepeatBt.Name = "tbStepAndRepeatBt";
            this.tbStepAndRepeatBt.Size = new System.Drawing.Size(28, 28);
            this.tbStepAndRepeatBt.Text = "Step And Repeat";
            this.tbStepAndRepeatBt.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // tbAbort
            // 
            this.tbAbort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbAbort.Image = ((System.Drawing.Image)(resources.GetObject("tbAbort.Image")));
            this.tbAbort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbAbort.Name = "tbAbort";
            this.tbAbort.Size = new System.Drawing.Size(28, 28);
            this.tbAbort.Text = "Abort Marking";
            this.tbAbort.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // ToolStripSeparator5
            // 
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // tbUpload
            // 
            this.tbUpload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbUpload.Image = ((System.Drawing.Image)(resources.GetObject("tbUpload.Image")));
            this.tbUpload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbUpload.Name = "tbUpload";
            this.tbUpload.Size = new System.Drawing.Size(28, 28);
            this.tbUpload.Text = "Store To Flash";
            this.tbUpload.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // tbFlashExplorer
            // 
            this.tbFlashExplorer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbFlashExplorer.Image = ((System.Drawing.Image)(resources.GetObject("tbFlashExplorer.Image")));
            this.tbFlashExplorer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbFlashExplorer.Name = "tbFlashExplorer";
            this.tbFlashExplorer.Size = new System.Drawing.Size(28, 28);
            this.tbFlashExplorer.Text = "Flash Explorer";
            this.tbFlashExplorer.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // tbSelect
            // 
            this.tbSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbSelect.Image = ((System.Drawing.Image)(resources.GetObject("tbSelect.Image")));
            this.tbSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSelect.Name = "tbSelect";
            this.tbSelect.Size = new System.Drawing.Size(28, 28);
            this.tbSelect.Text = "Select";
            this.tbSelect.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // tbEdit
            // 
            this.tbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tbEdit.Image")));
            this.tbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.Size = new System.Drawing.Size(28, 28);
            this.tbEdit.Text = "Edit objects";
            this.tbEdit.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // tbPan
            // 
            this.tbPan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbPan.Image = ((System.Drawing.Image)(resources.GetObject("tbPan.Image")));
            this.tbPan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbPan.Name = "tbPan";
            this.tbPan.Size = new System.Drawing.Size(28, 28);
            this.tbPan.Text = "Pan document";
            this.tbPan.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // tbRotate
            // 
            this.tbRotate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbRotate.Image = ((System.Drawing.Image)(resources.GetObject("tbRotate.Image")));
            this.tbRotate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbRotate.Name = "tbRotate";
            this.tbRotate.Size = new System.Drawing.Size(28, 28);
            this.tbRotate.Text = "Rotate View";
            this.tbRotate.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // tbZoom
            // 
            this.tbZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbZoom.Image = ((System.Drawing.Image)(resources.GetObject("tbZoom.Image")));
            this.tbZoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbZoom.Name = "tbZoom";
            this.tbZoom.Size = new System.Drawing.Size(28, 28);
            this.tbZoom.Text = "Zoom In/Out";
            this.tbZoom.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // tbZoomIn
            // 
            this.tbZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("tbZoomIn.Image")));
            this.tbZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbZoomIn.Name = "tbZoomIn";
            this.tbZoomIn.Size = new System.Drawing.Size(28, 28);
            this.tbZoomIn.Text = "Zoom In";
            this.tbZoomIn.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // tbZoomOut
            // 
            this.tbZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("tbZoomOut.Image")));
            this.tbZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbZoomOut.Name = "tbZoomOut";
            this.tbZoomOut.Size = new System.Drawing.Size(28, 28);
            this.tbZoomOut.Text = "Zoom Out";
            this.tbZoomOut.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // ToolStripSeparator4
            // 
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // tbGrid
            // 
            this.tbGrid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbGrid.Image = ((System.Drawing.Image)(resources.GetObject("tbGrid.Image")));
            this.tbGrid.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbGrid.Name = "tbGrid";
            this.tbGrid.Size = new System.Drawing.Size(28, 28);
            this.tbGrid.Text = "Toggle Grid";
            this.tbGrid.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // tbViewSelection
            // 
            this.tbViewSelection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbViewSelection.Image = ((System.Drawing.Image)(resources.GetObject("tbViewSelection.Image")));
            this.tbViewSelection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbViewSelection.Name = "tbViewSelection";
            this.tbViewSelection.Size = new System.Drawing.Size(28, 28);
            this.tbViewSelection.Text = "View Selection";
            this.tbViewSelection.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // tbTopView
            // 
            this.tbTopView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbTopView.Image = ((System.Drawing.Image)(resources.GetObject("tbTopView.Image")));
            this.tbTopView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbTopView.Name = "tbTopView";
            this.tbTopView.Size = new System.Drawing.Size(28, 28);
            this.tbTopView.Text = "TopView";
            this.tbTopView.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // tbFrontView
            // 
            this.tbFrontView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbFrontView.Image = ((System.Drawing.Image)(resources.GetObject("tbFrontView.Image")));
            this.tbFrontView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbFrontView.Name = "tbFrontView";
            this.tbFrontView.Size = new System.Drawing.Size(28, 28);
            this.tbFrontView.Text = "FrontView";
            this.tbFrontView.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // tbSideView
            // 
            this.tbSideView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbSideView.Image = ((System.Drawing.Image)(resources.GetObject("tbSideView.Image")));
            this.tbSideView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSideView.Name = "tbSideView";
            this.tbSideView.Size = new System.Drawing.Size(28, 28);
            this.tbSideView.Text = "SideView";
            this.tbSideView.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // tbEditor
            // 
            this.tbEditor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbEditor.Image = ((System.Drawing.Image)(resources.GetObject("tbEditor.Image")));
            this.tbEditor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbEditor.Name = "tbEditor";
            this.tbEditor.Size = new System.Drawing.Size(28, 28);
            this.tbEditor.Text = "Editor";
            this.tbEditor.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // tbCalibrate
            // 
            this.tbCalibrate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbCalibrate.Image = ((System.Drawing.Image)(resources.GetObject("tbCalibrate.Image")));
            this.tbCalibrate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbCalibrate.Name = "tbCalibrate";
            this.tbCalibrate.Size = new System.Drawing.Size(28, 28);
            this.tbCalibrate.Text = "Calibrate";
            this.tbCalibrate.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 31);
            // 
            // tbSettings
            // 
            this.tbSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbSettings.Image = ((System.Drawing.Image)(resources.GetObject("tbSettings.Image")));
            this.tbSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSettings.Name = "tbSettings";
            this.tbSettings.Size = new System.Drawing.Size(28, 28);
            this.tbSettings.Text = "Settings";
            this.tbSettings.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // Leds
            // 
            this.Leds.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Leds.ImageStream")));
            this.Leds.TransparentColor = System.Drawing.Color.Fuchsia;
            this.Leds.Images.SetKeyName(0, "Leds_big_grey.bmp");
            this.Leds.Images.SetKeyName(1, "Leds_big_green.bmp");
            this.Leds.Images.SetKeyName(2, "Leds_big_red.bmp");
            // 
            // TabulaImg
            // 
            this.TabulaImg.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TabulaImg.ImageStream")));
            this.TabulaImg.TransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.TabulaImg.Images.SetKeyName(0, "Reference.bmp");
            this.TabulaImg.Images.SetKeyName(1, "Stop.bmp");
            this.TabulaImg.Images.SetKeyName(2, "Up.bmp");
            this.TabulaImg.Images.SetKeyName(3, "Down.bmp");
            this.TabulaImg.Images.SetKeyName(4, "Left.bmp");
            this.TabulaImg.Images.SetKeyName(5, "Right.bmp");
            this.TabulaImg.Images.SetKeyName(6, "IconHome.bmp");
            this.TabulaImg.Images.SetKeyName(7, "IconP1.bmp");
            // 
            // SplitView
            // 
            this.SplitView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitView.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SplitView.IsSplitterFixed = true;
            this.SplitView.Location = new System.Drawing.Point(0, 55);
            this.SplitView.Name = "SplitView";
            // 
            // SplitView.Panel1
            // 
            this.SplitView.Panel1.Controls.Add(this.FlightTab2);
            this.SplitView.Panel1.Controls.Add(this.FlightTab);
            this.SplitView.Panel1.Padding = new System.Windows.Forms.Padding(3);
            // 
            // SplitView.Panel2
            // 
            this.SplitView.Panel2.Controls.Add(this.splitView2);
            this.SplitView.Panel2.Controls.Add(this.FlightMarker);
            this.SplitView.Panel2.Controls.Add(this.Editor);
            this.SplitView.Size = new System.Drawing.Size(1024, 491);
            this.SplitView.SplitterDistance = 311;
            this.SplitView.TabIndex = 20;
            // 
            // FlightTab2
            // 
            this.FlightTab2.Controls.Add(this.TabObjects);
            this.FlightTab2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlightTab2.Location = new System.Drawing.Point(3, 333);
            this.FlightTab2.Name = "FlightTab2";
            this.FlightTab2.Padding = new System.Drawing.Point(13, 3);
            this.FlightTab2.SelectedIndex = 0;
            this.FlightTab2.Size = new System.Drawing.Size(305, 155);
            this.FlightTab2.TabIndex = 16;
            // 
            // TabObjects
            // 
            this.TabObjects.Controls.Add(this.Tree);
            this.TabObjects.Controls.Add(this.PropTree);
            this.TabObjects.Controls.Add(this.tbObjects);
            this.TabObjects.Location = new System.Drawing.Point(4, 22);
            this.TabObjects.Name = "TabObjects";
            this.TabObjects.Padding = new System.Windows.Forms.Padding(3);
            this.TabObjects.Size = new System.Drawing.Size(297, 129);
            this.TabObjects.TabIndex = 0;
            this.TabObjects.Text = "Objects";
            this.TabObjects.UseVisualStyleBackColor = true;
            // 
            // Tree
            // 
            this.Tree.Location = new System.Drawing.Point(36, 3);
            this.Tree.Margin = new System.Windows.Forms.Padding(0);
            this.Tree.Name = "Tree";
            this.Tree.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Tree.OcxState")));
            this.Tree.Size = new System.Drawing.Size(636, 155);
            this.Tree.TabIndex = 5;
            this.Tree.Change += new System.EventHandler(this.Tree_Change);
            // 
            // PropTree
            // 
            this.PropTree.Location = new System.Drawing.Point(36, 56);
            this.PropTree.Name = "PropTree";
            this.PropTree.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PropTree.OcxState")));
            this.PropTree.Size = new System.Drawing.Size(639, 596);
            this.PropTree.TabIndex = 6;
            this.PropTree.PropertyChanged += new System.EventHandler(this.Flight_PropertyChanged);
            // 
            // tbObjects
            // 
            this.tbObjects.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbObjects.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tbObjects.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tbObjects.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbObjects.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmdRemoveObject,
            this.CmdCopy,
            this.CmdAddBitmap,
            this.CmdAddStruct,
            this.CmdAdd3DScript,
            this.CmdAdd3DStruct,
            this.CmdAddDrawing,
            this.CmdAddText,
            this.CmdAddCircularText,
            this.CmdAddGroup,
            this.CmdAddEvent,
            this.CmdAddSection});
            this.tbObjects.Location = new System.Drawing.Point(3, 3);
            this.tbObjects.Name = "tbObjects";
            this.tbObjects.Padding = new System.Windows.Forms.Padding(0);
            this.tbObjects.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tbObjects.Size = new System.Drawing.Size(28, 123);
            this.tbObjects.TabIndex = 12;
            this.tbObjects.Text = "Pens";
            this.tbObjects.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tbObjects_ItemClicked);
            // 
            // CmdRemoveObject
            // 
            this.CmdRemoveObject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CmdRemoveObject.Image = ((System.Drawing.Image)(resources.GetObject("CmdRemoveObject.Image")));
            this.CmdRemoveObject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdRemoveObject.Name = "CmdRemoveObject";
            this.CmdRemoveObject.Size = new System.Drawing.Size(27, 28);
            this.CmdRemoveObject.Text = "Remove Object";
            // 
            // CmdCopy
            // 
            this.CmdCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CmdCopy.Image = ((System.Drawing.Image)(resources.GetObject("CmdCopy.Image")));
            this.CmdCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdCopy.Name = "CmdCopy";
            this.CmdCopy.Size = new System.Drawing.Size(27, 28);
            this.CmdCopy.Text = "Duplicate Item";
            // 
            // CmdAddBitmap
            // 
            this.CmdAddBitmap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CmdAddBitmap.Image = ((System.Drawing.Image)(resources.GetObject("CmdAddBitmap.Image")));
            this.CmdAddBitmap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdAddBitmap.Name = "CmdAddBitmap";
            this.CmdAddBitmap.Size = new System.Drawing.Size(27, 28);
            this.CmdAddBitmap.Text = "Add Bitmap";
            // 
            // CmdAddStruct
            // 
            this.CmdAddStruct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CmdAddStruct.Image = ((System.Drawing.Image)(resources.GetObject("CmdAddStruct.Image")));
            this.CmdAddStruct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdAddStruct.Name = "CmdAddStruct";
            this.CmdAddStruct.Size = new System.Drawing.Size(28, 28);
            this.CmdAddStruct.Text = "Add Structure";
            // 
            // CmdAdd3DScript
            // 
            this.CmdAdd3DScript.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CmdAdd3DScript.Image = ((System.Drawing.Image)(resources.GetObject("CmdAdd3DScript.Image")));
            this.CmdAdd3DScript.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdAdd3DScript.Name = "CmdAdd3DScript";
            this.CmdAdd3DScript.Size = new System.Drawing.Size(28, 28);
            this.CmdAdd3DScript.Text = "Add 3D Script";
            this.CmdAdd3DScript.ToolTipText = "Add 3D G-code";
            // 
            // CmdAdd3DStruct
            // 
            this.CmdAdd3DStruct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CmdAdd3DStruct.Image = ((System.Drawing.Image)(resources.GetObject("CmdAdd3DStruct.Image")));
            this.CmdAdd3DStruct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdAdd3DStruct.Name = "CmdAdd3DStruct";
            this.CmdAdd3DStruct.Size = new System.Drawing.Size(28, 28);
            this.CmdAdd3DStruct.Text = "Add 3D Structure";
            // 
            // CmdAddDrawing
            // 
            this.CmdAddDrawing.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CmdAddDrawing.Image = ((System.Drawing.Image)(resources.GetObject("CmdAddDrawing.Image")));
            this.CmdAddDrawing.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdAddDrawing.Name = "CmdAddDrawing";
            this.CmdAddDrawing.Size = new System.Drawing.Size(28, 28);
            this.CmdAddDrawing.Text = "Create Drawing";
            // 
            // CmdAddText
            // 
            this.CmdAddText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CmdAddText.Image = ((System.Drawing.Image)(resources.GetObject("CmdAddText.Image")));
            this.CmdAddText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdAddText.Name = "CmdAddText";
            this.CmdAddText.Size = new System.Drawing.Size(28, 28);
            this.CmdAddText.Text = "Add Text";
            // 
            // CmdAddCircularText
            // 
            this.CmdAddCircularText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CmdAddCircularText.Image = ((System.Drawing.Image)(resources.GetObject("CmdAddCircularText.Image")));
            this.CmdAddCircularText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdAddCircularText.Name = "CmdAddCircularText";
            this.CmdAddCircularText.Size = new System.Drawing.Size(28, 28);
            this.CmdAddCircularText.Text = "Add Circular Text";
            // 
            // CmdAddGroup
            // 
            this.CmdAddGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CmdAddGroup.Image = ((System.Drawing.Image)(resources.GetObject("CmdAddGroup.Image")));
            this.CmdAddGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdAddGroup.Name = "CmdAddGroup";
            this.CmdAddGroup.Size = new System.Drawing.Size(28, 28);
            this.CmdAddGroup.Text = "Add Group";
            // 
            // CmdAddEvent
            // 
            this.CmdAddEvent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CmdAddEvent.Image = ((System.Drawing.Image)(resources.GetObject("CmdAddEvent.Image")));
            this.CmdAddEvent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdAddEvent.Name = "CmdAddEvent";
            this.CmdAddEvent.Size = new System.Drawing.Size(28, 28);
            this.CmdAddEvent.Text = "Add Event";
            // 
            // CmdAddSection
            // 
            this.CmdAddSection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CmdAddSection.Image = ((System.Drawing.Image)(resources.GetObject("CmdAddSection.Image")));
            this.CmdAddSection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdAddSection.Name = "CmdAddSection";
            this.CmdAddSection.Size = new System.Drawing.Size(28, 28);
            this.CmdAddSection.Text = "toolStripButton1";
            this.CmdAddSection.ToolTipText = "Add Section";
            // 
            // FlightTab
            // 
            this.FlightTab.Controls.Add(this.TabPage1);
            this.FlightTab.Controls.Add(this.TabPage2);
            this.FlightTab.Controls.Add(this.TabPage3);
            this.FlightTab.Controls.Add(this.TabPage4);
            this.FlightTab.Controls.Add(this.tabPage5);
            this.FlightTab.Controls.Add(this.tabPage8);
            this.FlightTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.FlightTab.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FlightTab.Location = new System.Drawing.Point(3, 3);
            this.FlightTab.Multiline = true;
            this.FlightTab.Name = "FlightTab";
            this.FlightTab.Padding = new System.Drawing.Point(7, 3);
            this.FlightTab.SelectedIndex = 0;
            this.FlightTab.Size = new System.Drawing.Size(305, 330);
            this.FlightTab.TabIndex = 15;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.PropColors);
            this.TabPage1.Controls.Add(this.Colors);
            this.TabPage1.Controls.Add(this.tbColors);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(297, 304);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Colors";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // PropColors
            // 
            this.PropColors.Location = new System.Drawing.Point(36, 33);
            this.PropColors.Name = "PropColors";
            this.PropColors.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PropColors.OcxState")));
            this.PropColors.Size = new System.Drawing.Size(624, 647);
            this.PropColors.TabIndex = 5;
            this.PropColors.PropertyChanged += new System.EventHandler(this.Flight_PropertyChanged);
            // 
            // Colors
            // 
            this.Colors.Location = new System.Drawing.Point(36, 6);
            this.Colors.Name = "Colors";
            this.Colors.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Colors.OcxState")));
            this.Colors.Size = new System.Drawing.Size(255, 21);
            this.Colors.TabIndex = 7;
            this.Colors.ClickEvent += new System.EventHandler(this.Colors_ClickEvent);
            // 
            // tbColors
            // 
            this.tbColors.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbColors.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tbColors.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tbColors.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbColors.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmdRemoveColor,
            this.CmdAddColor,
            this.ToolStripSeparator1,
            this.CmdChangeColor});
            this.tbColors.Location = new System.Drawing.Point(3, 3);
            this.tbColors.Name = "tbColors";
            this.tbColors.Padding = new System.Windows.Forms.Padding(0);
            this.tbColors.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tbColors.Size = new System.Drawing.Size(28, 298);
            this.tbColors.TabIndex = 6;
            this.tbColors.Text = "Colors";
            this.tbColors.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tbColors_ItemClicked);
            // 
            // CmdRemoveColor
            // 
            this.CmdRemoveColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CmdRemoveColor.Image = ((System.Drawing.Image)(resources.GetObject("CmdRemoveColor.Image")));
            this.CmdRemoveColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdRemoveColor.Name = "CmdRemoveColor";
            this.CmdRemoveColor.Size = new System.Drawing.Size(27, 28);
            this.CmdRemoveColor.Text = "Remove Color";
            // 
            // CmdAddColor
            // 
            this.CmdAddColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CmdAddColor.Image = ((System.Drawing.Image)(resources.GetObject("CmdAddColor.Image")));
            this.CmdAddColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdAddColor.Name = "CmdAddColor";
            this.CmdAddColor.Size = new System.Drawing.Size(27, 28);
            this.CmdAddColor.Text = "Add Color";
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(27, 6);
            // 
            // CmdChangeColor
            // 
            this.CmdChangeColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CmdChangeColor.Image = ((System.Drawing.Image)(resources.GetObject("CmdChangeColor.Image")));
            this.CmdChangeColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdChangeColor.Name = "CmdChangeColor";
            this.CmdChangeColor.Size = new System.Drawing.Size(27, 28);
            this.CmdChangeColor.Text = "Change Color";
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.textBox1);
            this.TabPage2.Controls.Add(this.MultiHatchingChBox);
            this.TabPage2.Controls.Add(this.tbPens);
            this.TabPage2.Controls.Add(this.PropPens);
            this.TabPage2.Controls.Add(this.Pens);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(297, 304);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Pens";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(42, 252);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(83, 13);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Multiple Hatching";
            // 
            // MultiHatchingChBox
            // 
            this.MultiHatchingChBox.AutoSize = true;
            this.MultiHatchingChBox.Location = new System.Drawing.Point(139, 252);
            this.MultiHatchingChBox.Margin = new System.Windows.Forms.Padding(2);
            this.MultiHatchingChBox.Name = "MultiHatchingChBox";
            this.MultiHatchingChBox.Size = new System.Drawing.Size(15, 14);
            this.MultiHatchingChBox.TabIndex = 10;
            this.MultiHatchingChBox.UseVisualStyleBackColor = true;
            // 
            // tbPens
            // 
            this.tbPens.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbPens.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tbPens.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tbPens.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmdRemovePen,
            this.CmdAddPen});
            this.tbPens.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.tbPens.Location = new System.Drawing.Point(3, 3);
            this.tbPens.Name = "tbPens";
            this.tbPens.Padding = new System.Windows.Forms.Padding(0);
            this.tbPens.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tbPens.Size = new System.Drawing.Size(28, 298);
            this.tbPens.TabIndex = 9;
            this.tbPens.Text = "Pens";
            this.tbPens.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tbPens_ItemClicked);
            // 
            // CmdRemovePen
            // 
            this.CmdRemovePen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CmdRemovePen.Image = ((System.Drawing.Image)(resources.GetObject("CmdRemovePen.Image")));
            this.CmdRemovePen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdRemovePen.Name = "CmdRemovePen";
            this.CmdRemovePen.Size = new System.Drawing.Size(27, 28);
            this.CmdRemovePen.Text = "Remove Pen";
            // 
            // CmdAddPen
            // 
            this.CmdAddPen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CmdAddPen.Image = ((System.Drawing.Image)(resources.GetObject("CmdAddPen.Image")));
            this.CmdAddPen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdAddPen.Name = "CmdAddPen";
            this.CmdAddPen.Size = new System.Drawing.Size(27, 28);
            this.CmdAddPen.Text = "Add Pen";
            // 
            // PropPens
            // 
            this.PropPens.Location = new System.Drawing.Point(36, 33);
            this.PropPens.Name = "PropPens";
            this.PropPens.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PropPens.OcxState")));
            this.PropPens.Size = new System.Drawing.Size(624, 647);
            this.PropPens.TabIndex = 1;
            this.PropPens.PropertyChanged += new System.EventHandler(this.Flight_PropertyChanged);
            // 
            // Pens
            // 
            this.Pens.Location = new System.Drawing.Point(36, 6);
            this.Pens.Name = "Pens";
            this.Pens.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Pens.OcxState")));
            this.Pens.Size = new System.Drawing.Size(624, 21);
            this.Pens.TabIndex = 0;
            this.Pens.ClickEvent += new System.EventHandler(this.Pens_ClickEvent);
            // 
            // TabPage3
            // 
            this.TabPage3.Controls.Add(this.PropFonts);
            this.TabPage3.Controls.Add(this.tbFonts);
            this.TabPage3.Controls.Add(this.Fonts);
            this.TabPage3.Location = new System.Drawing.Point(4, 22);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage3.Size = new System.Drawing.Size(297, 304);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "Fonts";
            this.TabPage3.UseVisualStyleBackColor = true;
            // 
            // PropFonts
            // 
            this.PropFonts.Location = new System.Drawing.Point(36, 33);
            this.PropFonts.Name = "PropFonts";
            this.PropFonts.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PropFonts.OcxState")));
            this.PropFonts.Size = new System.Drawing.Size(624, 647);
            this.PropFonts.TabIndex = 1;
            this.PropFonts.PropertyChanged += new System.EventHandler(this.Flight_PropertyChanged);
            // 
            // tbFonts
            // 
            this.tbFonts.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbFonts.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tbFonts.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tbFonts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmdRemoveFont,
            this.CmdAddTrueTypeFont,
            this.CmdAddSinglestrokeFont,
            this.CmdAddBarcodeFont});
            this.tbFonts.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.tbFonts.Location = new System.Drawing.Point(3, 3);
            this.tbFonts.Name = "tbFonts";
            this.tbFonts.Padding = new System.Windows.Forms.Padding(0);
            this.tbFonts.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tbFonts.Size = new System.Drawing.Size(28, 298);
            this.tbFonts.TabIndex = 8;
            this.tbFonts.Text = "Fonts";
            this.tbFonts.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tbFonts_ItemClicked);
            // 
            // CmdRemoveFont
            // 
            this.CmdRemoveFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CmdRemoveFont.Image = ((System.Drawing.Image)(resources.GetObject("CmdRemoveFont.Image")));
            this.CmdRemoveFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdRemoveFont.Name = "CmdRemoveFont";
            this.CmdRemoveFont.Size = new System.Drawing.Size(27, 28);
            this.CmdRemoveFont.Text = "Remove font";
            // 
            // CmdAddTrueTypeFont
            // 
            this.CmdAddTrueTypeFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CmdAddTrueTypeFont.Image = ((System.Drawing.Image)(resources.GetObject("CmdAddTrueTypeFont.Image")));
            this.CmdAddTrueTypeFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdAddTrueTypeFont.Name = "CmdAddTrueTypeFont";
            this.CmdAddTrueTypeFont.Size = new System.Drawing.Size(27, 28);
            this.CmdAddTrueTypeFont.Text = "Add TrueType Font";
            // 
            // CmdAddSinglestrokeFont
            // 
            this.CmdAddSinglestrokeFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CmdAddSinglestrokeFont.Image = ((System.Drawing.Image)(resources.GetObject("CmdAddSinglestrokeFont.Image")));
            this.CmdAddSinglestrokeFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdAddSinglestrokeFont.Name = "CmdAddSinglestrokeFont";
            this.CmdAddSinglestrokeFont.Size = new System.Drawing.Size(27, 28);
            this.CmdAddSinglestrokeFont.Text = "Add Singlestroke Font";
            // 
            // CmdAddBarcodeFont
            // 
            this.CmdAddBarcodeFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CmdAddBarcodeFont.Image = ((System.Drawing.Image)(resources.GetObject("CmdAddBarcodeFont.Image")));
            this.CmdAddBarcodeFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdAddBarcodeFont.Name = "CmdAddBarcodeFont";
            this.CmdAddBarcodeFont.Size = new System.Drawing.Size(27, 28);
            this.CmdAddBarcodeFont.Text = "Add Barcode Font";
            // 
            // Fonts
            // 
            this.Fonts.Location = new System.Drawing.Point(36, 6);
            this.Fonts.Name = "Fonts";
            this.Fonts.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Fonts.OcxState")));
            this.Fonts.Size = new System.Drawing.Size(624, 21);
            this.Fonts.TabIndex = 0;
            this.Fonts.ClickEvent += new System.EventHandler(this.Fonts_ClickEvent);
            // 
            // TabPage4
            // 
            this.TabPage4.Controls.Add(this.PropLayouts);
            this.TabPage4.Controls.Add(this.tbLayouts);
            this.TabPage4.Controls.Add(this.Layouts);
            this.TabPage4.Location = new System.Drawing.Point(4, 22);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage4.Size = new System.Drawing.Size(297, 304);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "Layouts";
            this.TabPage4.UseVisualStyleBackColor = true;
            // 
            // PropLayouts
            // 
            this.PropLayouts.Location = new System.Drawing.Point(36, 33);
            this.PropLayouts.Name = "PropLayouts";
            this.PropLayouts.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PropLayouts.OcxState")));
            this.PropLayouts.Size = new System.Drawing.Size(624, 647);
            this.PropLayouts.TabIndex = 1;
            this.PropLayouts.PropertyChanged += new System.EventHandler(this.Flight_PropertyChanged);
            // 
            // tbLayouts
            // 
            this.tbLayouts.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbLayouts.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tbLayouts.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tbLayouts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmdRemoveLayout,
            this.CmdAddLayout,
            this.StepRepeatGenerator,
            this.PrintParametersBt});
            this.tbLayouts.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.tbLayouts.Location = new System.Drawing.Point(3, 3);
            this.tbLayouts.Name = "tbLayouts";
            this.tbLayouts.Padding = new System.Windows.Forms.Padding(0);
            this.tbLayouts.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tbLayouts.Size = new System.Drawing.Size(31, 298);
            this.tbLayouts.TabIndex = 11;
            this.tbLayouts.Text = "Layouts";
            this.tbLayouts.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tbLayouts_ItemClicked);
            // 
            // CmdRemoveLayout
            // 
            this.CmdRemoveLayout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CmdRemoveLayout.Image = ((System.Drawing.Image)(resources.GetObject("CmdRemoveLayout.Image")));
            this.CmdRemoveLayout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdRemoveLayout.Name = "CmdRemoveLayout";
            this.CmdRemoveLayout.Size = new System.Drawing.Size(30, 28);
            this.CmdRemoveLayout.Text = "Remove Layout";
            // 
            // CmdAddLayout
            // 
            this.CmdAddLayout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CmdAddLayout.Image = ((System.Drawing.Image)(resources.GetObject("CmdAddLayout.Image")));
            this.CmdAddLayout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdAddLayout.Name = "CmdAddLayout";
            this.CmdAddLayout.Size = new System.Drawing.Size(30, 28);
            this.CmdAddLayout.Text = "Add Layout";
            // 
            // StepRepeatGenerator
            // 
            this.StepRepeatGenerator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StepRepeatGenerator.Image = ((System.Drawing.Image)(resources.GetObject("StepRepeatGenerator.Image")));
            this.StepRepeatGenerator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StepRepeatGenerator.Name = "StepRepeatGenerator";
            this.StepRepeatGenerator.Size = new System.Drawing.Size(30, 28);
            this.StepRepeatGenerator.Text = "Step Repeat Generator";
            this.StepRepeatGenerator.ToolTipText = "StepRepeatGenerator";
            // 
            // PrintParametersBt
            // 
            this.PrintParametersBt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrintParametersBt.Image = ((System.Drawing.Image)(resources.GetObject("PrintParametersBt.Image")));
            this.PrintParametersBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintParametersBt.Name = "PrintParametersBt";
            this.PrintParametersBt.Size = new System.Drawing.Size(30, 28);
            this.PrintParametersBt.Text = "Print Parameters";
            this.PrintParametersBt.Click += new System.EventHandler(this.PrintParametersBt_Click);
            // 
            // Layouts
            // 
            this.Layouts.Location = new System.Drawing.Point(36, 6);
            this.Layouts.Name = "Layouts";
            this.Layouts.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Layouts.OcxState")));
            this.Layouts.Size = new System.Drawing.Size(624, 21);
            this.Layouts.TabIndex = 0;
            this.Layouts.ClickEvent += new System.EventHandler(this.Layouts_ClickEvent);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tbSurface);
            this.tabPage5.Controls.Add(this.PropSurfaces);
            this.tabPage5.Controls.Add(this.Surfaces);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(297, 304);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Surfaces";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tbSurface
            // 
            this.tbSurface.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbSurface.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tbSurface.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tbSurface.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmdAddSurface,
            this.CmdRemoveSurface});
            this.tbSurface.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.tbSurface.Location = new System.Drawing.Point(3, 3);
            this.tbSurface.Name = "tbSurface";
            this.tbSurface.Padding = new System.Windows.Forms.Padding(0);
            this.tbSurface.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tbSurface.Size = new System.Drawing.Size(28, 298);
            this.tbSurface.TabIndex = 11;
            this.tbSurface.Text = "Pens";
            this.tbSurface.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tbSurface_ItemClicked);
            // 
            // CmdAddSurface
            // 
            this.CmdAddSurface.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CmdAddSurface.Image = ((System.Drawing.Image)(resources.GetObject("CmdAddSurface.Image")));
            this.CmdAddSurface.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdAddSurface.Name = "CmdAddSurface";
            this.CmdAddSurface.Size = new System.Drawing.Size(27, 28);
            this.CmdAddSurface.Text = "Add Surface";
            // 
            // CmdRemoveSurface
            // 
            this.CmdRemoveSurface.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CmdRemoveSurface.Image = ((System.Drawing.Image)(resources.GetObject("CmdRemoveSurface.Image")));
            this.CmdRemoveSurface.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdRemoveSurface.Name = "CmdRemoveSurface";
            this.CmdRemoveSurface.Size = new System.Drawing.Size(27, 28);
            this.CmdRemoveSurface.Text = "Remove Surface";
            // 
            // PropSurfaces
            // 
            this.PropSurfaces.Location = new System.Drawing.Point(36, 33);
            this.PropSurfaces.Name = "PropSurfaces";
            this.PropSurfaces.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PropSurfaces.OcxState")));
            this.PropSurfaces.Size = new System.Drawing.Size(624, 647);
            this.PropSurfaces.TabIndex = 1;
            this.PropSurfaces.PropertyChanged += new System.EventHandler(this.Flight_PropertyChanged);
            // 
            // Surfaces
            // 
            this.Surfaces.Location = new System.Drawing.Point(36, 6);
            this.Surfaces.Name = "Surfaces";
            this.Surfaces.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Surfaces.OcxState")));
            this.Surfaces.Size = new System.Drawing.Size(624, 21);
            this.Surfaces.TabIndex = 0;
            this.Surfaces.ClickEvent += new System.EventHandler(this.Surfaces_ClickEvent);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.PoDBox);
            this.tabPage8.Controls.Add(this.PodTrackBar);
            this.tabPage8.Controls.Add(this.textBox5);
            this.tabPage8.Controls.Add(this.label2);
            this.tabPage8.Controls.Add(this.GetLaserConfigBt);
            this.tabPage8.Controls.Add(this.label5);
            this.tabPage8.Controls.Add(this.SerialPortTxt);
            this.tabPage8.Controls.Add(this.SetLaserConfigBt);
            this.tabPage8.Controls.Add(this.PRFTrackBar);
            this.tabPage8.Controls.Add(this.BurstTrackBar);
            this.tabPage8.Controls.Add(this.PowerTrackBar);
            this.tabPage8.Controls.Add(this.textBox4);
            this.tabPage8.Controls.Add(this.textBox3);
            this.tabPage8.Controls.Add(this.textBox2);
            this.tabPage8.Controls.Add(this.label6);
            this.tabPage8.Controls.Add(this.label4);
            this.tabPage8.Controls.Add(this.label1);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(297, 304);
            this.tabPage8.TabIndex = 5;
            this.tabPage8.Text = "LaserCom";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // PoDBox
            // 
            this.PoDBox.AutoSize = true;
            this.PoDBox.Location = new System.Drawing.Point(218, 223);
            this.PoDBox.Name = "PoDBox";
            this.PoDBox.Size = new System.Drawing.Size(65, 17);
            this.PoDBox.TabIndex = 38;
            this.PoDBox.Text = "Enabled";
            this.PoDBox.UseVisualStyleBackColor = true;
            this.PoDBox.CheckedChanged += new System.EventHandler(this.PoDBox_CheckedChanged);
            // 
            // PodTrackBar
            // 
            this.PodTrackBar.Location = new System.Drawing.Point(239, 36);
            this.PodTrackBar.Minimum = 1;
            this.PodTrackBar.Name = "PodTrackBar";
            this.PodTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PodTrackBar.Size = new System.Drawing.Size(29, 153);
            this.PodTrackBar.TabIndex = 37;
            this.PodTrackBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.PodTrackBar.Value = 100;
            this.PodTrackBar.ValueChanged += new System.EventHandler(this.LaserPower_ValueChanged);
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox5.Location = new System.Drawing.Point(230, 196);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(47, 21);
            this.textBox5.TabIndex = 36;
            this.textBox5.Text = "1";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(222, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "PoD [kHz]";
            // 
            // GetLaserConfigBt
            // 
            this.GetLaserConfigBt.Location = new System.Drawing.Point(91, 268);
            this.GetLaserConfigBt.Name = "GetLaserConfigBt";
            this.GetLaserConfigBt.Size = new System.Drawing.Size(115, 22);
            this.GetLaserConfigBt.TabIndex = 34;
            this.GetLaserConfigBt.Text = "Get configuration";
            this.GetLaserConfigBt.UseVisualStyleBackColor = true;
            this.GetLaserConfigBt.Click += new System.EventHandler(this.GetLaserConfigBt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(9, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 33;
            this.label5.Text = "Serial Port";
            // 
            // SerialPortTxt
            // 
            this.SerialPortTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SerialPortTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SerialPortTxt.Location = new System.Drawing.Point(14, 254);
            this.SerialPortTxt.Name = "SerialPortTxt";
            this.SerialPortTxt.Size = new System.Drawing.Size(50, 21);
            this.SerialPortTxt.TabIndex = 32;
            this.SerialPortTxt.Text = "COM1";
            this.SerialPortTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SetLaserConfigBt
            // 
            this.SetLaserConfigBt.Location = new System.Drawing.Point(91, 240);
            this.SetLaserConfigBt.Name = "SetLaserConfigBt";
            this.SetLaserConfigBt.Size = new System.Drawing.Size(115, 22);
            this.SetLaserConfigBt.TabIndex = 31;
            this.SetLaserConfigBt.Text = "Set configuration";
            this.SetLaserConfigBt.UseVisualStyleBackColor = true;
            this.SetLaserConfigBt.Click += new System.EventHandler(this.SetLaserConfigBt_Click);
            // 
            // PRFTrackBar
            // 
            this.PRFTrackBar.Location = new System.Drawing.Point(162, 36);
            this.PRFTrackBar.Maximum = 8200;
            this.PRFTrackBar.Minimum = 50;
            this.PRFTrackBar.Name = "PRFTrackBar";
            this.PRFTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PRFTrackBar.Size = new System.Drawing.Size(29, 153);
            this.PRFTrackBar.TabIndex = 29;
            this.PRFTrackBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.PRFTrackBar.Value = 5000;
            this.PRFTrackBar.ValueChanged += new System.EventHandler(this.LaserPower_ValueChanged);
            // 
            // BurstTrackBar
            // 
            this.BurstTrackBar.Location = new System.Drawing.Point(88, 37);
            this.BurstTrackBar.Maximum = 8;
            this.BurstTrackBar.Minimum = 1;
            this.BurstTrackBar.Name = "BurstTrackBar";
            this.BurstTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BurstTrackBar.Size = new System.Drawing.Size(29, 153);
            this.BurstTrackBar.TabIndex = 28;
            this.BurstTrackBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.BurstTrackBar.Value = 8;
            this.BurstTrackBar.ValueChanged += new System.EventHandler(this.LaserPower_ValueChanged);
            // 
            // PowerTrackBar
            // 
            this.PowerTrackBar.Location = new System.Drawing.Point(14, 37);
            this.PowerTrackBar.Name = "PowerTrackBar";
            this.PowerTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PowerTrackBar.Size = new System.Drawing.Size(29, 153);
            this.PowerTrackBar.TabIndex = 27;
            this.PowerTrackBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.PowerTrackBar.Value = 10;
            this.PowerTrackBar.ValueChanged += new System.EventHandler(this.LaserPower_ValueChanged);
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox4.Location = new System.Drawing.Point(153, 196);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(47, 21);
            this.textBox4.TabIndex = 26;
            this.textBox4.Text = "1";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.TextChanged += new System.EventHandler(this.LaserPower_ValueChanged);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.Location = new System.Drawing.Point(84, 196);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(38, 21);
            this.textBox3.TabIndex = 24;
            this.textBox3.Text = "5";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.LaserPower_ValueChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(13, 196);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(38, 21);
            this.textBox2.TabIndex = 22;
            this.textBox2.Text = "100";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.LaserPower_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(77, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "BurstSize";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(145, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "PRF [kHz]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(1, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Power [%]";
            // 
            // splitView2
            // 
            this.splitView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitView2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitView2.IsSplitterFixed = true;
            this.splitView2.Location = new System.Drawing.Point(0, 0);
            this.splitView2.Name = "splitView2";
            // 
            // splitView2.Panel1
            // 
            this.splitView2.Panel1.Controls.Add(this.tabViews);
            // 
            // splitView2.Panel2
            // 
            this.splitView2.Panel2.Controls.Add(this.listBox1);
            this.splitView2.Panel2.Controls.Add(this.SimulationCbox);
            this.splitView2.Panel2.Controls.Add(this.ConfigBt);
            this.splitView2.Panel2.Controls.Add(this.ConnectTableBt);
            this.splitView2.Panel2.Controls.Add(this.TableControlBt);
            this.splitView2.Panel2MinSize = 50;
            this.splitView2.Size = new System.Drawing.Size(709, 491);
            this.splitView2.SplitterDistance = 477;
            this.splitView2.TabIndex = 29;
            // 
            // tabViews
            // 
            this.tabViews.Controls.Add(this.tabPage6);
            this.tabViews.Controls.Add(this.tabPage7);
            this.tabViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabViews.Location = new System.Drawing.Point(0, 0);
            this.tabViews.Name = "tabViews";
            this.tabViews.SelectedIndex = 0;
            this.tabViews.Size = new System.Drawing.Size(475, 489);
            this.tabViews.TabIndex = 3;
            this.tabViews.SelectedIndexChanged += new System.EventHandler(this.tabViews_SelectedIndexChanged);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.View);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(467, 463);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "2D VIEW";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // View
            // 
            this.View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.View.Enabled = true;
            this.View.Location = new System.Drawing.Point(3, 3);
            this.View.Name = "View";
            this.View.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("View.OcxState")));
            this.View.Size = new System.Drawing.Size(461, 457);
            this.View.TabIndex = 2;
            this.View.MouseMoveEvent += new AxFlightLib._DFlightViewEvents_MouseMoveEventHandler(this.View_MouseMoveEvent);
            this.View.ObjectClick += new AxFlightLib._DFlightViewEvents_ObjectClickEventHandler(this.View_ObjectClick);
            this.View.ObjectChanged += new AxFlightLib._DFlightViewEvents_ObjectChangedEventHandler(this.View_ObjectChanged);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.View3D);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(467, 463);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "3D VIEW";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // View3D
            // 
            this.View3D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.View3D.Enabled = true;
            this.View3D.Location = new System.Drawing.Point(3, 3);
            this.View3D.Name = "View3D";
            this.View3D.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("View3D.OcxState")));
            this.View3D.Size = new System.Drawing.Size(461, 457);
            this.View3D.TabIndex = 0;
            this.View3D.ObjectClick += new AxFlightLib._DFlightView3DEvents_ObjectClickEventHandler(this.View3D_ObjectClick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(21, 292);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(193, 95);
            this.listBox1.TabIndex = 24;
            // 
            // SimulationCbox
            // 
            this.SimulationCbox.AutoSize = true;
            this.SimulationCbox.Location = new System.Drawing.Point(21, 19);
            this.SimulationCbox.Name = "SimulationCbox";
            this.SimulationCbox.Size = new System.Drawing.Size(99, 17);
            this.SimulationCbox.TabIndex = 23;
            this.SimulationCbox.Text = "Simulator Mode";
            this.SimulationCbox.UseVisualStyleBackColor = true;
            // 
            // ConfigBt
            // 
            this.ConfigBt.Location = new System.Drawing.Point(21, 393);
            this.ConfigBt.Name = "ConfigBt";
            this.ConfigBt.Size = new System.Drawing.Size(193, 27);
            this.ConfigBt.TabIndex = 21;
            this.ConfigBt.Text = "Edit Table Configuration";
            this.ConfigBt.UseVisualStyleBackColor = true;
            this.ConfigBt.Click += new System.EventHandler(this.ConfigBt_Click);
            // 
            // ConnectTableBt
            // 
            this.ConnectTableBt.Image = ((System.Drawing.Image)(resources.GetObject("ConnectTableBt.Image")));
            this.ConnectTableBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConnectTableBt.Location = new System.Drawing.Point(21, 42);
            this.ConnectTableBt.Name = "ConnectTableBt";
            this.ConnectTableBt.Size = new System.Drawing.Size(193, 55);
            this.ConnectTableBt.TabIndex = 17;
            this.ConnectTableBt.Text = "Connect to table";
            this.ConnectTableBt.UseVisualStyleBackColor = true;
            this.ConnectTableBt.Click += new System.EventHandler(this.ConnectTableBt_Click);
            // 
            // TableControlBt
            // 
            this.TableControlBt.Location = new System.Drawing.Point(21, 122);
            this.TableControlBt.Name = "TableControlBt";
            this.TableControlBt.Size = new System.Drawing.Size(193, 38);
            this.TableControlBt.TabIndex = 5;
            this.TableControlBt.Text = "Table Control Panel";
            this.TableControlBt.UseVisualStyleBackColor = true;
            this.TableControlBt.Click += new System.EventHandler(this.OnBtnConnect_Click);
            // 
            // FlightMarker
            // 
            this.FlightMarker.Location = new System.Drawing.Point(20, 25);
            this.FlightMarker.Name = "FlightMarker";
            this.FlightMarker.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("FlightMarker.OcxState")));
            this.FlightMarker.Size = new System.Drawing.Size(183, 194);
            this.FlightMarker.TabIndex = 27;
            this.FlightMarker.Visible = false;
            this.FlightMarker.MarkingFinished += new AxFlightLib._DFlightMarkerEvents_MarkingFinishedEventHandler(this.FlightMarker_MarkingFinished);
            this.FlightMarker.SimulationFinished += new AxFlightLib._DFlightMarkerEvents_SimulationFinishedEventHandler(this.FlightMarker_SimulationFinished);
            // 
            // Editor
            // 
            this.Editor.Enabled = true;
            this.Editor.Location = new System.Drawing.Point(86, 25);
            this.Editor.Name = "Editor";
            this.Editor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Editor.OcxState")));
            this.Editor.Size = new System.Drawing.Size(183, 194);
            this.Editor.TabIndex = 28;
            this.Editor.Visible = false;
            // 
            // Flight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 568);
            this.Controls.Add(this.SplitView);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.tbDocument);
            this.Controls.Add(this.menuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Flight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flight Marker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Flight_FormClosing);
            this.Load += new System.EventHandler(this.Flight_Load);
            this.SizeChanged += new System.EventHandler(this.Flight_SizeChanged);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.tbDocument.ResumeLayout(false);
            this.tbDocument.PerformLayout();
            this.SplitView.Panel1.ResumeLayout(false);
            this.SplitView.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitView)).EndInit();
            this.SplitView.ResumeLayout(false);
            this.FlightTab2.ResumeLayout(false);
            this.TabObjects.ResumeLayout(false);
            this.TabObjects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PropTree)).EndInit();
            this.tbObjects.ResumeLayout(false);
            this.tbObjects.PerformLayout();
            this.FlightTab.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PropColors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Colors)).EndInit();
            this.tbColors.ResumeLayout(false);
            this.tbColors.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.tbPens.ResumeLayout(false);
            this.tbPens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PropPens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pens)).EndInit();
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PropFonts)).EndInit();
            this.tbFonts.ResumeLayout(false);
            this.tbFonts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Fonts)).EndInit();
            this.TabPage4.ResumeLayout(false);
            this.TabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PropLayouts)).EndInit();
            this.tbLayouts.ResumeLayout(false);
            this.tbLayouts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Layouts)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tbSurface.ResumeLayout(false);
            this.tbSurface.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PropSurfaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Surfaces)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.splitView2.Panel1.ResumeLayout(false);
            this.splitView2.Panel2.ResumeLayout(false);
            this.splitView2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitView2)).EndInit();
            this.splitView2.ResumeLayout(false);
            this.tabViews.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.View)).EndInit();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.View3D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlightMarker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Editor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.Timer Timer;
		private System.Windows.Forms.MenuStrip menuMain;
		private System.Windows.Forms.ToolStripMenuItem menuView;
		private System.Windows.Forms.ToolStripMenuItem menuToolbar;
		private System.Windows.Forms.ToolStripMenuItem menuStatusBar;
		private System.Windows.Forms.ToolStripMenuItem menuSettings;
		private System.Windows.Forms.ToolStripMenuItem menuSettingsEdit;
		private System.Windows.Forms.ToolStripMenuItem menuHelp;
		private System.Windows.Forms.ToolStripMenuItem menuAbout;
		internal System.Windows.Forms.StatusStrip StatusBar;
		internal System.Windows.Forms.ToolStripStatusLabel LabelCoX;
		internal System.Windows.Forms.ToolStripStatusLabel LabelCoY;
		internal System.Windows.Forms.ToolStripStatusLabel LabelTime;
		private System.Windows.Forms.SplitContainer SplitView;
		internal AxFlightLib.AxFlightMarker FlightMarker;
		internal AxFlightLib.AxFlightEditor Editor;
		private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
		private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
		private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
		private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
		private System.Windows.Forms.ToolStripContentPanel ContentPanel;
		internal System.Windows.Forms.ToolStrip tbDocument;
		internal System.Windows.Forms.ToolStripButton tbNew;
		internal System.Windows.Forms.ToolStripButton tbOpen;
		internal System.Windows.Forms.ToolStripButton tbSave;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
		internal System.Windows.Forms.ToolStripButton tbRefresh;
		internal System.Windows.Forms.ToolStripButton tbAbort;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator5;
		internal System.Windows.Forms.ToolStripButton tbSelect;
		internal System.Windows.Forms.ToolStripButton tbPan;
		internal System.Windows.Forms.ToolStripButton tbZoomIn;
		internal System.Windows.Forms.ToolStripButton tbZoomOut;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator4;
		internal System.Windows.Forms.ToolStripButton tbEditor;
		internal System.Windows.Forms.TabControl FlightTab2;
		internal System.Windows.Forms.TabPage TabObjects;
		internal AxFlightLib.AxFlightTree Tree;
		internal AxFlightLib.AxFlightPropList PropTree;
		internal System.Windows.Forms.ToolStrip tbObjects;
		internal System.Windows.Forms.ToolStripButton CmdAddBitmap;
		internal System.Windows.Forms.ToolStripButton CmdAddStruct;
		internal System.Windows.Forms.ToolStripButton CmdAddDrawing;
		internal System.Windows.Forms.ToolStripButton CmdAddText;
		internal System.Windows.Forms.ToolStripButton CmdAddCircularText;
		internal System.Windows.Forms.ToolStripButton CmdAddEvent;
		internal System.Windows.Forms.ToolStripButton CmdAddGroup;
		internal System.Windows.Forms.ToolStripButton CmdRemoveObject;
		internal System.Windows.Forms.TabControl FlightTab;
		internal System.Windows.Forms.TabPage TabPage1;
		internal AxFlightLib.AxFlightPropList PropColors;
		internal AxFlightLib.AxFlightColors Colors;
		internal System.Windows.Forms.ToolStrip tbColors;
		internal System.Windows.Forms.ToolStripButton CmdAddColor;
		internal System.Windows.Forms.ToolStripButton CmdRemoveColor;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
		internal System.Windows.Forms.ToolStripButton CmdChangeColor;
		internal System.Windows.Forms.TabPage TabPage2;
		internal System.Windows.Forms.ToolStrip tbPens;
		internal System.Windows.Forms.ToolStripButton CmdAddPen;
		internal System.Windows.Forms.ToolStripButton CmdRemovePen;
		internal AxFlightLib.AxFlightPropList PropPens;
		internal AxFlightLib.AxFlightPens Pens;
		internal System.Windows.Forms.TabPage TabPage3;
		internal AxFlightLib.AxFlightPropList PropFonts;
		internal System.Windows.Forms.ToolStrip tbFonts;
		internal System.Windows.Forms.ToolStripButton CmdAddTrueTypeFont;
		internal System.Windows.Forms.ToolStripButton CmdAddSinglestrokeFont;
		internal System.Windows.Forms.ToolStripButton CmdAddBarcodeFont;
		internal System.Windows.Forms.ToolStripButton CmdRemoveFont;
		internal AxFlightLib.AxFlightFonts Fonts;
		internal System.Windows.Forms.TabPage TabPage4;
		internal AxFlightLib.AxFlightPropList PropLayouts;
		internal System.Windows.Forms.ToolStrip tbLayouts;
		internal System.Windows.Forms.ToolStripButton CmdAddLayout;
		internal System.Windows.Forms.ToolStripButton CmdRemoveLayout;
		internal AxFlightLib.AxFlightLayouts Layouts;
		private System.Windows.Forms.ToolStripMenuItem menuFile;
		private System.Windows.Forms.ToolStripMenuItem menuNew;
		private System.Windows.Forms.ToolStripMenuItem menuOpen;
		private System.Windows.Forms.ToolStripSeparator menuSeparator1;
		private System.Windows.Forms.ToolStripMenuItem menuSave;
		private System.Windows.Forms.ToolStripMenuItem menuSaveAs;
		private System.Windows.Forms.ToolStripSeparator menuSeperator2;
		private System.Windows.Forms.ToolStripMenuItem menuExit;
		private System.Windows.Forms.ToolStripSeparator menuSeparator3;
		private System.Windows.Forms.ToolStripMenuItem menuSelect;
		private System.Windows.Forms.ToolStripMenuItem menuPan;
		private System.Windows.Forms.ToolStripMenuItem menuZoomIn;
		private System.Windows.Forms.ToolStripMenuItem menuZoomOut;
		private System.Windows.Forms.ToolStripSeparator menuSeparator4;
		private System.Windows.Forms.ToolStripMenuItem menuRefresh;
        private System.Windows.Forms.ToolStripButton CmdCopy;
		private System.Windows.Forms.SplitContainer splitView2;
        private AxFlightLib.AxFlightView View;
		internal System.Windows.Forms.ToolStripButton tbInfinite;
		internal System.Windows.Forms.ToolStripButton tbUpload;
		internal System.Windows.Forms.ToolStripButton tbFlashExplorer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		internal System.Windows.Forms.ImageList Leds;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tbSettings;
        internal System.Windows.Forms.ImageList TabulaImg;
        private System.Windows.Forms.TabPage tabPage5;
        private AxFlightLib.AxFlightPropList PropSurfaces;
        private AxFlightLib.AxFlightSurfaces Surfaces;
        internal System.Windows.Forms.ToolStrip tbSurface;
        internal System.Windows.Forms.ToolStripButton CmdAddSurface;
        internal System.Windows.Forms.ToolStripButton CmdRemoveSurface;
        private System.Windows.Forms.TabControl tabViews;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private AxFlightLib.AxFlightView3D View3D;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripButton tbEdit;
        internal System.Windows.Forms.ToolStripButton tbRotate;
        internal System.Windows.Forms.ToolStripButton tbZoom;
        internal System.Windows.Forms.ToolStripButton tbViewSelection;
        internal System.Windows.Forms.ToolStripButton tbSideView;
        internal System.Windows.Forms.ToolStripButton tbFrontView;
        internal System.Windows.Forms.ToolStripButton tbTopView;
        private System.Windows.Forms.ToolStripMenuItem menuRotate;
        private System.Windows.Forms.ToolStripMenuItem menuZoom;
        internal System.Windows.Forms.ToolStripButton tbGrid;
        internal System.Windows.Forms.ToolStripButton CmdAdd3DScript;
        internal System.Windows.Forms.ToolStripButton CmdAdd3DStruct;
        private System.Windows.Forms.ToolStripButton CmdAddSection;
        private System.Windows.Forms.ToolStripButton tbCalibrate;
        private System.Windows.Forms.ToolStripButton onTheFlyBt;
        private System.Windows.Forms.Button ConnectTableBt;
        private System.Windows.Forms.Button TableControlBt;
        private System.Windows.Forms.ToolStripButton StepRepeatGenerator;
        private System.Windows.Forms.CheckBox MultiHatchingChBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ConfigBt;
        private System.Windows.Forms.CheckBox SimulationCbox;
        private System.Windows.Forms.ToolStripButton tbStepAndRepeatBt;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage tabPage8;
        private Guna.UI2.WinForms.Guna2VTrackBar PRFTrackBar;
        private Guna.UI2.WinForms.Guna2VTrackBar BurstTrackBar;
        private Guna.UI2.WinForms.Guna2VTrackBar PowerTrackBar;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SetLaserConfigBt;
        private System.Windows.Forms.TextBox SerialPortTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button GetLaserConfigBt;
        private Guna.UI2.WinForms.Guna2VTrackBar PodTrackBar;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox PoDBox;
        private System.Windows.Forms.ToolStripSplitButton tbMark;
        private System.Windows.Forms.ToolStripMenuItem MarkingParamsChBox;
        private System.Windows.Forms.ToolStripSplitButton tbSimulate;
        private System.Windows.Forms.ToolStripMenuItem AreaSimChBox;
        private System.Windows.Forms.ToolStripButton PrintParametersBt;
    }
}


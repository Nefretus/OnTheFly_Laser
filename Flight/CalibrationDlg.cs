using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Flight {
    public partial class CalibrationDlg : Form {
        FlightLib.rhothorLink _Link = null;
        double _FieldSize;
        double _CalSize = 200;
        int _CalRows = 3;
        int _CalCols = 3;

        class MsrPoint {
            public int Index;
            public double CalX;
            public double CalY;
            public double MsrX;
            public double MsrY;

            public MsrPoint(int i, double X, double Y) {
                Index = i;
                CalX = MsrX = X;
                CalY = MsrY = Y;                
            }

            public PointF GetError() {
                return new PointF((float)(MsrX-CalX), (float)(MsrY-CalY));  
            }

            public ListViewItem AsNewListItem() {
                ListViewItem it = new ListViewItem(Index.ToString());
                it.SubItems.Add(CalX.ToString("0.0"));
                it.SubItems.Add(CalY.ToString("0.0"));
                it.SubItems.Add(MsrX.ToString("0.0"));
                it.SubItems.Add(MsrY.ToString("0.0"));
                it.Tag = this;
                return it;
            }

            public void UpdateListView(ListViewItem item) {
                item.SubItems[3].Text = MsrX.ToString("0.0");
                item.SubItems[4].Text = MsrY.ToString("0.0"); 
            }

            public void Reset(ListViewItem item) {
                MsrX = CalX;
                MsrY = CalY;
                UpdateListView(item);
            }
        }

        public CalibrationDlg(ref FlightLib.rhothorLink link) {
            _Link = link;
            _Link.rtGetFieldSize(ref _FieldSize);
            InitializeComponent();
            ResetCalPointsUI();
        }

        public void ResetCalPointsUI() {
            PointList.Items.Clear();
            int r, c, i;
            double x, y;
            i = 0;
            for (r = 0; r < _CalRows; r++)
            {
                y= -_CalSize/2 + r* _CalSize/(_CalRows-1);
                for (c = 0; c < _CalCols; c++)
                {
                    x = -_CalSize/2 + c* _CalSize/(_CalCols-1);
                    MsrPoint pt = new MsrPoint(i++, x, y);
                    PointList.Items.Add(pt.AsNewListItem());
                }
            }
        }

        public bool ProcessCalibrationData(int Columns, int Rows, double Width, double Height, PointF[] Data) {
            string _path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
            string filename = _path + "\\" + "measure.txt";

            using (TextWriter tw = new StreamWriter(filename))
            {
                if (tw != null)
                {
                    tw.WriteLine("X:{0:0.000};{1}", Width, Columns);
                    tw.WriteLine("Y:{0:0.000};{1}", Height, Rows);
                    for (int i = 0; i < Data.Length; i++)
                    {
                        tw.Write("({0:0.000};{1:0.000})", Data[i].X, Data[i].Y);
                        if (i % Columns == Columns - 1) tw.Write((i == Data.Length - 1) ? ";" : "\r\n");
                    }
                }
            }
            int err = _Link.rtAddCalibrationData(filename);
            _Link.rtStoreCalibration();
            if (err == -1) MessageBox.Show("Added Succesfully");
            else MessageBox.Show("Could not add " + filename);
            return (err == -1);
        }

        private void CalibrationDlg_Load(object sender, EventArgs e)
        {}

        private void btnLoad_Click(object sender, EventArgs e) {
            using (OpenFileDialog dlg = new OpenFileDialog()) {
                dlg.Filter = "Calibration txt files|*.txt|All files|*.*";
                dlg.Title = "Load calibration file";
                dlg.RestoreDirectory = true;
                if (dlg.ShowDialog() == DialogResult.OK && File.Exists(dlg.FileName)) {
                    if (_Link.rtLoadCalibrationFile(dlg.FileName) == -1)
                        MessageBox.Show("Loading calibration file succeeded.", "Calibration", MessageBoxButtons.OK);
                    else
                        MessageBox.Show("Loading calibration file failed!", "Calibration", MessageBoxButtons.OK);
                }
            }
        }

        private void BtnStore_Click(object sender, EventArgs e) {
            using (SaveFileDialog dlg = new SaveFileDialog()) {
                dlg.Filter = "Calibration txt files|*.txt|All files|*.*";
                dlg.Title = "Store calibration file";
                dlg.RestoreDirectory = true;
                if (dlg.ShowDialog() == DialogResult.OK) {
                    if (_Link.rtStoreCalibrationFile(dlg.FileName) == -1)
                        MessageBox.Show("Storing calibration file succeeded.", "Calibration", MessageBoxButtons.OK);
                    else
                        MessageBox.Show("Storing calibration file failed!", "Calibration", MessageBoxButtons.OK);
                }
            }
        }

        private void btnAddCalib_Click(object sender, EventArgs e) {
            List<PointF> err= new List<PointF>();
            foreach (ListViewItem lvi in PointList.Items)
                err.Add(((MsrPoint)lvi.Tag).GetError());
            if (ProcessCalibrationData(_CalCols, _CalRows, _CalSize, _CalSize, err.ToArray())) {
            // reset list view
            foreach (ListViewItem lvi in PointList.Items)
                ((MsrPoint)lvi.Tag).Reset(lvi);
            }
        }

        private void btnAbort_Click(object sender, EventArgs e) {
            _Link.rtAbort();
        }

        private void PointList_SelectedIndexChanged(object sender, EventArgs e) {
            if (PointList.SelectedIndices.Count > 0) {
                txtX.Text = ((MsrPoint)PointList.SelectedItems[0].Tag).MsrX.ToString("0.0");
                txtY.Text = ((MsrPoint)PointList.SelectedItems[0].Tag).MsrY.ToString("0.0");
            }
            else {
                txtX.Text = "";
                txtY.Text = "";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            if (PointList.SelectedIndices.Count > 0) {
                MsrPoint pt = (MsrPoint)PointList.SelectedItems[0].Tag;
                Double.TryParse(txtX.Text, out pt.MsrX);
                Double.TryParse(txtY.Text, out pt.MsrY);
                pt.UpdateListView(PointList.SelectedItems[0]);
            }
        }

        private void btnMark_Click(object sender, EventArgs e) {
            int r, c;
            _Link.rtListOpen(1);
            _Link.rtSetSpeed(500);
            _Link.rtSetJumpSpeed(500);
            _Link.rtSetLaserTimes(100, 100);

            for (r = 0; r < _CalRows; r++)
                for (c = 0; c < _CalCols; c++)
                    HwCross(-_CalSize / 2 + c * _CalSize / (_CalCols - 1),
                            -_CalSize / 2 + r * _CalSize / (_CalRows - 1), 
                            8);
            // make diagonal to verify axis system
            _Link.rtJumpTo(0, _FieldSize / 40);
            _Link.rtLineTo(_FieldSize / 20, 0);
            _Link.rtListClose();
        }

        void HwCross(double Cx, double Cy, double Size) { 
            double xMin, xMax, yMin, yMax, border;

            border = 1.0;
            yMin = xMin = -_CalSize/2 - border;
            yMax = xMax = _CalSize/2 + border;
            HwJumpTo(Math.Max(xMin, Cx - Size / 2), Cy);
            HwLineTo(Math.Min(xMax, Cx + Size / 2), Cy);
            HwJumpTo(Cx, Math.Max(yMin, Cy - Size / 2));
            HwLineTo(Cx, Math.Min(yMax, Cy + Size / 2));
        }

        void HwJumpTo(double X, double Y) {
            _Link.rtJumpTo(X, Y);
            _Link.rtSleep(100);
        }

        void HwLineTo(double X, double Y) {
            _Link.rtLineTo(X, Y);
            _Link.rtSleep(100);        
        }

        private void BtnReset_Click(object sender, EventArgs e) {
            if (_Link.rtResetCalibration() == -1)
                MessageBox.Show("Calibration data cleared.", "Calibration", MessageBoxButtons.OK);
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            if (btnEdit.Text == "Edit") {
                btnEdit.Text = "Apply";
                gpCalibration.Enabled = false;
            }
            else {
                btnEdit.Text = "Edit";
                gpCalibration.Enabled = true;
                double.TryParse(tbCalSize.Text, out _CalSize);
                int.TryParse(tbRows.Text, out _CalRows);
                int.TryParse(tbCols.Text, out _CalCols);
                if (_CalRows < 2) _CalRows = 3;
                if (_CalCols < 2) _CalCols = 3;
                tbRows.Text = _CalRows.ToString();
                tbCols.Text = _CalCols.ToString();
                tbCalSize.Text = _CalSize.ToString();
                ResetCalPointsUI();
            }
            tbRows.Enabled = !gpCalibration.Enabled;
            tbCols.Enabled = !gpCalibration.Enabled;
            tbCalSize.Enabled = !gpCalibration.Enabled;
            PointList.SelectedIndices.Clear();
        }
    }
}

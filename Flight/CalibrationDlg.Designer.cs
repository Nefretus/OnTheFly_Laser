namespace Flight
{
    partial class CalibrationDlg
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
            this.BtnStore = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.btnAddCalib = new System.Windows.Forms.Button();
            this.btnMark = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.PointList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.tbRows = new System.Windows.Forms.TextBox();
            this.tbCols = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gpProperties = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCalSize = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.gpCalibration = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.gpProperties.SuspendLayout();
            this.gpCalibration.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnStore
            // 
            this.BtnStore.Location = new System.Drawing.Point(495, 256);
            this.BtnStore.Name = "BtnStore";
            this.BtnStore.Size = new System.Drawing.Size(102, 35);
            this.BtnStore.TabIndex = 0;
            this.BtnStore.Text = "Store To File";
            this.BtnStore.UseVisualStyleBackColor = true;
            this.BtnStore.Click += new System.EventHandler(this.BtnStore_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(495, 297);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(102, 35);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load From File";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(495, 215);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(102, 35);
            this.BtnReset.TabIndex = 2;
            this.BtnReset.Text = "Clear Calibration";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnAddCalib
            // 
            this.btnAddCalib.Location = new System.Drawing.Point(495, 131);
            this.btnAddCalib.Name = "btnAddCalib";
            this.btnAddCalib.Size = new System.Drawing.Size(102, 35);
            this.btnAddCalib.TabIndex = 3;
            this.btnAddCalib.Text = "Add Data";
            this.btnAddCalib.UseVisualStyleBackColor = true;
            this.btnAddCalib.Click += new System.EventHandler(this.btnAddCalib_Click);
            // 
            // btnMark
            // 
            this.btnMark.Location = new System.Drawing.Point(495, 27);
            this.btnMark.Name = "btnMark";
            this.btnMark.Size = new System.Drawing.Size(102, 35);
            this.btnMark.TabIndex = 4;
            this.btnMark.Text = "Mark Figure";
            this.btnMark.UseVisualStyleBackColor = true;
            this.btnMark.Click += new System.EventHandler(this.btnMark_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Location = new System.Drawing.Point(495, 68);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(102, 35);
            this.btnAbort.TabIndex = 5;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // PointList
            // 
            this.PointList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.PointList.FullRowSelect = true;
            this.PointList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.PointList.HideSelection = false;
            this.PointList.Location = new System.Drawing.Point(17, 27);
            this.PointList.MultiSelect = false;
            this.PointList.Name = "PointList";
            this.PointList.Size = new System.Drawing.Size(472, 223);
            this.PointList.TabIndex = 6;
            this.PointList.UseCompatibleStateImageBehavior = false;
            this.PointList.View = System.Windows.Forms.View.Details;
            this.PointList.SelectedIndexChanged += new System.EventHandler(this.PointList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Point";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Calibration PosX";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Calibration PosY";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Measured PosX";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Measured PosY";
            this.columnHeader5.Width = 100;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(349, 288);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 29);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(225, 267);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(75, 20);
            this.txtX.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Measured X [mm]: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Measured Y [mm]: ";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(225, 293);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(75, 20);
            this.txtY.TabIndex = 11;
            // 
            // tbRows
            // 
            this.tbRows.Enabled = false;
            this.tbRows.Location = new System.Drawing.Point(83, 53);
            this.tbRows.Name = "tbRows";
            this.tbRows.Size = new System.Drawing.Size(75, 20);
            this.tbRows.TabIndex = 12;
            this.tbRows.Text = "3";
            // 
            // tbCols
            // 
            this.tbCols.Enabled = false;
            this.tbCols.Location = new System.Drawing.Point(83, 79);
            this.tbCols.Name = "tbCols";
            this.tbCols.Size = new System.Drawing.Size(75, 20);
            this.tbCols.TabIndex = 13;
            this.tbCols.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Rows: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Columns: ";
            // 
            // gpProperties
            // 
            this.gpProperties.Controls.Add(this.btnEdit);
            this.gpProperties.Controls.Add(this.tbCalSize);
            this.gpProperties.Controls.Add(this.label5);
            this.gpProperties.Controls.Add(this.label4);
            this.gpProperties.Controls.Add(this.label3);
            this.gpProperties.Controls.Add(this.tbCols);
            this.gpProperties.Controls.Add(this.tbRows);
            this.gpProperties.Location = new System.Drawing.Point(12, 12);
            this.gpProperties.Name = "gpProperties";
            this.gpProperties.Size = new System.Drawing.Size(192, 153);
            this.gpProperties.TabIndex = 16;
            this.gpProperties.TabStop = false;
            this.gpProperties.Text = "Properties";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Size: ";
            // 
            // tbCalSize
            // 
            this.tbCalSize.Enabled = false;
            this.tbCalSize.Location = new System.Drawing.Point(83, 27);
            this.tbCalSize.Name = "tbCalSize";
            this.tbCalSize.Size = new System.Drawing.Size(75, 20);
            this.tbCalSize.TabIndex = 17;
            this.tbCalSize.Text = "100";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(83, 105);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 29);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // gpCalibration
            // 
            this.gpCalibration.Controls.Add(this.txtY);
            this.gpCalibration.Controls.Add(this.label2);
            this.gpCalibration.Controls.Add(this.label1);
            this.gpCalibration.Controls.Add(this.txtX);
            this.gpCalibration.Controls.Add(this.btnUpdate);
            this.gpCalibration.Controls.Add(this.PointList);
            this.gpCalibration.Controls.Add(this.btnAbort);
            this.gpCalibration.Controls.Add(this.btnMark);
            this.gpCalibration.Controls.Add(this.btnAddCalib);
            this.gpCalibration.Controls.Add(this.BtnReset);
            this.gpCalibration.Controls.Add(this.btnLoad);
            this.gpCalibration.Controls.Add(this.BtnStore);
            this.gpCalibration.Location = new System.Drawing.Point(217, 12);
            this.gpCalibration.Name = "gpCalibration";
            this.gpCalibration.Size = new System.Drawing.Size(619, 348);
            this.gpCalibration.TabIndex = 17;
            this.gpCalibration.TabStop = false;
            this.gpCalibration.Text = "Calibration";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(712, 371);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 35);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // CalibrationDlg
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 414);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gpCalibration);
            this.Controls.Add(this.gpProperties);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalibrationDlg";
            this.Text = "Field Calibration";
            this.Load += new System.EventHandler(this.CalibrationDlg_Load);
            this.gpProperties.ResumeLayout(false);
            this.gpProperties.PerformLayout();
            this.gpCalibration.ResumeLayout(false);
            this.gpCalibration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnStore;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button btnAddCalib;
        private System.Windows.Forms.Button btnMark;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.ListView PointList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox tbRows;
        private System.Windows.Forms.TextBox tbCols;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gpProperties;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox tbCalSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gpCalibration;
        private System.Windows.Forms.Button btnClose;
    }
}
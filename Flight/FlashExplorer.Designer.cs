namespace Flight
{
	partial class FlashExplorer
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.TabPage1 = new System.Windows.Forms.TabPage();
			this.btnFetchAbort = new System.Windows.Forms.Button();
			this.btnFetch = new System.Windows.Forms.Button();
			this.ListView1 = new System.Windows.Forms.ListView();
			this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.btnDeleteAll = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.TabPage2 = new System.Windows.Forms.TabPage();
			this.DGView1 = new System.Windows.Forms.DataGridView();
			this.lblAllocMem = new System.Windows.Forms.Label();
			this.lblAvailMem = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.OK_Button = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.TabControl1.SuspendLayout();
			this.TabPage1.SuspendLayout();
			this.TabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DGView1)).BeginInit();
			this.SuspendLayout();
			// 
			// TabControl1
			// 
			this.TabControl1.Controls.Add(this.TabPage1);
			this.TabControl1.Controls.Add(this.TabPage2);
			this.TabControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.TabControl1.Location = new System.Drawing.Point(3, 3);
			this.TabControl1.Margin = new System.Windows.Forms.Padding(6);
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			this.TabControl1.Size = new System.Drawing.Size(565, 353);
			this.TabControl1.TabIndex = 10;
			// 
			// TabPage1
			// 
			this.TabPage1.Controls.Add(this.btnFetchAbort);
			this.TabPage1.Controls.Add(this.btnFetch);
			this.TabPage1.Controls.Add(this.ListView1);
			this.TabPage1.Controls.Add(this.btnDeleteAll);
			this.TabPage1.Controls.Add(this.btnDelete);
			this.TabPage1.Location = new System.Drawing.Point(4, 22);
			this.TabPage1.Name = "TabPage1";
			this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage1.Size = new System.Drawing.Size(557, 327);
			this.TabPage1.TabIndex = 0;
			this.TabPage1.Text = "Explorer";
			this.TabPage1.UseVisualStyleBackColor = true;
			// 
			// btnFetchAbort
			// 
			this.btnFetchAbort.Location = new System.Drawing.Point(348, 35);
			this.btnFetchAbort.Name = "btnFetchAbort";
			this.btnFetchAbort.Size = new System.Drawing.Size(99, 23);
			this.btnFetchAbort.TabIndex = 9;
			this.btnFetchAbort.Text = "Abort";
			this.btnFetchAbort.UseVisualStyleBackColor = true;
			this.btnFetchAbort.Click += new System.EventHandler(this.btnFetchAbort_Click);
			// 
			// btnFetch
			// 
			this.btnFetch.Location = new System.Drawing.Point(348, 6);
			this.btnFetch.Name = "btnFetch";
			this.btnFetch.Size = new System.Drawing.Size(99, 23);
			this.btnFetch.TabIndex = 8;
			this.btnFetch.Text = "Fetch Selected";
			this.btnFetch.UseVisualStyleBackColor = true;
			this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
			// 
			// ListView1
			// 
			this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3});
			this.ListView1.Dock = System.Windows.Forms.DockStyle.Left;
			this.ListView1.FullRowSelect = true;
			this.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.ListView1.HideSelection = false;
			this.ListView1.Location = new System.Drawing.Point(3, 3);
			this.ListView1.MultiSelect = false;
			this.ListView1.Name = "ListView1";
			this.ListView1.Size = new System.Drawing.Size(327, 321);
			this.ListView1.TabIndex = 3;
			this.ListView1.UseCompatibleStateImageBehavior = false;
			this.ListView1.View = System.Windows.Forms.View.Details;
			this.ListView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
			// 
			// ColumnHeader1
			// 
			this.ColumnHeader1.Text = "Job Name";
			this.ColumnHeader1.Width = 180;
			// 
			// ColumnHeader2
			// 
			this.ColumnHeader2.Text = "Sector";
			this.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ColumnHeader2.Width = 44;
			// 
			// ColumnHeader3
			// 
			this.ColumnHeader3.Text = "Size";
			this.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.ColumnHeader3.Width = 80;
			// 
			// btnDeleteAll
			// 
			this.btnDeleteAll.Location = new System.Drawing.Point(348, 299);
			this.btnDeleteAll.Name = "btnDeleteAll";
			this.btnDeleteAll.Size = new System.Drawing.Size(99, 23);
			this.btnDeleteAll.TabIndex = 7;
			this.btnDeleteAll.Text = "Delete All";
			this.btnDeleteAll.UseVisualStyleBackColor = true;
			this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(348, 270);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(99, 23);
			this.btnDelete.TabIndex = 2;
			this.btnDelete.Text = "Delete Selected";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// TabPage2
			// 
			this.TabPage2.Controls.Add(this.DGView1);
			this.TabPage2.Controls.Add(this.lblAllocMem);
			this.TabPage2.Controls.Add(this.lblAvailMem);
			this.TabPage2.Controls.Add(this.Label1);
			this.TabPage2.Controls.Add(this.Label2);
			this.TabPage2.Location = new System.Drawing.Point(4, 22);
			this.TabPage2.Name = "TabPage2";
			this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage2.Size = new System.Drawing.Size(557, 327);
			this.TabPage2.TabIndex = 1;
			this.TabPage2.Text = "Fragmentation";
			this.TabPage2.UseVisualStyleBackColor = true;
			// 
			// DGView1
			// 
			this.DGView1.AllowUserToAddRows = false;
			this.DGView1.AllowUserToDeleteRows = false;
			this.DGView1.AllowUserToResizeColumns = false;
			this.DGView1.AllowUserToResizeRows = false;
			this.DGView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.DGView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.DGView1.CausesValidation = false;
			this.DGView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.DGView1.ColumnHeadersHeight = 5;
			this.DGView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.DGView1.ColumnHeadersVisible = false;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DGView1.DefaultCellStyle = dataGridViewCellStyle9;
			this.DGView1.Dock = System.Windows.Forms.DockStyle.Top;
			this.DGView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.DGView1.Location = new System.Drawing.Point(3, 3);
			this.DGView1.MultiSelect = false;
			this.DGView1.Name = "DGView1";
			this.DGView1.ReadOnly = true;
			this.DGView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.DGView1.RowHeadersVisible = false;
			this.DGView1.RowHeadersWidth = 5;
			this.DGView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.DGView1.RowTemplate.ReadOnly = true;
			this.DGView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.DGView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.DGView1.Size = new System.Drawing.Size(551, 256);
			this.DGView1.StandardTab = true;
			this.DGView1.TabIndex = 9;
			// 
			// lblAllocMem
			// 
			this.lblAllocMem.AutoSize = true;
			this.lblAllocMem.Location = new System.Drawing.Point(135, 274);
			this.lblAllocMem.Name = "lblAllocMem";
			this.lblAllocMem.Size = new System.Drawing.Size(41, 13);
			this.lblAllocMem.TabIndex = 6;
			this.lblAllocMem.Text = "0 bytes";
			// 
			// lblAvailMem
			// 
			this.lblAvailMem.AutoSize = true;
			this.lblAvailMem.Location = new System.Drawing.Point(135, 296);
			this.lblAvailMem.Name = "lblAvailMem";
			this.lblAvailMem.Size = new System.Drawing.Size(41, 13);
			this.lblAvailMem.TabIndex = 5;
			this.lblAvailMem.Text = "0 bytes";
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(10, 296);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(118, 13);
			this.Label1.TabIndex = 3;
			this.Label1.Text = "Total available memory:";
			// 
			// Label2
			// 
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(10, 274);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(119, 13);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "Total allocated memory:";
			// 
			// OK_Button
			// 
			this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.OK_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.OK_Button.Location = new System.Drawing.Point(472, 374);
			this.OK_Button.Name = "OK_Button";
			this.OK_Button.Size = new System.Drawing.Size(93, 23);
			this.OK_Button.TabIndex = 11;
			this.OK_Button.Text = "Close";
			// 
			// timer1
			// 
			this.timer1.Interval = 300;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// FlashExplorer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(571, 403);
			this.Controls.Add(this.OK_Button);
			this.Controls.Add(this.TabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FlashExplorer";
			this.Padding = new System.Windows.Forms.Padding(3);
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FlashExplorer";
			this.Load += new System.EventHandler(this.FlashExplorer_Load);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FlashExplorer_FormClosing);
			this.TabControl1.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			this.TabPage2.ResumeLayout(false);
			this.TabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DGView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		internal System.Windows.Forms.TabControl TabControl1;
		internal System.Windows.Forms.TabPage TabPage1;
		internal System.Windows.Forms.Button btnFetchAbort;
		internal System.Windows.Forms.Button btnFetch;
		internal System.Windows.Forms.ListView ListView1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader2;
		internal System.Windows.Forms.ColumnHeader ColumnHeader3;
		internal System.Windows.Forms.Button btnDeleteAll;
		internal System.Windows.Forms.Button btnDelete;
		internal System.Windows.Forms.TabPage TabPage2;
		internal System.Windows.Forms.DataGridView DGView1;
		internal System.Windows.Forms.Label lblAllocMem;
		internal System.Windows.Forms.Label lblAvailMem;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Button OK_Button;
		private System.Windows.Forms.Timer timer1;
	}
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Flight {
	public partial class FlashExplorer : Form {
		bool _Fetching = false;
		FlightLib.rhothorLink _Link = null;


		public FlashExplorer(ref FlightLib.rhothorLink link) {
			_Link = link;
			InitializeComponent();
		}

		private void FlashExplorer_Load(object sender, EventArgs e) {
			DGView1.ColumnCount = 25; // controller has 250 sectors
			DGView1.RowCount = 10;
			LoadFlashExplorer();
			UpdateBtnUI();
		}

		private void LoadFlashExplorer() {
            int sectorsize = 0x40000; // 0x10000 for CUA-xxx
			int i, j, k, r, c, mem = 0, idx;
			string name = "";

			ListView1.Items.Clear();
			foreach (DataGridViewRow row in DGView1.Rows) {
				foreach (DataGridViewCell cell in row.Cells) {
					cell.Value = " ";
					cell.ToolTipText = "";
					cell.Style.BackColor = Color.White;
				}
			}

			for (i = _Link.rtGetFlashFirstFileEntry(ref name, ref mem);
				 i == -1 && mem > 0;
				 i = _Link.rtGetFlashNextFileEntry(ref name, ref mem)) {
				idx = 0;
				_Link.rtGetFileIndex(name, ref idx);
				if (idx == 0) {
					DGView1.Rows[0].Cells[0].Value = "B";
					DGView1.Rows[0].Cells[0].ToolTipText = "BOOTSCRIPT";
					DGView1.Rows[0].Cells[0].Style.BackColor = Color.LightGreen;
				}
				else {
					ListViewItem lvi = ListView1.Items.Add(name);
					lvi.ImageIndex = 0;
					lvi.SubItems.Add(idx.ToString());
					lvi.SubItems.Add(mem.ToString());
                    for (k = 0; k * sectorsize <= mem; k++)
					{
						r = (idx + k) / DGView1.ColumnCount;
						c = (idx + k) % DGView1.ColumnCount;
						DataGridViewCell cell = DGView1.Rows[r].Cells[c];
						if (k == 0)
						{
							cell.Value = "H";
							cell.ToolTipText = name;
						}
						cell.Style.BackColor = Color.LightGray;
					}
				}
			}
			i = 0; j = 0;
			_Link.rtGetFlashMemorySizes(ref i, ref j);
            lblAvailMem.Text = (i / sectorsize).ToString() + " Sectors";
            lblAllocMem.Text = (j / sectorsize).ToString() + " Sectors";
		}
	
		private void UpdateBtnUI() {
			btnFetch.Enabled = !_Fetching && ListView1.SelectedIndices.Count==1;
			btnDelete.Enabled = !_Fetching && ListView1.SelectedIndices.Count>0;
			btnDeleteAll.Enabled = !_Fetching && ListView1.Items.Count>0;
			OK_Button.Enabled = !_Fetching;
		}

		private void btnFetch_Click(object sender, EventArgs e) {
			int i=0;
			if (ListView1.SelectedIndices.Count==1) {
				_Fetching = true;
				UpdateBtnUI();
				_Link.rtGetFileIndex(ListView1.SelectedItems[0].Text, ref i);
				_Link.rtListOpen(1);
				_Link.rtSetIO(112, 112);
				_Link.rtIndexFetch(i);
				_Link.rtListClose();
				timer1.Enabled = true;
			}
		}

		private void btnFetchAbort_Click(object sender, EventArgs e) {
			_Link.rtAbort();
		}

		private void btnDelete_Click(object sender, EventArgs e) {
			if (ListView1.SelectedIndices.Count > 0) {
				foreach (ListViewItem lvi in ListView1.SelectedItems)
					_Link.rtEraseFromFlash(lvi.Text);
				LoadFlashExplorer();
				UpdateBtnUI();
			}
		}

		private void btnDeleteAll_Click(object sender, EventArgs e) {
			if (ListView1.Items.Count > 0 &&
				MessageBox.Show("Are you sure to clear flash?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK) {
				foreach (ListViewItem lvi in ListView1.Items)
					_Link.rtEraseFromFlash(lvi.Text);
				LoadFlashExplorer();
				UpdateBtnUI();
			}
		}

		private void ListView1_SelectedIndexChanged(object sender, EventArgs e) {
			UpdateBtnUI();
		}

		private void timer1_Tick(object sender, EventArgs e) {
			timer1.Enabled = false;
			int mem=0;
			if (_Link.rtGetStatus(ref mem) != 2) {
				_Fetching = false;
				UpdateBtnUI();
			}
			else timer1.Enabled = true;

		}

		private void FlashExplorer_FormClosing(object sender, FormClosingEventArgs e) {
			e.Cancel = _Fetching; // Do not allow closing when fetching
		}
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Flight.Properties;

namespace Flight {
    public partial class StepRepeatDlg : Form {
        public double LayoutStartX { set; get; } = 0;
        public double LayoutStartY { set; get; } = 0;
        public double LayoutDeltaX { set; get; } = 10;
        public double LayoutDeltaY { set; get; } = 10;
        public int LayoutColumns { set; get; } = 1;
        public int LayoutRows { set; get; } = 1;
        public double LayoutParamDeltaX { set; get; } = 0;
        public double LayoutParamDeltaY { set; get; } = 0;
        public double LayoutStartParamX { set; get; } = 0;
        public double LayoutStartParamY { set; get; } = 0;
        public string SelectedParamX { set; get; }
        public string SelectedParamY { set; get; }

        public StepRepeatDlg() {
            InitializeComponent();
        }

        private void StepRepeatDlg_Load(object sender, EventArgs e) {
            var paramList = new object[] {
                //"--Select param--",
                "Power",
                "Velocity",
                "PRF",
                "HatchPitch",
                "Repetitions"
            };
            comboBox1.Items.AddRange(paramList);
            comboBox2.Items.AddRange(paramList);
            //comboBox1.SelectedIndex = 0;
            //comboBox2.SelectedIndex = 0;
            textBox1.DataBindings.Add(new Binding("Text", this, "LayoutStartX"));
            textBox2.DataBindings.Add(new Binding("Text", this, "LayoutStartY"));
            textBox3.DataBindings.Add(new Binding("Text", this, "LayoutDeltaX"));
            textBox4.DataBindings.Add(new Binding("Text", this, "LayoutDeltaY"));
            textBox5.DataBindings.Add(new Binding("Text", this, "LayoutColumns"));
            textBox6.DataBindings.Add(new Binding("Text", this, "LayoutRows"));
            textBox9.DataBindings.Add(new Binding("Text", this, "LayoutParamDeltaX"));
            textBox7.DataBindings.Add(new Binding("Text", this, "LayoutParamDeltaY"));
            textBox8.DataBindings.Add(new Binding("Text", this, "LayoutStartParamX"));
            textBox10.DataBindings.Add(new Binding("Text", this, "LayoutStartParamY"));
        }


        private void panel1_Paint(object sender, PaintEventArgs e) {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle,
                                             Color.Black, 1, ButtonBorderStyle.Solid,
                                             Color.Black, 1, ButtonBorderStyle.Solid,
                                             Color.Black, 1, ButtonBorderStyle.Solid,
                                             Color.Black, 1, ButtonBorderStyle.Solid);
        }

        private void panel2_Paint(object sender, PaintEventArgs e) {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, this.panel2.ClientRectangle,
                                             Color.Black, 1, ButtonBorderStyle.Solid,
                                             Color.Black, 1, ButtonBorderStyle.Solid,
                                             Color.Black, 1, ButtonBorderStyle.Solid,
                                             Color.Black, 1, ButtonBorderStyle.Solid);
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e) => SelectedParamX = ((ComboBox)sender).SelectedItem.ToString();

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e) => SelectedParamY = ((ComboBox)sender).SelectedItem.ToString();

    }

}

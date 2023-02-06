
namespace Engine {
    partial class Options {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.VelTxt = new System.Windows.Forms.Label();
            this.AccTxt = new System.Windows.Forms.Label();
            this.VelLb = new System.Windows.Forms.TextBox();
            this.AccLb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VelTxt
            // 
            this.VelTxt.AutoSize = true;
            this.VelTxt.Location = new System.Drawing.Point(38, 13);
            this.VelTxt.Name = "VelTxt";
            this.VelTxt.Size = new System.Drawing.Size(44, 13);
            this.VelTxt.TabIndex = 0;
            this.VelTxt.Text = "Velocity";
            // 
            // AccTxt
            // 
            this.AccTxt.AutoSize = true;
            this.AccTxt.Location = new System.Drawing.Point(10, 42);
            this.AccTxt.Name = "AccTxt";
            this.AccTxt.Size = new System.Drawing.Size(72, 13);
            this.AccTxt.TabIndex = 1;
            this.AccTxt.Text = "Accelerantion";
            // 
            // VelLb
            // 
            this.VelLb.Location = new System.Drawing.Point(88, 13);
            this.VelLb.Name = "VelLb";
            this.VelLb.Size = new System.Drawing.Size(100, 20);
            this.VelLb.TabIndex = 2;
            // 
            // AccLb
            // 
            this.AccLb.Location = new System.Drawing.Point(88, 39);
            this.AccLb.Name = "AccLb";
            this.AccLb.Size = new System.Drawing.Size(100, 20);
            this.AccLb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "mm/s^2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "mm/s";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(210, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 122);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AccLb);
            this.Controls.Add(this.VelLb);
            this.Controls.Add(this.AccTxt);
            this.Controls.Add(this.VelTxt);
            this.Name = "Options";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VelTxt;
        private System.Windows.Forms.Label AccTxt;
        private System.Windows.Forms.TextBox VelLb;
        private System.Windows.Forms.TextBox AccLb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}
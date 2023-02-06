
namespace Engine {
    partial class StageControl {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StageControl));
            this.panel3 = new System.Windows.Forms.Panel();
            this.ActuatorLb = new System.Windows.Forms.Label();
            this.StatusLb = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.ReverseLimit = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ForwardLimit = new System.Windows.Forms.PictureBox();
            this.HomeText = new System.Windows.Forms.Label();
            this.homedLight = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RelativeValue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.RelativeBtForward = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.AbsoluteValue = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.RelativeBtBack = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.AbsoluteBt = new System.Windows.Forms.Button();
            this.StopBt = new System.Windows.Forms.Button();
            this.HomeBt = new System.Windows.Forms.Button();
            this.SettingsXBt = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.accLb = new System.Windows.Forms.Label();
            this.velocityLb = new System.Windows.Forms.Label();
            this.TravelLb = new System.Windows.Forms.Label();
            this.PosLb = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReverseLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForwardLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homedLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ActuatorLb);
            this.panel3.Controls.Add(this.StatusLb);
            this.panel3.Location = new System.Drawing.Point(13, 184);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(714, 28);
            this.panel3.TabIndex = 31;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // ActuatorLb
            // 
            this.ActuatorLb.AutoSize = true;
            this.ActuatorLb.Location = new System.Drawing.Point(605, 8);
            this.ActuatorLb.Name = "ActuatorLb";
            this.ActuatorLb.Size = new System.Drawing.Size(101, 13);
            this.ActuatorLb.TabIndex = 28;
            this.ActuatorLb.Text = "Actuator: MAX201X";
            // 
            // StatusLb
            // 
            this.StatusLb.AutoSize = true;
            this.StatusLb.Location = new System.Drawing.Point(14, 8);
            this.StatusLb.Name = "StatusLb";
            this.StatusLb.Size = new System.Drawing.Size(24, 13);
            this.StatusLb.TabIndex = 27;
            this.StatusLb.Text = "Idle";
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.ReverseLimit);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.ForwardLimit);
            this.panel5.Controls.Add(this.HomeText);
            this.panel5.Controls.Add(this.homedLight);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.RelativeValue);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.RelativeBtForward);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.AbsoluteValue);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.RelativeBtBack);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.AbsoluteBt);
            this.panel5.Controls.Add(this.StopBt);
            this.panel5.Controls.Add(this.HomeBt);
            this.panel5.Controls.Add(this.SettingsXBt);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.accLb);
            this.panel5.Controls.Add(this.velocityLb);
            this.panel5.Controls.Add(this.TravelLb);
            this.panel5.Controls.Add(this.PosLb);
            this.panel5.Location = new System.Drawing.Point(13, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(714, 175);
            this.panel5.TabIndex = 32;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(617, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Reverse Limit";
            // 
            // ReverseLimit
            // 
            this.ReverseLimit.BackColor = System.Drawing.Color.Gray;
            this.ReverseLimit.Location = new System.Drawing.Point(689, 74);
            this.ReverseLimit.Name = "ReverseLimit";
            this.ReverseLimit.Size = new System.Drawing.Size(13, 14);
            this.ReverseLimit.TabIndex = 25;
            this.ReverseLimit.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(617, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Forward Limit";
            // 
            // ForwardLimit
            // 
            this.ForwardLimit.BackColor = System.Drawing.Color.Gray;
            this.ForwardLimit.Location = new System.Drawing.Point(689, 53);
            this.ForwardLimit.Name = "ForwardLimit";
            this.ForwardLimit.Size = new System.Drawing.Size(13, 14);
            this.ForwardLimit.TabIndex = 23;
            this.ForwardLimit.TabStop = false;
            // 
            // HomeText
            // 
            this.HomeText.AutoSize = true;
            this.HomeText.Location = new System.Drawing.Point(617, 33);
            this.HomeText.Name = "HomeText";
            this.HomeText.Size = new System.Drawing.Size(41, 13);
            this.HomeText.TabIndex = 22;
            this.HomeText.Text = "Homed";
            // 
            // homedLight
            // 
            this.homedLight.BackColor = System.Drawing.Color.Lime;
            this.homedLight.Location = new System.Drawing.Point(689, 32);
            this.homedLight.Name = "homedLight";
            this.homedLight.Size = new System.Drawing.Size(13, 14);
            this.homedLight.TabIndex = 6;
            this.homedLight.TabStop = false;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(292, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1, 133);
            this.label9.TabIndex = 21;
            // 
            // RelativeValue
            // 
            this.RelativeValue.Location = new System.Drawing.Point(476, 118);
            this.RelativeValue.Name = "RelativeValue";
            this.RelativeValue.Size = new System.Drawing.Size(96, 20);
            this.RelativeValue.TabIndex = 20;
            this.RelativeValue.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(486, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Move Relative:";
            // 
            // RelativeBtForward
            // 
            this.RelativeBtForward.FlatAppearance.BorderSize = 0;
            this.RelativeBtForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RelativeBtForward.Image = ((System.Drawing.Image)(resources.GetObject("RelativeBtForward.Image")));
            this.RelativeBtForward.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.RelativeBtForward.Location = new System.Drawing.Point(532, 23);
            this.RelativeBtForward.Name = "RelativeBtForward";
            this.RelativeBtForward.Size = new System.Drawing.Size(60, 55);
            this.RelativeBtForward.TabIndex = 18;
            this.RelativeBtForward.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RelativeBtForward.UseVisualStyleBackColor = true;
            this.RelativeBtForward.Click += new System.EventHandler(this.RelativeBtForward_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(318, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Move Absolute:";
            // 
            // AbsoluteValue
            // 
            this.AbsoluteValue.Location = new System.Drawing.Point(309, 120);
            this.AbsoluteValue.Name = "AbsoluteValue";
            this.AbsoluteValue.Size = new System.Drawing.Size(100, 20);
            this.AbsoluteValue.TabIndex = 6;
            this.AbsoluteValue.Text = "0";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(605, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1, 133);
            this.label12.TabIndex = 16;
            // 
            // RelativeBtBack
            // 
            this.RelativeBtBack.FlatAppearance.BorderSize = 0;
            this.RelativeBtBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RelativeBtBack.Image = ((System.Drawing.Image)(resources.GetObject("RelativeBtBack.Image")));
            this.RelativeBtBack.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.RelativeBtBack.Location = new System.Drawing.Point(452, 22);
            this.RelativeBtBack.Name = "RelativeBtBack";
            this.RelativeBtBack.Size = new System.Drawing.Size(60, 62);
            this.RelativeBtBack.TabIndex = 15;
            this.RelativeBtBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RelativeBtBack.UseVisualStyleBackColor = true;
            this.RelativeBtBack.Click += new System.EventHandler(this.RelativeBtBack_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(111, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1, 70);
            this.label13.TabIndex = 11;
            // 
            // AbsoluteBt
            // 
            this.AbsoluteBt.FlatAppearance.BorderSize = 0;
            this.AbsoluteBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AbsoluteBt.Image = ((System.Drawing.Image)(resources.GetObject("AbsoluteBt.Image")));
            this.AbsoluteBt.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.AbsoluteBt.Location = new System.Drawing.Point(326, 10);
            this.AbsoluteBt.Name = "AbsoluteBt";
            this.AbsoluteBt.Size = new System.Drawing.Size(60, 74);
            this.AbsoluteBt.TabIndex = 10;
            this.AbsoluteBt.Text = "Move";
            this.AbsoluteBt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AbsoluteBt.UseVisualStyleBackColor = true;
            this.AbsoluteBt.Click += new System.EventHandler(this.AbsoluteBt_Click);
            // 
            // StopBt
            // 
            this.StopBt.FlatAppearance.BorderSize = 0;
            this.StopBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopBt.Image = ((System.Drawing.Image)(resources.GetObject("StopBt.Image")));
            this.StopBt.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.StopBt.Location = new System.Drawing.Point(214, 10);
            this.StopBt.Name = "StopBt";
            this.StopBt.Size = new System.Drawing.Size(60, 74);
            this.StopBt.TabIndex = 9;
            this.StopBt.Text = "Stop";
            this.StopBt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.StopBt.UseVisualStyleBackColor = true;
            this.StopBt.Click += new System.EventHandler(this.StopBt_Click);
            // 
            // HomeBt
            // 
            this.HomeBt.FlatAppearance.BorderSize = 0;
            this.HomeBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBt.Image = ((System.Drawing.Image)(resources.GetObject("HomeBt.Image")));
            this.HomeBt.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.HomeBt.Location = new System.Drawing.Point(214, 79);
            this.HomeBt.Name = "HomeBt";
            this.HomeBt.Size = new System.Drawing.Size(60, 74);
            this.HomeBt.TabIndex = 8;
            this.HomeBt.Text = "Home";
            this.HomeBt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.HomeBt.UseVisualStyleBackColor = true;
            this.HomeBt.Click += new System.EventHandler(this.HomeBt_Click);
            // 
            // SettingsXBt
            // 
            this.SettingsXBt.FlatAppearance.BorderSize = 0;
            this.SettingsXBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsXBt.Image = ((System.Drawing.Image)(resources.GetObject("SettingsXBt.Image")));
            this.SettingsXBt.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.SettingsXBt.Location = new System.Drawing.Point(126, 78);
            this.SettingsXBt.Name = "SettingsXBt";
            this.SettingsXBt.Size = new System.Drawing.Size(60, 74);
            this.SettingsXBt.TabIndex = 7;
            this.SettingsXBt.Text = "Settings";
            this.SettingsXBt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SettingsXBt.UseVisualStyleBackColor = true;
            this.SettingsXBt.Click += new System.EventHandler(this.SettingsBt_Click);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(433, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(1, 133);
            this.label14.TabIndex = 5;
            // 
            // accLb
            // 
            this.accLb.AutoSize = true;
            this.accLb.Location = new System.Drawing.Point(17, 129);
            this.accLb.Name = "accLb";
            this.accLb.Size = new System.Drawing.Size(79, 13);
            this.accLb.TabIndex = 3;
            this.accLb.Text = "Acc: 0 mm/s^2";
            // 
            // velocityLb
            // 
            this.velocityLb.AutoSize = true;
            this.velocityLb.Location = new System.Drawing.Point(17, 109);
            this.velocityLb.Name = "velocityLb";
            this.velocityLb.Size = new System.Drawing.Size(85, 13);
            this.velocityLb.TabIndex = 2;
            this.velocityLb.Text = "Velocity: 0 mm/s";
            // 
            // TravelLb
            // 
            this.TravelLb.AutoSize = true;
            this.TravelLb.Location = new System.Drawing.Point(17, 87);
            this.TravelLb.Name = "TravelLb";
            this.TravelLb.Size = new System.Drawing.Size(68, 13);
            this.TravelLb.TabIndex = 1;
            this.TravelLb.Text = "Travel: 0 mm";
            // 
            // PosLb
            // 
            this.PosLb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PosLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PosLb.Location = new System.Drawing.Point(17, 15);
            this.PosLb.Name = "PosLb";
            this.PosLb.Size = new System.Drawing.Size(186, 56);
            this.PosLb.TabIndex = 0;
            this.PosLb.Text = "0,00000 mm";
            this.PosLb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Name = "StageControl";
            this.Size = new System.Drawing.Size(741, 224);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReverseLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForwardLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homedLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label StatusLb;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox ReverseLimit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox ForwardLimit;
        private System.Windows.Forms.Label HomeText;
        private System.Windows.Forms.PictureBox homedLight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox RelativeValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button RelativeBtForward;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox AbsoluteValue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button RelativeBtBack;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button AbsoluteBt;
        private System.Windows.Forms.Button StopBt;
        private System.Windows.Forms.Button HomeBt;
        private System.Windows.Forms.Button SettingsXBt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label accLb;
        private System.Windows.Forms.Label velocityLb;
        private System.Windows.Forms.Label TravelLb;
        private System.Windows.Forms.Label PosLb;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.Label ActuatorLb;
    }
}

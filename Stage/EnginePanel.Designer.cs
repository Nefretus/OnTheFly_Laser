using System.ComponentModel;

namespace Engine {
    partial class EnginePanel {
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
            this.components = new System.ComponentModel.Container();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stageControl1 = new Engine.StageControl();
            this.stageControl2 = new Engine.StageControl();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // stageControl1
            // 
            this.stageControl1.Location = new System.Drawing.Point(12, 242);
            this.stageControl1.Name = "stageControl1";
            this.stageControl1.Size = new System.Drawing.Size(741, 224);
            this.stageControl1.TabIndex = 35;
            // 
            // stageControl2
            // 
            this.stageControl2.Location = new System.Drawing.Point(12, 12);
            this.stageControl2.Name = "stageControl2";
            this.stageControl2.Size = new System.Drawing.Size(741, 224);
            this.stageControl2.TabIndex = 34;
            // 
            // EnginePanel
            // 
            this.ClientSize = new System.Drawing.Size(788, 495);
            this.Controls.Add(this.stageControl1);
            this.Controls.Add(this.stageControl2);
            this.Name = "EnginePanel";
            this.Text = "Engine Panel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EngineForm_FormClosed);
            this.Load += new System.EventHandler(this.EngineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Engine.StageControl stageControl2;
        private Engine.StageControl stageControl1;
    }
}
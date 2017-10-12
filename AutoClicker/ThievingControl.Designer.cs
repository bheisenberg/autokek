namespace AutoClicker
{
    partial class ThievingControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hpPanel = new System.Windows.Forms.Panel();
            this.hpLabel = new System.Windows.Forms.Label();
            this.hpPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // hpPanel
            // 
            this.hpPanel.BackgroundImage = global::AutoClicker.Properties.Resources.hp;
            this.hpPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.hpPanel.Controls.Add(this.hpLabel);
            this.hpPanel.Location = new System.Drawing.Point(110, 32);
            this.hpPanel.Name = "hpPanel";
            this.hpPanel.Size = new System.Drawing.Size(67, 41);
            this.hpPanel.TabIndex = 33;
            // 
            // hpLabel
            // 
            this.hpLabel.AutoSize = true;
            this.hpLabel.BackColor = System.Drawing.Color.Transparent;
            this.hpLabel.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpLabel.ForeColor = System.Drawing.Color.Lime;
            this.hpLabel.Location = new System.Drawing.Point(7, 14);
            this.hpLabel.Name = "hpLabel";
            this.hpLabel.Size = new System.Drawing.Size(0, 20);
            this.hpLabel.TabIndex = 30;
            // 
            // ThievingControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.hpPanel);
            this.Name = "ThievingControl";
            this.Size = new System.Drawing.Size(253, 304);
            this.hpPanel.ResumeLayout(false);
            this.hpPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel hpPanel;
        private System.Windows.Forms.Label hpLabel;
    }
}

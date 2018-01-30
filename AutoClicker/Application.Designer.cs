namespace AutoClicker
{
    partial class Application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Application));
            this.startButton = new System.Windows.Forms.Button();
            this.tildeLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.alchemyButton = new System.Windows.Forms.Button();
            this.thievingButton = new System.Windows.Forms.Button();
            this.nmzButton = new System.Windows.Forms.Button();
            this.teleportButton = new System.Windows.Forms.Button();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.runescapeButton = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contentPanel = new System.Windows.Forms.Panel();
            this.rangeLabel = new System.Windows.Forms.Label();
            this.TimerControl = new TimerControl.TimeControl();
            this.rangeControl1 = new TimerControl.RangeControl();
            this.optionsPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(13, 236);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 28);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // tildeLabel
            // 
            this.tildeLabel.AutoSize = true;
            this.tildeLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.tildeLabel.Location = new System.Drawing.Point(0, 0);
            this.tildeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tildeLabel.Name = "tildeLabel";
            this.tildeLabel.Size = new System.Drawing.Size(132, 17);
            this.tildeLabel.TabIndex = 9;
            this.tildeLabel.Text = "Press ` to start/stop";
            this.tildeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.versionLabel.Location = new System.Drawing.Point(419, 0);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(104, 17);
            this.versionLabel.TabIndex = 14;
            this.versionLabel.Text = "Version 1.0.1.0";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // optionsPanel
            // 
            this.optionsPanel.AutoSize = true;
            this.optionsPanel.Controls.Add(this.alchemyButton);
            this.optionsPanel.Controls.Add(this.thievingButton);
            this.optionsPanel.Controls.Add(this.nmzButton);
            this.optionsPanel.Controls.Add(this.teleportButton);
            this.optionsPanel.Location = new System.Drawing.Point(468, 12);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(43, 180);
            this.optionsPanel.TabIndex = 28;
            // 
            // alchemyButton
            // 
            this.alchemyButton.BackColor = System.Drawing.Color.Transparent;
            this.alchemyButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("alchemyButton.BackgroundImage")));
            this.alchemyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.alchemyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alchemyButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.alchemyButton.FlatAppearance.BorderSize = 0;
            this.alchemyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alchemyButton.Location = new System.Drawing.Point(0, 111);
            this.alchemyButton.Margin = new System.Windows.Forms.Padding(4);
            this.alchemyButton.Name = "alchemyButton";
            this.alchemyButton.Size = new System.Drawing.Size(43, 37);
            this.alchemyButton.TabIndex = 13;
            this.alchemyButton.UseVisualStyleBackColor = false;
            this.alchemyButton.Click += new System.EventHandler(this.alchemyButton_Click);
            // 
            // thievingButton
            // 
            this.thievingButton.BackColor = System.Drawing.Color.Transparent;
            this.thievingButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("thievingButton.BackgroundImage")));
            this.thievingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.thievingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.thievingButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.thievingButton.FlatAppearance.BorderSize = 0;
            this.thievingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thievingButton.Location = new System.Drawing.Point(0, 74);
            this.thievingButton.Margin = new System.Windows.Forms.Padding(4);
            this.thievingButton.Name = "thievingButton";
            this.thievingButton.Size = new System.Drawing.Size(43, 37);
            this.thievingButton.TabIndex = 27;
            this.thievingButton.UseVisualStyleBackColor = false;
            this.thievingButton.Click += new System.EventHandler(this.thievingButton_Click);
            // 
            // nmzButton
            // 
            this.nmzButton.BackColor = System.Drawing.Color.Transparent;
            this.nmzButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nmzButton.BackgroundImage")));
            this.nmzButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.nmzButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nmzButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.nmzButton.FlatAppearance.BorderSize = 0;
            this.nmzButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nmzButton.Location = new System.Drawing.Point(0, 37);
            this.nmzButton.Margin = new System.Windows.Forms.Padding(4);
            this.nmzButton.Name = "nmzButton";
            this.nmzButton.Size = new System.Drawing.Size(43, 37);
            this.nmzButton.TabIndex = 25;
            this.nmzButton.UseVisualStyleBackColor = false;
            this.nmzButton.Click += new System.EventHandler(this.nmzButton_Click);
            // 
            // teleportButton
            // 
            this.teleportButton.BackColor = System.Drawing.Color.Transparent;
            this.teleportButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("teleportButton.BackgroundImage")));
            this.teleportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.teleportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.teleportButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.teleportButton.FlatAppearance.BorderSize = 0;
            this.teleportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teleportButton.Location = new System.Drawing.Point(0, 0);
            this.teleportButton.Margin = new System.Windows.Forms.Padding(4);
            this.teleportButton.Name = "teleportButton";
            this.teleportButton.Size = new System.Drawing.Size(43, 37);
            this.teleportButton.TabIndex = 26;
            this.teleportButton.UseVisualStyleBackColor = false;
            this.teleportButton.Click += new System.EventHandler(this.teleportButton_Click);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.runescapeButton);
            this.bottomPanel.Controls.Add(this.tildeLabel);
            this.bottomPanel.Controls.Add(this.versionLabel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 291);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(523, 23);
            this.bottomPanel.TabIndex = 29;
            // 
            // runescapeButton
            // 
            this.runescapeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.runescapeButton.Location = new System.Drawing.Point(132, 0);
            this.runescapeButton.Margin = new System.Windows.Forms.Padding(4);
            this.runescapeButton.Name = "runescapeButton";
            this.runescapeButton.Size = new System.Drawing.Size(287, 23);
            this.runescapeButton.TabIndex = 35;
            this.runescapeButton.Text = "Connect to RuneScape";
            this.runescapeButton.UseVisualStyleBackColor = true;
            this.runescapeButton.Click += new System.EventHandler(this.runescapeButton_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.Transparent;
            this.contentPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contentPanel.BackgroundImage")));
            this.contentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.contentPanel.Location = new System.Drawing.Point(263, 12);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(210, 235);
            this.contentPanel.TabIndex = 33;
            // 
            // rangeLabel
            // 
            this.rangeLabel.AutoSize = true;
            this.rangeLabel.Location = new System.Drawing.Point(33, 12);
            this.rangeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rangeLabel.Name = "rangeLabel";
            this.rangeLabel.Size = new System.Drawing.Size(50, 17);
            this.rangeLabel.TabIndex = 3;
            this.rangeLabel.Text = "Range";
            // 
            // TimerControl
            // 
            this.TimerControl.Location = new System.Drawing.Point(21, 137);
            this.TimerControl.Name = "TimerControl";
            this.TimerControl.Size = new System.Drawing.Size(205, 92);
            this.TimerControl.TabIndex = 35;
            // 
            // rangeControl1
            // 
            this.rangeControl1.Location = new System.Drawing.Point(36, 32);
            this.rangeControl1.Name = "rangeControl1";
            this.rangeControl1.Size = new System.Drawing.Size(190, 110);
            this.rangeControl1.TabIndex = 36;
            // 
            // Application
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(523, 314);
            this.Controls.Add(this.rangeControl1);
            this.Controls.Add(this.TimerControl);
            this.Controls.Add(this.optionsPanel);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.rangeLabel);
            this.Controls.Add(this.startButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Application";
            this.Text = "Autokek";
            this.Load += new System.EventHandler(this.Application_Load);
            this.optionsPanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label tildeLabel;
        private System.Windows.Forms.Button alchemyButton;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Button nmzButton;
        private System.Windows.Forms.Button teleportButton;
        private System.Windows.Forms.Button thievingButton;
        private System.Windows.Forms.Panel optionsPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Button runescapeButton;
        private TimerControl.TimeControl TimerControl;
        private System.Windows.Forms.Label rangeLabel;
        private TimerControl.RangeControl rangeControl1;
    }
}


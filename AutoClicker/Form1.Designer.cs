namespace AutoClicker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startButton = new System.Windows.Forms.Button();
            this.rangeLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.msLabel = new System.Windows.Forms.Label();
            this.rangeStartNumber = new System.Windows.Forms.NumericUpDown();
            this.rangeEndNumber = new System.Windows.Forms.NumericUpDown();
            this.tildeLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.durationNumber = new System.Windows.Forms.NumericUpDown();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.smartAlchCheck = new System.Windows.Forms.CheckBox();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.alchemyButton = new System.Windows.Forms.Button();
            this.startupNumber = new System.Windows.Forms.NumericUpDown();
            this.startupLabel = new System.Windows.Forms.Label();
            this.startupSecondsLabel = new System.Windows.Forms.Label();
            this.nmzButton = new System.Windows.Forms.Button();
            this.teleportButton = new System.Windows.Forms.Button();
            this.thievingButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hpLabel = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rangeStartNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeEndNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startupNumber)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(13, 221);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 28);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // rangeLabel
            // 
            this.rangeLabel.AutoSize = true;
            this.rangeLabel.Location = new System.Drawing.Point(13, 41);
            this.rangeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rangeLabel.Name = "rangeLabel";
            this.rangeLabel.Size = new System.Drawing.Size(50, 17);
            this.rangeLabel.TabIndex = 3;
            this.rangeLabel.Text = "Range";
            this.rangeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(195, 41);
            this.toLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(20, 17);
            this.toLabel.TabIndex = 5;
            this.toLabel.Text = "to";
            this.toLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // msLabel
            // 
            this.msLabel.AutoSize = true;
            this.msLabel.Location = new System.Drawing.Point(320, 41);
            this.msLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.msLabel.Name = "msLabel";
            this.msLabel.Size = new System.Drawing.Size(26, 17);
            this.msLabel.TabIndex = 6;
            this.msLabel.Text = "ms";
            this.msLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // rangeStartNumber
            // 
            this.rangeStartNumber.Location = new System.Drawing.Point(81, 38);
            this.rangeStartNumber.Margin = new System.Windows.Forms.Padding(4);
            this.rangeStartNumber.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.rangeStartNumber.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.rangeStartNumber.Name = "rangeStartNumber";
            this.rangeStartNumber.Size = new System.Drawing.Size(105, 22);
            this.rangeStartNumber.TabIndex = 7;
            this.rangeStartNumber.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // rangeEndNumber
            // 
            this.rangeEndNumber.Location = new System.Drawing.Point(224, 38);
            this.rangeEndNumber.Margin = new System.Windows.Forms.Padding(4);
            this.rangeEndNumber.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.rangeEndNumber.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.rangeEndNumber.Name = "rangeEndNumber";
            this.rangeEndNumber.Size = new System.Drawing.Size(88, 22);
            this.rangeEndNumber.TabIndex = 8;
            this.rangeEndNumber.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
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
            this.versionLabel.Location = new System.Drawing.Point(553, 0);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(131, 17);
            this.versionLabel.TabIndex = 14;
            this.versionLabel.Text = "Version 1.41 (Beta)";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.versionLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // durationNumber
            // 
            this.durationNumber.Location = new System.Drawing.Point(81, 70);
            this.durationNumber.Margin = new System.Windows.Forms.Padding(4);
            this.durationNumber.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.durationNumber.Name = "durationNumber";
            this.durationNumber.Size = new System.Drawing.Size(100, 22);
            this.durationNumber.TabIndex = 15;
            this.durationNumber.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Location = new System.Drawing.Point(189, 73);
            this.minutesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(57, 17);
            this.minutesLabel.TabIndex = 16;
            this.minutesLabel.Text = "minutes";
            this.minutesLabel.Click += new System.EventHandler(this.label7_Click);
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(13, 73);
            this.durationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(62, 17);
            this.durationLabel.TabIndex = 17;
            this.durationLabel.Text = "Duration";
            // 
            // smartAlchCheck
            // 
            this.smartAlchCheck.AutoSize = true;
            this.smartAlchCheck.Location = new System.Drawing.Point(16, 155);
            this.smartAlchCheck.Margin = new System.Windows.Forms.Padding(4);
            this.smartAlchCheck.Name = "smartAlchCheck";
            this.smartAlchCheck.Size = new System.Drawing.Size(204, 21);
            this.smartAlchCheck.TabIndex = 19;
            this.smartAlchCheck.Text = "Image Recognition Alchemy";
            this.smartAlchCheck.UseVisualStyleBackColor = true;
            this.smartAlchCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Location = new System.Drawing.Point(171, 11);
            this.settingsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(59, 17);
            this.settingsLabel.TabIndex = 21;
            this.settingsLabel.Text = "Settings";
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
            this.alchemyButton.Location = new System.Drawing.Point(0, 135);
            this.alchemyButton.Margin = new System.Windows.Forms.Padding(4);
            this.alchemyButton.Name = "alchemyButton";
            this.alchemyButton.Size = new System.Drawing.Size(67, 45);
            this.alchemyButton.TabIndex = 13;
            this.alchemyButton.UseVisualStyleBackColor = false;
            this.alchemyButton.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // startupNumber
            // 
            this.startupNumber.Location = new System.Drawing.Point(81, 100);
            this.startupNumber.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.startupNumber.Name = "startupNumber";
            this.startupNumber.Size = new System.Drawing.Size(100, 22);
            this.startupNumber.TabIndex = 22;
            // 
            // startupLabel
            // 
            this.startupLabel.AutoSize = true;
            this.startupLabel.Location = new System.Drawing.Point(13, 103);
            this.startupLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startupLabel.Name = "startupLabel";
            this.startupLabel.Size = new System.Drawing.Size(54, 17);
            this.startupLabel.TabIndex = 23;
            this.startupLabel.Text = "Startup";
            // 
            // startupSecondsLabel
            // 
            this.startupSecondsLabel.AutoSize = true;
            this.startupSecondsLabel.Location = new System.Drawing.Point(188, 102);
            this.startupSecondsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startupSecondsLabel.Name = "startupSecondsLabel";
            this.startupSecondsLabel.Size = new System.Drawing.Size(26, 17);
            this.startupSecondsLabel.TabIndex = 24;
            this.startupSecondsLabel.Text = "ms";
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
            this.nmzButton.Location = new System.Drawing.Point(0, 45);
            this.nmzButton.Margin = new System.Windows.Forms.Padding(4);
            this.nmzButton.Name = "nmzButton";
            this.nmzButton.Size = new System.Drawing.Size(67, 45);
            this.nmzButton.TabIndex = 25;
            this.nmzButton.UseVisualStyleBackColor = false;
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
            this.teleportButton.Size = new System.Drawing.Size(67, 45);
            this.teleportButton.TabIndex = 26;
            this.teleportButton.UseVisualStyleBackColor = false;
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
            this.thievingButton.Location = new System.Drawing.Point(0, 90);
            this.thievingButton.Margin = new System.Windows.Forms.Padding(4);
            this.thievingButton.Name = "thievingButton";
            this.thievingButton.Size = new System.Drawing.Size(67, 45);
            this.thievingButton.TabIndex = 27;
            this.thievingButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.alchemyButton);
            this.panel1.Controls.Add(this.thievingButton);
            this.panel1.Controls.Add(this.nmzButton);
            this.panel1.Controls.Add(this.teleportButton);
            this.panel1.Location = new System.Drawing.Point(605, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(67, 180);
            this.panel1.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tildeLabel);
            this.panel2.Controls.Add(this.versionLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 256);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 23);
            this.panel2.TabIndex = 29;
            // 
            // hpLabel
            // 
            this.hpLabel.AutoSize = true;
            this.hpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpLabel.Location = new System.Drawing.Point(480, 13);
            this.hpLabel.Name = "hpLabel";
            this.hpLabel.Size = new System.Drawing.Size(47, 32);
            this.hpLabel.TabIndex = 30;
            this.hpLabel.Text = "99";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 279);
            this.Controls.Add(this.hpLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.startupSecondsLabel);
            this.Controls.Add(this.startupLabel);
            this.Controls.Add(this.startupNumber);
            this.Controls.Add(this.settingsLabel);
            this.Controls.Add(this.smartAlchCheck);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.minutesLabel);
            this.Controls.Add(this.durationNumber);
            this.Controls.Add(this.rangeEndNumber);
            this.Controls.Add(this.rangeStartNumber);
            this.Controls.Add(this.msLabel);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.rangeLabel);
            this.Controls.Add(this.startButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Autokek";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rangeStartNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeEndNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startupNumber)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label rangeLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label msLabel;
        private System.Windows.Forms.NumericUpDown rangeStartNumber;
        private System.Windows.Forms.NumericUpDown rangeEndNumber;
        private System.Windows.Forms.Label tildeLabel;
        private System.Windows.Forms.Button alchemyButton;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.NumericUpDown durationNumber;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.CheckBox smartAlchCheck;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.NumericUpDown startupNumber;
        private System.Windows.Forms.Label startupLabel;
        private System.Windows.Forms.Label startupSecondsLabel;
        private System.Windows.Forms.Button nmzButton;
        private System.Windows.Forms.Button teleportButton;
        private System.Windows.Forms.Button thievingButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label hpLabel;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}


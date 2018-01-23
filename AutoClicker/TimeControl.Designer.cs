namespace AutoClicker
{
    partial class TimeControl
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
            this.hoursLabel = new System.Windows.Forms.Label();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.hmColinLabel = new System.Windows.Forms.Label();
            this.msColinLabel = new System.Windows.Forms.Label();
            this.numberBox1 = new global::AutoClicker.NumberBox();
            this.numberBox2 = new global::AutoClicker.NumberBox();
            this.numberBox3 = new global::AutoClicker.NumberBox();
            this.SuspendLayout();
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursLabel.Location = new System.Drawing.Point(6, 32);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(34, 13);
            this.hoursLabel.TabIndex = 3;
            this.hoursLabel.Text = "Hours";
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesLabel.Location = new System.Drawing.Point(55, 32);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(44, 13);
            this.minutesLabel.TabIndex = 4;
            this.minutesLabel.Text = "Minutes";
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsLabel.Location = new System.Drawing.Point(108, 32);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(48, 13);
            this.secondsLabel.TabIndex = 5;
            this.secondsLabel.Text = "Seconds";
            // 
            // hmColinLabel
            // 
            this.hmColinLabel.AutoSize = true;
            this.hmColinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hmColinLabel.Location = new System.Drawing.Point(43, 8);
            this.hmColinLabel.Name = "hmColinLabel";
            this.hmColinLabel.Size = new System.Drawing.Size(13, 17);
            this.hmColinLabel.TabIndex = 6;
            this.hmColinLabel.Text = ":";
            // 
            // msColinLabel
            // 
            this.msColinLabel.AutoSize = true;
            this.msColinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msColinLabel.Location = new System.Drawing.Point(96, 8);
            this.msColinLabel.Name = "msColinLabel";
            this.msColinLabel.Size = new System.Drawing.Size(13, 17);
            this.msColinLabel.TabIndex = 7;
            this.msColinLabel.Text = ":";
            // 
            // numberBox1
            // 
            this.numberBox1.Location = new System.Drawing.Point(3, 6);
            this.numberBox1.Name = "numberBox1";
            this.numberBox1.Size = new System.Drawing.Size(37, 22);
            this.numberBox1.TabIndex = 8;
            this.numberBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numberBox2
            // 
            this.numberBox2.Location = new System.Drawing.Point(57, 6);
            this.numberBox2.Name = "numberBox2";
            this.numberBox2.Size = new System.Drawing.Size(37, 22);
            this.numberBox2.TabIndex = 9;
            this.numberBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numberBox3
            // 
            this.numberBox3.Location = new System.Drawing.Point(111, 6);
            this.numberBox3.Name = "numberBox3";
            this.numberBox3.Size = new System.Drawing.Size(37, 22);
            this.numberBox3.TabIndex = 10;
            this.numberBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TimeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numberBox3);
            this.Controls.Add(this.numberBox2);
            this.Controls.Add(this.numberBox1);
            this.Controls.Add(this.minutesLabel);
            this.Controls.Add(this.secondsLabel);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.hmColinLabel);
            this.Controls.Add(this.msColinLabel);
            this.Name = "TimeControl";
            this.Size = new System.Drawing.Size(161, 56);
            this.Load += new System.EventHandler(this.TimeControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.Label hmColinLabel;
        private System.Windows.Forms.Label msColinLabel;
        private NumberBox numberBox1;
        private NumberBox numberBox2;
        private NumberBox numberBox3;
    }
}

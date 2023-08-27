namespace AutoClicker
{
    partial class Overlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overlay));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TimesClicked = new System.Windows.Forms.Label();
            this.TimeLeft = new System.Windows.Forms.Label();
            this.StopKeyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(43, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clicking...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "STOP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TimesClicked
            // 
            this.TimesClicked.Location = new System.Drawing.Point(7, 29);
            this.TimesClicked.Name = "TimesClicked";
            this.TimesClicked.Size = new System.Drawing.Size(173, 16);
            this.TimesClicked.TabIndex = 2;
            this.TimesClicked.Text = "Times clicked: 123123123";
            this.TimesClicked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeLeft
            // 
            this.TimeLeft.AutoSize = true;
            this.TimeLeft.Location = new System.Drawing.Point(40, 52);
            this.TimeLeft.Name = "TimeLeft";
            this.TimeLeft.Size = new System.Drawing.Size(112, 16);
            this.TimeLeft.TabIndex = 3;
            this.TimeLeft.Text = "Time left: 12:60:30";
            this.TimeLeft.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TimeLeft.Visible = false;
            // 
            // StopKeyLabel
            // 
            this.StopKeyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StopKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StopKeyLabel.Location = new System.Drawing.Point(143, 74);
            this.StopKeyLabel.Name = "StopKeyLabel";
            this.StopKeyLabel.Size = new System.Drawing.Size(37, 25);
            this.StopKeyLabel.TabIndex = 8;
            this.StopKeyLabel.Text = "F1";
            this.StopKeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Overlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(182, 107);
            this.Controls.Add(this.StopKeyLabel);
            this.Controls.Add(this.TimeLeft);
            this.Controls.Add(this.TimesClicked);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Overlay";
            this.Opacity = 0.6D;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Overlay";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TimesClicked;
        private System.Windows.Forms.Label TimeLeft;
        private System.Windows.Forms.Label StopKeyLabel;
    }
}
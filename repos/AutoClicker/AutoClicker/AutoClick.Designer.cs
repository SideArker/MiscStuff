namespace AutoClicker
{
    partial class AutoClick
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoClick));
            this.label1 = new System.Windows.Forms.Label();
            this.TimeBetween = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ClickTimer = new System.Windows.Forms.TextBox();
            this.StopKeyLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ChangeStopKey = new System.Windows.Forms.Button();
            this.StartClick = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.StopTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyOnStop = new System.Windows.Forms.CheckBox();
            this.Info = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Info)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(115, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "SideArker\'s clicker";
            // 
            // TimeBetween
            // 
            this.TimeBetween.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TimeBetween.Location = new System.Drawing.Point(149, 116);
            this.TimeBetween.Name = "TimeBetween";
            this.TimeBetween.Size = new System.Drawing.Size(111, 30);
            this.TimeBetween.TabIndex = 1;
            this.TimeBetween.Text = "1000";
            this.TimeBetween.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(136, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time between clicks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(266, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "ms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(266, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "s";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(114, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Autoclick timer (0 = inf)";
            // 
            // ClickTimer
            // 
            this.ClickTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClickTimer.Location = new System.Drawing.Point(149, 210);
            this.ClickTimer.Name = "ClickTimer";
            this.ClickTimer.Size = new System.Drawing.Size(111, 30);
            this.ClickTimer.TabIndex = 4;
            this.ClickTimer.Text = "0";
            this.ClickTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StopKeyLabel
            // 
            this.StopKeyLabel.AutoSize = true;
            this.StopKeyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StopKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StopKeyLabel.Location = new System.Drawing.Point(120, 307);
            this.StopKeyLabel.Name = "StopKeyLabel";
            this.StopKeyLabel.Size = new System.Drawing.Size(44, 31);
            this.StopKeyLabel.TabIndex = 7;
            this.StopKeyLabel.Text = "F1";
            this.StopKeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(158, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Stop key";
            // 
            // ChangeStopKey
            // 
            this.ChangeStopKey.Location = new System.Drawing.Point(185, 307);
            this.ChangeStopKey.Name = "ChangeStopKey";
            this.ChangeStopKey.Size = new System.Drawing.Size(103, 31);
            this.ChangeStopKey.TabIndex = 9;
            this.ChangeStopKey.Text = "Change";
            this.ChangeStopKey.UseVisualStyleBackColor = true;
            this.ChangeStopKey.Click += new System.EventHandler(this.ChangeStopKey_Click);
            // 
            // StartClick
            // 
            this.StartClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartClick.Location = new System.Drawing.Point(163, 403);
            this.StartClick.Name = "StartClick";
            this.StartClick.Size = new System.Drawing.Size(117, 35);
            this.StartClick.TabIndex = 10;
            this.StartClick.Text = "Start";
            this.StartClick.UseVisualStyleBackColor = true;
            this.StartClick.Click += new System.EventHandler(this.StartClick_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // StopTimer
            // 
            this.StopTimer.Tick += new System.EventHandler(this.StopTimer_Tick);
            // 
            // notifyOnStop
            // 
            this.notifyOnStop.AutoSize = true;
            this.notifyOnStop.Location = new System.Drawing.Point(163, 359);
            this.notifyOnStop.Name = "notifyOnStop";
            this.notifyOnStop.Size = new System.Drawing.Size(110, 20);
            this.notifyOnStop.TabIndex = 12;
            this.notifyOnStop.Text = "Notify on stop";
            this.notifyOnStop.UseVisualStyleBackColor = true;
            // 
            // Info
            // 
            this.Info.BackColor = System.Drawing.SystemColors.Control;
            this.Info.Image = global::AutoClicker.Properties.Resources.info3;
            this.Info.InitialImage = ((System.Drawing.Image)(resources.GetObject("Info.InitialImage")));
            this.Info.Location = new System.Drawing.Point(4, 5);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(48, 49);
            this.Info.TabIndex = 13;
            this.Info.TabStop = false;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // AutoClick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(440, 450);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.notifyOnStop);
            this.Controls.Add(this.StartClick);
            this.Controls.Add(this.ChangeStopKey);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.StopKeyLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ClickTimer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TimeBetween);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AutoClick";
            this.Text = "AutoClick";
            ((System.ComponentModel.ISupportInitialize)(this.Info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TimeBetween;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ClickTimer;
        private System.Windows.Forms.Label StopKeyLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ChangeStopKey;
        private System.Windows.Forms.Button StartClick;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Timer StopTimer;
        private System.Windows.Forms.CheckBox notifyOnStop;
        private System.Windows.Forms.PictureBox Info;
    }
}
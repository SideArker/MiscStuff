using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class Overlay : Form
    {
        public bool stopClicking = false;
        public int totalClicks = 0;
        int timeToClickFor = 0;
        #region FormInit
         public Overlay(int timerInSeconds, string stopKey)
        {
            InitializeComponent();

            timer.Interval = 50;
            timer.Tick += timer_Tick;
            timer.Start();

            StopKeyLabel.Text = stopKey;

            if(timerInSeconds > 0)
            {
                timeToClickFor = timerInSeconds;
                TimeLeft.Visible = true;

                TimeSpan time = TimeSpan.FromSeconds(timeToClickFor);
                TimeLeft.Text = "Time left: " + time.ToString(@"hh\:mm\:ss");

                TimesClicked.Text = $"Times Clicked: {totalClicks}";

                Timer timeLeft = new Timer();
                timeLeft.Interval = 1000;
                timeLeft.Tick += timeLeft_Tick;
                timeLeft.Start();
            }


            this.StartPosition = FormStartPosition.Manual;
            foreach (var scrn in Screen.AllScreens)
            {
                if (scrn.Bounds.Contains(this.Location))
                {
                    this.Location = new Point(scrn.Bounds.Right - this.Width, scrn.Bounds.Top);
                    return;
                }
            }

        }
        #endregion

        #region Timers
        private void timer_Tick(object sender, EventArgs e)
        {
            switch (RectangleToScreen(Bounds).Contains(PointToScreen(Cursor.Position)))
            {
                case true:
                    Opacity = 1D;
                    break;
                case false:
                    Opacity = 0.6D;
                    break;
            }

            TimesClicked.Text = $"Times Clicked: {totalClicks}";
        }

        private void timeLeft_Tick(object sender, EventArgs e)
        {
            timeToClickFor -= 1;

            TimeSpan time = TimeSpan.FromSeconds(timeToClickFor);
            TimeLeft.Text = "Time left: " + time.ToString(@"hh\:mm\:ss");
        }
        #endregion

        #region Click
        private void button1_Click(object sender, EventArgs e)
        {
            stopClicking = true;
        }
        #endregion

    }
}

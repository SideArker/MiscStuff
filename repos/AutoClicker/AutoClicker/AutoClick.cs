using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;

namespace AutoClicker
{
    public partial class AutoClick : Form
    {
        #region DLL's and constants

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        const int MYACTION_HOTKEY_ID = 1;

        #endregion

        #region variables

        Keys stopKey = Keys.F1;
        bool stopKeyPressed = false;
        bool currentlyClicking = false;
        Overlay currentOverlay;

        #endregion

        #region FormInit
        public AutoClick()
        {
            InitializeComponent();
            FormClosing += AutoClick_FormClosing;
            Timer.Stop();
            StopTimer.Stop();
            RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID, 0, (int)stopKey);
        }

        void AutoClick_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, MYACTION_HOTKEY_ID);
        }

        #endregion

        #region Clicks
        private void ChangeStopKey_Click(object sender, EventArgs e)
        {
            SelectKey selectKeyForm = new SelectKey();
            selectKeyForm.ShowDialog();

            if (selectKeyForm.DialogResult == DialogResult.OK)
            {
                UnregisterHotKey(this.Handle, MYACTION_HOTKEY_ID);
                this.StopKeyLabel.Text = selectKeyForm.Key.KeyCode.ToString();
                stopKey = selectKeyForm.Key.KeyCode;
                RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID, 0, (int)stopKey);
            }
        }


        private void StartClick_Click(object sender, EventArgs e)
        {
            StartClicking();
        }

        private void Info_Click(object sender, EventArgs e)
        {
            Credits credits = new Credits();
            credits.ShowDialog();
        }

        void StartClicking()
        {
            stopKeyPressed = false;
            Timer.Interval = Convert.ToInt32(TimeBetween.Text);
            Timer.Start();

            int StopTimerInterval = Convert.ToInt32(ClickTimer.Text) * 1000;
            if (StopTimerInterval > 0)
            {
                StopTimer.Interval = StopTimerInterval;
                StopTimer.Start();
            }
            currentlyClicking = true;

            this.WindowState = FormWindowState.Minimized;

            if(showOverlay.Checked)
            {
                currentOverlay = new Overlay(Convert.ToInt32(ClickTimer.Text), this.StopKeyLabel.Text);
                currentOverlay.Show();
            }
        }

        void StopClicking()
        {

            stopKeyPressed = true;
            Timer.Stop();
            StopTimer.Stop();
            currentlyClicking = false;

            if (showOverlay.Checked && currentOverlay != null)
            {
                currentOverlay.Close();
                currentOverlay = null;
            }

            if (showApp.Checked) this.WindowState = FormWindowState.Normal;

            if (notifyOnStop.Checked == true)
            {
                MessageBox.Show("Stopping clicking");
            }
        }
        #endregion

        #region Timers
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                StopClicking();
            }

            if (stopKeyPressed != true)
            {
                uint X = (uint)Cursor.Position.X;
                uint Y = (uint)Cursor.Position.Y;
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);

                if(currentOverlay != null)
                {
                    if(currentOverlay.stopClicking == true)
                    {
                        StopClicking();
                        return;
                    }

                    currentOverlay.totalClicks += 1;
                }
            }
            else
            {
                StopClicking();
            }
        }

        private void StopTimer_Tick(object sender, EventArgs e)
        {
            StopClicking();
        }

        #endregion

        #region Global Hotkey
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_ID)
            {

                if(currentlyClicking)
                {
                    StopClicking();
                }
                else StartClicking();

            }
            base.WndProc(ref m);
        }

        #endregion


    }
}

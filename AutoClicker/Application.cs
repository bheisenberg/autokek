using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Drawing.Text;
using System.Text.RegularExpressions;

namespace AutoClicker
{
    public partial class Application : Form
    {
        private string username;
        private bool active;
        private System.Timers.Timer kekTimer;
        private enum KekState { alching, teleporting, nmz, none, thieving };
        private KekState currState;
        private Input input;
        private DateTime startTime;
        private BackgroundWorker clickActivity;
        private const string defaultName = "Autokek";
        //private HitpointsCapturer hitpointsCapturer;
        private HitpointsCapturer hitpointsCapturer;
        private Control activeControl;
        private Window window;
        private GameScreen screen;

        public Application()
        {
            this.window = new Window();
            InitializeComponent();
            input = new Input(Keys.Oemtilde, this);
            input.Register();
            clickActivity = new BackgroundWorker();
        }

        private void StartKek()
        {
            if (window.IsRunescapeOpen())
            {
                username = window.GetUsername();
                Hiscore playerHiscore = new Hiscore(username);
                int hitpoints = playerHiscore.GetHitpoints();
                HitpointsCapturer hitpointsCapturer = new HitpointsCapturer(hitpoints,);
         
                SetFormText(defaultName + "(" + currState + ") [" + username + "]");
            } else
            {

            }
            active = true;
            SetTimer();
            startTime = DateTime.Now;
            Console.WriteLine(currState);
            SetControlText(startButton, "Stop");
        }

        public TimeSpan elapsed(DateTime start)
        {
            return DateTime.Now - start;
        }

        private void SetTimer()
        {
            kekTimer = new System.Timers.Timer();
            kekTimer.Elapsed += OnTimedEvent;
            kekTimer.AutoReset = true;
            kekTimer.Enabled = true;
        }

        private int timeLeft ()
        {
            return (int)durationNumber.Value - (int)elapsed(startTime).TotalSeconds;
        }

        private void InitHPFont()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("runescape_small.ttf");
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            if (timeLeft() > 0 || durationNumber.Value == 0)
            {
                Random r = new Random();
                int nextKekTime = r.Next((int)rangeStartNumber.Value, (int)rangeEndNumber.Value);
                Console.WriteLine(timeLeft());
                kekTimer.Interval = nextKekTime;
                switch (currState) {
                    case KekState.thieving:
                        Thieve();
                        break;
                    default:
                        Mouse.Click();
                        break;
                }
            }
        }

        private void Thieve()
        {
            /*ThievingControl thievingControl = (ThievingControl)activeControl;
            if (Window.IsRunescape())
            {
                Invoke(new MethodInvoker(delegate () {
                    thievingControl.UpdateHPLabel(healthCapture.GetCurrentHitpoints());
                }));
                if(healthCapture.GetCurrentHitpoints().amount > 3)
                {
                    Mouse.Click();
                } else
                {
                    StopKek();
                }
            }
            else
            {
                StopKek();
            }*/
        }

        private void TildePressed()
        {
            Kek();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID)
                TildePressed();
            base.WndProc(ref m);
        }

        private void Kek()
        {
            if (!active)
            {
                StartKek();
            }
            else
            {
                StopKek();
            }
            this.clickActivity.RunWorkerAsync();
        }

        private void StopKek()
        {
            active = false;
            kekTimer.Enabled = false;
            Console.WriteLine("rip the dream");
            SetFormText(defaultName);
            SetControlText(startButton, "Start");
            Console.WriteLine("Cursor position = X: " + Cursor.Position.X + ", Y: " + Cursor.Position.Y);
        }

        private void SetFormText(string text)
        {
            if (this.InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate () {
                    SetFormText(text);
                }));
            }
            else
            {
                this.Text = text;
            }
        }

        private void SetControlText(Control control, string text, Color color)
        {
            if (this.InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate () {
                    SetControlText(control, text, color);
                }));
            }
            else
            {
                control.Text = text;
                control.ForeColor = color;
            }
        }

        private void SetControlText(Control control, string text)
        {
            if (this.InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate () {
                    SetControlText(control, text);
                }));
            }
            else
            {
                control.Text = text;
            }
        }

        private void KekComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!active)
            {
                this.Text = "Autokek (" + currState + ")";
                startButton.Text = "Start";
                Console.WriteLine("changed text");
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Kek();
        }

        private void SetPreset(KekState state)
        {
            int start;
            int end;
            contentPanel.Controls.Clear();
            activeControl = null;
            switch (state)
            {
                case KekState.alching:
                    start = 900;
                    end = 1200;
                    break;
                case KekState.teleporting:
                    start = 1000;
                    end = 1200;
                    break;
                case KekState.nmz:
                    start = 45000;
                    end = 55000;
                    break;
                case KekState.thieving:
                    start = 300;
                    end = 600;
                    activeControl = new ThievingControl();
                    break;
                default:
                    start = 1000;
                    end = 1000;
                    break;
            }
            if (activeControl != null)
            {
                contentPanel.Controls.Add(activeControl);
                activeControl.Dock = DockStyle.Fill;
            }
            currState = state;
            rangeStartNumber.Value = start;
            rangeEndNumber.Value = end;
        }

        private void KekForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            kekTimer = new System.Timers.Timer((int)rangeStartNumber.Value);
            currState = KekState.none;
            this.FormClosing += KekForm_FormClosing;
        }

        private void KekForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            kekTimer.Enabled = false;
            Console.WriteLine("closed");
        }

        private void thievingButton_Click(object sender, EventArgs e)
        {
            SetPreset(KekState.thieving);
        }

        private void alchemyButton_Click(object sender, EventArgs e)
        {
            SetPreset(KekState.alching);
        }

        private void nmzButton_Click(object sender, EventArgs e)
        {
            SetPreset(KekState.nmz);
        }

        private void teleportButton_Click(object sender, EventArgs e)
        {
            SetPreset(KekState.teleporting);
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            //Screen.GetHealthLocation();
        }
    }
}

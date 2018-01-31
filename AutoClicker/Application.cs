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
        private KeyHandler keyHandler;
        private bool paused;
        private bool active;
        private enum KekState { alching, teleporting, nmz, none, thieving };
        private KekState currState;
        private const string defaultName = "Autokek";
        private HitpointsCapturer hitpointsCapturer;
        private Control activeControl;
        private Player player;
        private RunescapeWindow runescapeWindow;
        private System.Windows.Forms.Timer clickTimer;

        public Application()
        {
            InitializeComponent();
        }

        private void Application_Load(object sender, EventArgs e)
        {
            TimerControl.End += StopAutoClicker;
            FormClosing += Application_Close;
            player = new Player();
            clickTimer = new System.Windows.Forms.Timer();
            clickTimer.Interval = CalculateRandomInterval();
            clickTimer.Tick += ClickTimer_Tick;
            TryToConnectToRuneScape();
            keyHandler = new KeyHandler(Keys.Oemtilde, this);
            keyHandler.Register();
        }

        private void ClickTimer_Tick(object sender, EventArgs e)
        {
            Mouse.Click();
            clickTimer.Interval = CalculateRandomInterval();
        }

        private int CalculateRandomInterval()
        {
            Random random = new Random();
            return random.Next(Range.Start, Range.End);
        }



        private void StartAutoClicker()
        {
            active = true;
            TimerControl.Start();
            Range.Disable();
            StartButton.Visible = false;
            PausePanel.Visible = true;
            clickTimer.Start();
        }

        private void StopAutoClicker()
        {
            active = false;
            TimerControl.Stop();
            Range.Enable();
            StartButton.Visible = true;
            PausePanel.Visible = false;
            clickTimer.Stop();
        }

        private void TryToConnectToRuneScape()
        {
            runescapeWindow = new RunescapeWindow();
            if (runescapeWindow.IsActive())
            {
                player = new Player(runescapeWindow.GetUserName());
                AddUserNameToTitle();
                UpdateConnectedButtonToConnected();
            }
        }

        private void AddUserNameToTitle()
        {
            SetFormText(String.Format("{0} - {1}", defaultName, player.UserName));
        }

        private void UpdateConnectedButtonToConnected()
        {
            string connectedText = "RuneScape Connected";
            runescapeButton.Text = connectedText;
            runescapeButton.Enabled = false;
        }

        private void UpdateConnectedButtonToDisconnected()
        {
            string disconnectedText = "RuneScape Disconnected";
            runescapeButton.Text = disconnectedText;
            runescapeButton.Enabled = true;
        }

        /*private void GetPlayer()
        {
            if(window.IsRunescapeOpen())
            {
                player = new Player(window.GetUsername());
            }
            else
            {
                player = new Player();
            }
        }*/
       
        /*private void StartKek()
        {
            if (window.IsRunescapeOpen())
            {
                username = window.GetUsername();
                Hiscore playerHiscore = new Hiscore(username);
                int hitpoints = playerHiscore.GetHitpoints();
                //HitpointsCapturer hitpointsCapturer = new HitpointsCapturer(hitpoints);
         
                SetFormText(defaultName + "(" + currState + ") [" + username + "]");
            } else
            {

            }
            active = true;
            SetTimer();
            startTime = DateTime.Now;
            Console.WriteLine(currState);
            SetControlText(startButton, "Stop");
        }*/

        private void InitHPFont()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("runescape_small.ttf");
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Random random = new Random();
            clickTimer.Interval = random.Next(Range.Start, Range.End);
            switch (currState)
            {
                case KekState.thieving:
                    Thieve();
                    break;
                default:
                    Mouse.Click();
                    break;
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

        protected override void WndProc(ref Message m)
        {
            Console.WriteLine("hey");
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID)
            {
                TildePressed();
            }
            base.WndProc(ref m);
        }

        private void TildePressed()
        {
            if (!active)
            {
                StartAutoClicker();
            }
            else
            {
                StopAutoClicker();
            }
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

        private void startButton_Click(object sender, EventArgs e)
        {
            StartAutoClicker();
        }

        private void SetPreset(KekState state)
        {
            contentPanel.Controls.Clear();
            activeControl = null;
            switch (state)
            {
                case KekState.alching:
                    Range.Start = 900;
                    Range.End = 1200;
                    break;
                case KekState.teleporting:
                    Range.Start = 1000;
                    Range.End = 1200;
                    break;
                case KekState.nmz:
                    Range.Start = 45000;
                    Range.End = 55000;
                    break;
                case KekState.thieving:
                    Range.Start = 300;
                    Range.End = 600;
                    activeControl = new ThievingControl();
                    break;
                default:
                    Range.Start = 1000;
                    Range.End = 1000;
                    break;
            }
            if (activeControl != null)
            {
                contentPanel.Controls.Add(activeControl);
                activeControl.Dock = DockStyle.Fill;
            }
            currState = state;
        }

        private void Application_Close(object sender, FormClosingEventArgs e)
        {
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

        private void runescapeButton_Click(object sender, EventArgs e)
        {
            TryToConnectToRuneScape();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            StopAutoClicker();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            if (!paused)
            {
                Pause();
            }
            else
            {
                Resume();
            }
        }

        private void Pause()
        {
            paused = true;
            TimerControl.Pause();
        }

        private void Resume()
        {
            paused = false;
            TimerControl.Resume();
        }
    }
}

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

namespace AutoClicker
{
    public partial class Form1 : Form
    {
        private bool active;
        private System.Timers.Timer kekTimer;
        private enum state { alching, teleporting, nmz, none };
        private state currState;
        private int numClicks;
        private KeyHandler keyHandler;
        private bool alchDelay;
        private DateTime startTime;
        private BackgroundWorker backgroundWorker1;
        private const string defaultName = "Autokek";
        private enum alchemyState { ready, alch, javelin, wait };
        private alchemyState alchState;
        private HealthCapture healthCapture;

        public Form1()
        {
            InitializeComponent();
            keyHandler = new KeyHandler(Keys.Oemtilde, this);
            keyHandler.Register();
            backgroundWorker1 = new BackgroundWorker();
            alchState = alchemyState.alch;
        }

        public TimeSpan elapsed(DateTime start)
        {
            return DateTime.Now - start;
        }

        private void SetTimer()
        {
            kekTimer = new System.Timers.Timer();
            if (startupNumber.Value > 0) kekTimer.Interval = (int)startupNumber.Value;
            kekTimer.Elapsed += OnTimedEvent;
            kekTimer.AutoReset = true;
            kekTimer.Enabled = true;
        }

        private int timeLeft ()
        {
            return (int)durationNumber.Value - (int)elapsed(startTime).TotalSeconds;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            if (timeLeft() > 0 || durationNumber.Value == 0)
            {
                Random r = new Random();
                int nextKekTime = r.Next((int)rangeStartNumber.Value, (int)rangeEndNumber.Value);
                kekTimer.Interval = nextKekTime;
                Console.WriteLine("Kek");
                SetControlText(hpLabel, healthCapture.getHealth().ToString());
                switch (currState) {
                    case state.none:
                        //CaptureApplication();
                        break;
                }

                    /*var printscreen = new Bitmap(30, 30, PixelFormat.Format32bppArgb);
                    using (Graphics graphics = Graphics.FromImage(printscreen as Image))
                    {
                        graphics.CopyFromScreen(Cursor.Position.X - 10, Cursor.Position.Y - 10, 0, 0, printscreen.Size);
                        printscreen.Save(current, ImageFormat.Png);
                        if (!System.IO.File.Exists(alch))
                        {
                            printscreen.Save(alch, ImageFormat.Png);
                            Console.WriteLine("saved alch sample");
                        }
                        printscreen.Dispose();
                        Console.WriteLine("disposed");
                    }*/

                    /*if (clicks < 1)
                    {
                        aTimer.Interval = (range);
                        clicks++;
                    }
                    else
                    {
                        aTimer.Interval = (range * 3f);
                        clicks = 0;
                        Console.WriteLine("longclick");
                    }
                    Console.WriteLine("Interval: " + aTimer.Interval + "Click: " + clicks);*/

                    /*}
                    else if (currState == state.nmz)
                    {
                        if (clicks == 0)
                        {
                            aTimer.Interval = (400);
                            clicks++;
                        }
                        else
                        {
                            aTimer.Interval = (range);
                            clicks = 0;
                        }
                    }
                    else
                    {
                        aTimer.Interval = (range);
                    }
                    //DoMouseClick();
                    Console.WriteLine("Time left: " + timeLeft);*/
            }
        }

        private void HandleHotkey()
        {
            Kek();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID)
                HandleHotkey();
            base.WndProc(ref m);
        }

        private void Kek()
        {
            if (!active)
            {
                active = true;
                SetTimer();
                startTime = DateTime.Now;
                Console.WriteLine(currState);
                SetFormText(defaultName +  "(" + currState + ")");
                SetControlText(startButton, "Stop");
            }
            else
            {
                active = false;
                kekTimer.Enabled = false;
                Console.WriteLine("rip the dream");
                SetFormText(defaultName);
                SetControlText(startButton, "Start");
                alchState = alchemyState.alch;
                Console.WriteLine("Cursor position = X: " + Cursor.Position.X + ", Y: " + Cursor.Position.Y);
            }
            this.backgroundWorker1.RunWorkerAsync();
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

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (active)
            {

            }
            else
            {
                this.Text = "Autokek (" + currState + ")";
                startButton.Text = "Start";
            }
            Console.WriteLine("changed text");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Kek();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Preset("alch");
        }

        private void Preset(string preset)
        {
            int start = 1000;
            int end = 1000;
            switch (preset)
            {
                case "alch":
                    start = 900;
                    end = 1200;
                    currState = state.alching;
                    alchDelay = true;
                    Console.WriteLine("alch delay");
                    smartAlchCheck.CheckState = CheckState.Checked;
                    break;
                case "tele":
                    start = 1000;
                    end = 1200;
                    currState = state.teleporting;
                    alchDelay = false;
                    smartAlchCheck.CheckState = CheckState.Unchecked;
                    break;
                case "nmz":
                    start = 45000;
                    end = 55000;
                    currState = state.nmz;
                    alchDelay = false;
                    smartAlchCheck.CheckState = CheckState.Unchecked;
                    break;
            }
            rangeStartNumber.Value = start;
            rangeEndNumber.Value = end;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            kekTimer = new System.Timers.Timer((int)rangeStartNumber.Value);
            currState = state.none;
            this.FormClosing += Form1_FormClosing;
            this.healthCapture = new HealthCapture();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            kekTimer.Enabled = false;
            Console.WriteLine("closed");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Preset("alch");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Preset("tele");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!smartAlchCheck.Checked)
            {
                alchDelay = false;
                Console.WriteLine("off");
            }
            else
            {
                alchDelay = true;
                Console.WriteLine("alch delay");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Preset("nmz");
        }
    }
}

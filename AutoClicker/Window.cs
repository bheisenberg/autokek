using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Windows.Forms;

namespace AutoClicker
{
    public class Window
    {
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern int GetWindowTextLength(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern bool EnumWindows(EnumWindowsProc enumProc, IntPtr lParam);
        public delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);
        private const string runescapeWindowText = @"OSBuddy [A-Za-z]{3,5} - [a-zA-Z0-9_ ]+ \[([A-Za-z0-9_ ]{1,12})\]";
        public IntPtr RunescapeWindow { get; }
        public GameScreen gameScreen { get; }

        public Window ()
        {
            this.RunescapeWindow = GetRunescapeWindow();
            this.gameScreen = new GameScreen(this.RunescapeWindow);
        }

        public bool IsRunescapeOpen()
        {
            return RunescapeWindow != IntPtr.Zero;
        }

        private IntPtr GetRunescapeWindow()
        {
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                if (Regex.IsMatch(process.MainWindowTitle, runescapeWindowText))
                {
                    return process.MainWindowHandle;
                }
            }
            return IntPtr.Zero;
        }

        private bool IsWindowRunescape()
        {
            return Regex.IsMatch(GetActiveWindowTitle(), runescapeWindowText);
        }

        private string GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }

        public string GetUsername()
        {
            string title = GetActiveWindowTitle();
            Console.WriteLine(title);
            Match match = Regex.Match(title, runescapeWindowText);
            if (match.Success)
            {
                Console.WriteLine(match.Groups[1]);
            }
            return match.Groups[1].Value;
        }

        private IEnumerable<IntPtr> FindWindowsWithText(string titleText)
        {
            return FindWindows(delegate (IntPtr wnd, IntPtr param)
            {
                return GetWindowText(wnd).Contains(titleText);
            });
        }

        private string GetWindowText(IntPtr hWnd)
        {
            int size = GetWindowTextLength(hWnd);
            if (size > 0)
            {
                var builder = new StringBuilder(size + 1);
                GetWindowText(hWnd, builder, builder.Capacity);
                return builder.ToString();
            }

            return String.Empty;
        }

        private IEnumerable<IntPtr> FindWindows(EnumWindowsProc filter)
        {
            IntPtr found = IntPtr.Zero;
            List<IntPtr> windows = new List<IntPtr>();

            EnumWindows(delegate (IntPtr wnd, IntPtr param)
            {
                if (filter(wnd, param))
                {
                    windows.Add(wnd);
                }
                return true;
            }, IntPtr.Zero);
            return windows;
        }
    }
}

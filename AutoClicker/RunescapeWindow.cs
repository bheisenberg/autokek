using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Drawing;

namespace AutoClicker
{
    public class RunescapeWindow
    {
        #region DLLImports 
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern int GetWindowTextLength(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern bool EnumWindows(EnumWindowsProc enumProc, IntPtr lParam);
        public delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);
        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowRect(IntPtr hWnd, ref Rect rect);
        #endregion
        private Process runescape;
        private const string RUNESCAPE_WINDOW_PATTERN = @"OSBuddy [A-Za-z]{3,5} - [a-zA-Z0-9_ ]+ \[([A-Za-z0-9_ ]{1,12})\]";

        public RunescapeWindow()
        {
            runescape = WindowFunctions.GetProcessByPattern(RUNESCAPE_WINDOW_PATTERN);
        }

        public bool IsActive()
        {
            return runescape != null;
        }

        public string GetUserName()
        {
            if (IsActive())
            {
                Regex regex = new Regex(RUNESCAPE_WINDOW_PATTERN);
                return regex.Match(runescape.MainWindowTitle).Groups[1].Value;
            }
            else
            {
                return String.Empty;
            }
        }

        private Bitmap GetCurrentScreen()
        {
            if (IsActive())
            {
                var rect = new Rect();
                GetWindowRect(runescape.MainWindowHandle, ref rect);
                var bounds = new Rectangle(rect.left, rect.top, rect.right - rect.left, rect.bottom - rect.top);
                var result = new Bitmap(bounds.Width, bounds.Height);
                using (var graphics = Graphics.FromImage(result))
                {
                    graphics.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                }
                return result;
            }
            else
            {
                return new Bitmap(0, 0);
            }
        }
    }
}

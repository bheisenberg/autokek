using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Drawing;

namespace AutoClicker
{
    public static class GameScreen
    {
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowRect(IntPtr hWnd, ref Rect rect);
        [StructLayout(LayoutKind.Sequential)]
        public struct Rect
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        private static Bitmap CaptureApplication()
        {
            var rect = new Rect();
            GetWindowRect(GetForegroundWindow(), ref rect);
            var bounds = new Rectangle(rect.left, rect.top, rect.right - rect.left, rect.bottom - rect.top);
            var result = new Bitmap(20, 20);
            using (var graphics = Graphics.FromImage(result))
            {
                graphics.CopyFromScreen(new Point(bounds.Left + 525, bounds.Top + 85), Point.Empty, bounds.Size);
            }
            return result;
        }

        private static Bitmap CaptureLocation(int x, int y, int size)
        {
            var rect = new Rect();
            GetWindowRect(GetForegroundWindow(), ref rect);
            var bounds = new Rectangle(rect.left, rect.top, rect.right - rect.left, rect.bottom - rect.top);
            var result = new Bitmap(size, size);
            using (var graphics = Graphics.FromImage(result))
            {
                graphics.CopyFromScreen(new Point(bounds.Left + 525, bounds.Top + 85), Point.Empty, bounds.Size);
            }
            return result;
        }

        private static Bitmap CaptureFullScreen()
        {
            var rect = new Rect();
            GetWindowRect(GetForegroundWindow(), ref rect);
            var bounds = new Rectangle(rect.left, rect.top, rect.right - rect.left, rect.bottom - rect.top);
            var result = new Bitmap(bounds.Width, bounds.Height);
            using (var graphics = Graphics.FromImage(result))
            {
                graphics.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
            }
            return result;
        }
    }
}

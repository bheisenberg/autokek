using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Drawing;

namespace AutoClicker
{
    public class GameScreen
    {
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowRect(IntPtr hWnd, ref Rect rect);
        public IntPtr runescapeWindow;
        private Rectangle screenBounds;

        public GameScreen(IntPtr runescapeWindow)
        {
            this.runescapeWindow = runescapeWindow;
            this.screenBounds = GetScreenBounds();
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Rect
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        public Bitmap CaptureGameScreen()
        {
            var result = new Bitmap(screenBounds.Width, screenBounds.Height);
            using (var graphics = Graphics.FromImage(result))
            {
                graphics.CopyFromScreen(new Point(screenBounds.Left, screenBounds.Top), Point.Empty, screenBounds.Size);
            }
            return result;
        }

        private Rectangle GetScreenBounds()
        {
            var rect = new Rect();
            GetWindowRect(runescapeWindow, ref rect);
            return new Rectangle(rect.left, rect.top, rect.right - rect.left, rect.bottom - rect.top);
        }

        private Bitmap CaptureApplication()
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

        private Bitmap CaptureLocation(int x, int y, int size)
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

        public void FindPixel(Color correctPixel)
        {
            /*Bitmap screen = gameScreen.CaptureGameScreen();
            Color currentPixel = screen.GetPixel(0, 0);
            int x = 0;
            int y = 0;
            while (currentPixel != correctPixel)
            {
                if (x < screen.Width)
                {
                    currentPixel = screen.GetPixel(x, y);
                    x++;
                }
                else if (x >= screen.Width)
                {
                    x = 0;
                    y++;
                }
            }
            Console.WriteLine("found!");*/
        }
    }
}

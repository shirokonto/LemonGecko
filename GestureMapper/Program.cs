using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using GestureRecognition;
using System.Runtime.InteropServices;

namespace GestureMapper
{
    class Program
    {
        private LeapListener listener;

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {            
            Program program = new Program();
        }

        public Program()
        {
            listener = new LeapListener();
            while (Properties.Settings.Default.Running)
            {
                if (Properties.Settings.Default.Active)
                {
                    listener.HandSwipeDetected += HandleHandSwipe;
                    listener.CircleDetected += HandleCircle;
                    listener.ScreenTapDetected += HandleScreenTap;
                }
                while (Properties.Settings.Default.Active)
                {
                    Thread.Sleep(500); //idle
                }
                listener.HandSwipeDetected += HandleHandSwipe;
                listener.ScreenTapDetected += HandleScreenTap;

                //TODO: add others?
            }            
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

        private void HandleCircle(object sender, GestureRecognition.Events.CircleEvent circleEvent)
        {
            Console.WriteLine("Circle event received");
        }

        private static void HandleHandSwipe(object sender, GestureRecognition.Events.HandSwipeEvent handSwipeEvent)
        {
            Console.WriteLine("Hand Swipe event received");
            if (handSwipeEvent.Swipe.Direction.Equals(GestureRecognition.Gestures.HandSwipe.SwipeDirection.RIGHT))
            {
                Console.WriteLine("Next");
                SendKeys.SendWait("{TAB}");
            } else if (handSwipeEvent.Swipe.Direction.Equals(GestureRecognition.Gestures.HandSwipe.SwipeDirection.LEFT))
            {
                Console.WriteLine("Previous");
                //+ is shift
                SendKeys.SendWait("+{TAB}");
            }
        }

        private void HandleScreenTap(object sender, GestureRecognition.Events.ScreenTapEvent screenTapEvent)
        {
            Console.WriteLine("Screen Tap event received");
        }
    }
}

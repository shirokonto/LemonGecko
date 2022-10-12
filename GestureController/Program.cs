using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LeapMotionGestureMapper;
using System.Runtime.InteropServices;

namespace GestureController
{
    class Program
    {
        private LeapListener gestureMapper;

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
            gestureMapper = new LeapListener();
            while (Properties.Settings.Default.Running)
            {
                if (Properties.Settings.Default.Active)
                {
                    gestureMapper.HandSwipeDetected += HandleHandSwipe;
                }
                while (Properties.Settings.Default.Active)
                {
                    System.Threading.Thread.Sleep(500); //idle
                }

                gestureMapper.HandSwipeDetected += HandleHandSwipe;
            }            
        }

        private void ThisAddIn_StartUp(object sender, EventArgs e)
        {

            //begin tracking
            //Application.SlideShowBegin +=
            //new PowerPoint.EApplication_SlideShowBeginEventHandler(TrackingStart);

            //end tracking
            //Application.SlideShowEnd +=
            //  new PowerPoint.EApplication_SlideShowEndEventHandler(SlideShowEnd);
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

        private void HandleCircle(object sender, LeapMotionGestureMapper.Events.CircleEvent circleEvent)
        {
            Console.WriteLine("Circle event received");
            Thread.CurrentThread.SetApartmentState(ApartmentState.STA); //allows access to UI
        }

        private static void HandleHandSwipe(object sender, LeapMotionGestureMapper.Events.HandSwipeEvent handSwipeEvent)
        {
            //get current foreground app
            //navigate to previous or next object

            Console.WriteLine("Hand swipe event received");
            Thread.CurrentThread.SetApartmentState(ApartmentState.STA); //allows access to UI
            if (handSwipeEvent.Swipe.Direction.Equals(LeapMotionGestureMapper.Gestures.HandSwipe.SwipeDirection.RIGHT))
            {
                Console.WriteLine("Next");
                SendKeys.SendWait("{RIGHT}");
            } else if (handSwipeEvent.Swipe.Direction.Equals(LeapMotionGestureMapper.Gestures.HandSwipe.SwipeDirection.LEFT))
            {
                Console.WriteLine("Previous");
                SendKeys.SendWait("{LEFT}");
            }
        }
    }
}

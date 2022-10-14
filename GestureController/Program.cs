using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
                    gestureMapper.CircleDetected += HandleCircle;
                    gestureMapper.FingerSwipeDetected += HandleFingerSwipe;
                    gestureMapper.ScreenTapDetected += HandleScreenTap;
                    gestureMapper.ZoomInDetected += HandleZoomIn;
                    gestureMapper.ZoomOutDetected += HandleZoomOut;
                }
                while (Properties.Settings.Default.Active)
                {
                    Thread.Sleep(500); //idle
                }
                gestureMapper.HandSwipeDetected += HandleHandSwipe;
                gestureMapper.ScreenTapDetected += HandleScreenTap;

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

        private void HandleCircle(object sender, LeapMotionGestureMapper.Events.CircleEvent circleEvent)
        {
            Console.WriteLine("Circle event received");
        }

        private static void HandleHandSwipe(object sender, LeapMotionGestureMapper.Events.HandSwipeEvent handSwipeEvent)
        {
            Console.WriteLine("Hand Swipe event received");
            if (handSwipeEvent.Swipe.Direction.Equals(LeapMotionGestureMapper.Gestures.HandSwipe.SwipeDirection.RIGHT))
            {
                Console.WriteLine("Next");
                SendKeys.SendWait("{TAB}");
            } else if (handSwipeEvent.Swipe.Direction.Equals(LeapMotionGestureMapper.Gestures.HandSwipe.SwipeDirection.LEFT))
            {
                Console.WriteLine("Previous");
                //+ is shift
                SendKeys.SendWait("+{TAB}");
            }
        }

        private void HandleFingerSwipe(object sender, LeapMotionGestureMapper.Events.FingerSwipeEvent fingerSwipeEvent)
        {
            Console.WriteLine("Finger Swipe event received");
        }

        private void HandleScreenTap(object sender, LeapMotionGestureMapper.Events.ScreenTapEvent screenTapEvent)
        {
            Console.WriteLine("Screen Tap event received");
            bool bo = screenTapEvent.ScreenTap.Hands[0].IsRight;
            //" " i space key
            Keys key = Keys.Space;
            //SendKeys.SendWait("{SPACE}");
        }

        private void HandleZoomIn(object sender, LeapMotionGestureMapper.Events.ZoomInEvent zoomInEvent)
        {
            Console.WriteLine("Zoom In event received");
        }

        private void HandleZoomOut(object sender, LeapMotionGestureMapper.Events.ZoomOutEvent zoomOutEvent)
        {
            Console.WriteLine("Zoom Out event received");
        }
    }
}

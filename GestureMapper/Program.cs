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

        private void HandleCircle(object sender, GestureRecognition.Events.CircleEvent circleEvent)
        {
            //Console.WriteLine("Circle event received");
        }

        private static void HandleHandSwipe(object sender, GestureRecognition.Events.HandSwipeEvent handSwipeEvent)
        {
            //Console.WriteLine("Hand Swipe event received");
            if (handSwipeEvent.Swipe.Direction.Equals(GestureRecognition.Gestures.HandSwipe.SwipeDirection.RIGHT))
            {
                //Console.WriteLine("Next");
            }
            else if (handSwipeEvent.Swipe.Direction.Equals(GestureRecognition.Gestures.HandSwipe.SwipeDirection.LEFT))
            {
                //Console.WriteLine("Previous");
            }
            else if (handSwipeEvent.Swipe.Direction.Equals(GestureRecognition.Gestures.HandSwipe.SwipeDirection.UP))
            {
                //Console.WriteLine("up");
            }
        }

        private void HandleScreenTap(object sender, GestureRecognition.Events.ScreenTapEvent screenTapEvent)
        {
            //Console.WriteLine("Screen Tap event received");
        }
    }
}

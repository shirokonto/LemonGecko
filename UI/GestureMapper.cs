using System;
using GestureRecognition;
using System.Windows.Forms;

namespace Launcher
{
    public class GestureMapper
    {
        private static LeapListener listener;
        private ScreenReaderItem currentScreenReader;

        // Constructor
        public GestureMapper()
        {
            listener = new LeapListener();
            listener.DisconnectDetected += HandleDisconnect;
        }

        public void SetCurrentScreenReader(ScreenReaderItem selectedScreenReader)
        {
            currentScreenReader = selectedScreenReader;
        }

        public bool GetControllerState()
        {
            return listener.IsControllerConnected();
        }

        public void StartGestureControl()
        {
            listener.CircleDetected += HandleCircle;
            listener.HandSwipeDetected += HandleHandSwipe;
            listener.ScreenTapDetected += HandleScreenTap;
            listener.FistDetected += HandleFist;
        }

        public void StopGestureControl()
        {
            listener.CircleDetected -= HandleCircle;
            listener.HandSwipeDetected -= HandleHandSwipe;
            listener.ScreenTapDetected -= HandleScreenTap;
            listener.FistDetected -= HandleFist;
        }

        /**
        * HANDLE EVENTS 
        */
        private void HandleDisconnect(object sender, GestureRecognition.Events.DisconnectEvent disconnect)
        {
            Console.WriteLine("Controller disconnected");

        }
        private void HandleCircle(object sender, GestureRecognition.Events.CircleEvent circleEvent)
        {
            Console.WriteLine("Circle event received");
            if (circleEvent.Circle.Pointable.Direction.AngleTo(circleEvent.Circle.Normal) <= Math.PI / 2)
            {
                //clockwise
                Console.WriteLine("Clockwise");
                SendKeys.SendWait(currentScreenReader.CircleClockwise);
            }
            else
            {
                //counter clockwise
                Console.WriteLine("Counter Clockwise");
                SendKeys.SendWait(currentScreenReader.CircleCounterClockwise);
            }
        }

        private void HandleHandSwipe(object sender, GestureRecognition.Events.HandSwipeEvent handSwipeEvent)
        {
            Console.WriteLine("Hand Swipe event received");

            if (handSwipeEvent.Swipe.Direction.Equals(GestureRecognition.Gestures.HandSwipe.SwipeDirection.RIGHT))
            {
                Console.WriteLine("Next");
                SendKeys.SendWait(currentScreenReader.HandSwipeRight);
            }
            else if (handSwipeEvent.Swipe.Direction.Equals(GestureRecognition.Gestures.HandSwipe.SwipeDirection.LEFT))
            {
                Console.WriteLine("Previous");
                //+ is shift
                SendKeys.SendWait(currentScreenReader.HandSwipeLeft);
            }
            else if (handSwipeEvent.Swipe.Direction.Equals(GestureRecognition.Gestures.HandSwipe.SwipeDirection.UP))
            {
                Console.WriteLine("UP");
                SendKeys.SendWait(currentScreenReader.HandSwipeUp);
            }
            else
            {
                Console.WriteLine("DOWN");
                SendKeys.SendWait(currentScreenReader.HandSwipeDown);
            }
        }

        private void HandleScreenTap(object sender, GestureRecognition.Events.ScreenTapEvent screenTapEvent)
        {
            Console.WriteLine("Screen Tap event received");
            SendKeys.SendWait(currentScreenReader.ScreenTap);
        }

        private void HandleFist(object sender, GestureRecognition.Events.FistEvent fistEvent)
        {
            Console.WriteLine("Fist event received");
            SendKeys.SendWait(currentScreenReader.Fist);
        }
    }
}

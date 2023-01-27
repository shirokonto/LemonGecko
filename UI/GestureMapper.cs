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
            listener.PunchDetected += HandlePunch;
        }

        public void StopGestureControl()
        {
            listener.CircleDetected -= HandleCircle;
            listener.HandSwipeDetected -= HandleHandSwipe;
            listener.ScreenTapDetected -= HandleScreenTap;
            listener.PunchDetected -= HandlePunch;
        }

        /**
        * HANDLE EVENTS 
        */
        private void HandleCircle(object sender, GestureRecognition.Events.CircleEvent circleEvent)
        {
            listener.Print("Circle event received");
            if (circleEvent.Circle.Pointable.Direction.AngleTo(circleEvent.Circle.Normal) <= Math.PI / 2)
            {
                //clockwise
                listener.Print("Clockwise");
                SendKeys.SendWait(currentScreenReader.CircleClockwise);
            }
            else
            {
                //counter clockwise
                listener.Print("Counter Clockwise");
                SendKeys.SendWait(currentScreenReader.CircleCounterClockwise);
            }
        }

        private void HandleHandSwipe(object sender, GestureRecognition.Events.HandSwipeEvent handSwipeEvent)
        {
            listener.Print("Hand Swipe event received");

            if (handSwipeEvent.Swipe.Direction.Equals(GestureRecognition.Gestures.HandSwipe.SwipeDirection.RIGHT))
            {
                listener.Print("Next");
                SendKeys.SendWait(currentScreenReader.HandSwipeRight);
            }
            else if (handSwipeEvent.Swipe.Direction.Equals(GestureRecognition.Gestures.HandSwipe.SwipeDirection.LEFT))
            {
                listener.Print("Previous");
                //+ is shift
                SendKeys.SendWait(currentScreenReader.HandSwipeLeft);
            }
            else if (handSwipeEvent.Swipe.Direction.Equals(GestureRecognition.Gestures.HandSwipe.SwipeDirection.UP))
            {
                listener.Print("UP");
                SendKeys.SendWait(currentScreenReader.HandSwipeUp);
            }
            else
            {
                listener.Print("DOWN");
                SendKeys.SendWait(currentScreenReader.HandSwipeDown);
            }
        }

        private void HandleScreenTap(object sender, GestureRecognition.Events.ScreenTapEvent screenTapEvent)
        {
            listener.Print("Screen Tap event received");
            SendKeys.SendWait(currentScreenReader.ScreenTap);
        }

        private void HandlePunch(object sender, GestureRecognition.Events.PunchEvent fistEvent)
        {
            listener.Print("Punch event received");
            SendKeys.SendWait(currentScreenReader.Punch);
        }
    }
}

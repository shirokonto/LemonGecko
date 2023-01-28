using GestureRecognition;
using System;
using System.Windows.Forms;

namespace Launcher
{
    /// <summary>
    /// The class <c>GestureMapper</c> handles the received gesture events from the <see cref="LeapListener"/> and simulates the assigned shortcut for the given screenreader.
    /// </summary>
    public class GestureMapper
    {
        private static LeapListener listener;
        private ScreenReaderItem currentScreenReader;

        /// <summary>
        /// Constructs a new <c>GestureMapper</c> object.
        /// </summary>
        public GestureMapper()
        {
            listener = new LeapListener();
        }

        /// <summary>
        /// Sets the current screenreader from which the shortcuts will be mapped.
        /// </summary>
        /// <param name="selectedScreenReader">The currently active screenreader</param>
        public void SetCurrentScreenReader(ScreenReaderItem selectedScreenReader)
        {
            currentScreenReader = selectedScreenReader;
        }

        /// <summary>
        /// Retrieves the current state of the Controller object.
        /// </summary>
        /// <returns>True, if the controller is connected.</returns>
        public bool GetControllerState()
        {
            return listener.IsControllerConnected();
        }

        /// <summary>
        /// Starts the gesture control and subscribe to the gesture events.
        /// </summary>
        public void StartGestureControl()
        {
            listener.CircleDetected += HandleCircle;
            listener.HandSwipeDetected += HandleHandSwipe;
            listener.ScreenTapDetected += HandleScreenTap;
            listener.PunchDetected += HandlePunch;
        }

        /// <summary>
        /// Stops the gesture control and unsubscribe from the gesture events.
        /// </summary>
        public void StopGestureControl()
        {
            listener.CircleDetected -= HandleCircle;
            listener.HandSwipeDetected -= HandleHandSwipe;
            listener.ScreenTapDetected -= HandleScreenTap;
            listener.PunchDetected -= HandlePunch;
        }

        /// <summary>
        /// Handles the circle event, when a circle gesture in in one of the both directions gesture is detected 
        /// and sends the assigned keystrokes to the active application.
        /// </summary>
        /// <param name="sender">The LeapListener object invoking the event</param>
        /// <param name="circleEvent">The circle event containing the Circle gesture data</param>
        private void HandleCircle(object sender, GestureRecognition.Events.CircleEvent circleEvent)
        {
            if (circleEvent.Circle.Pointable.Direction.AngleTo(circleEvent.Circle.Normal) <= Math.PI / 2)
            {
                SendKeys.SendWait(currentScreenReader.CircleClockwise);
            }
            else
            {
                SendKeys.SendWait(currentScreenReader.CircleCounterClockwise);
            }
        }

        /// <summary>
        /// Handles the handSwipe event, when a handswipe in one of the four directions gesture is detected 
        /// and sends the assigned keystrokes to the active application.
        /// </summary>
        /// <param name="sender">The LeapListener object invoking the event</param>
        /// <param name="handSwipeEvent">The handSwipe event containing the HandSwipe gesture data</param>
        private void HandleHandSwipe(object sender, GestureRecognition.Events.HandSwipeEvent handSwipeEvent)
        {
            if (handSwipeEvent.HandSwipe.Direction.Equals(GestureRecognition.Gestures.HandSwipe.SwipeDirection.RIGHT))
            {
                SendKeys.SendWait(currentScreenReader.HandSwipeRight);
            }
            else if (handSwipeEvent.HandSwipe.Direction.Equals(GestureRecognition.Gestures.HandSwipe.SwipeDirection.LEFT))
            {
                SendKeys.SendWait(currentScreenReader.HandSwipeLeft);
            }
            else if (handSwipeEvent.HandSwipe.Direction.Equals(GestureRecognition.Gestures.HandSwipe.SwipeDirection.UP))
            {
                SendKeys.SendWait(currentScreenReader.HandSwipeUp);
            }
            else
            {
                SendKeys.SendWait(currentScreenReader.HandSwipeDown);
            }
        }

        /// <summary>
        /// Handles the screenTap event, when a screenTap gesture is detected 
        /// and sends the assigned keystrokes to the active application.
        /// </summary>
        /// <param name="sender">The LeapListener object invoking the event</param>
        /// <param name="screenTapEvent">The screenTap event containing the ScreenTap gesture data</param>
        private void HandleScreenTap(object sender, GestureRecognition.Events.ScreenTapEvent screenTapEvent)
        {
            SendKeys.SendWait(currentScreenReader.ScreenTap);
        }

        /// <summary>
        /// Handles the screenTap event, when a punch gesture is detected 
        /// and sends the assigned keystrokes to the active application.
        /// </summary>
        /// <param name="sender">The LeapListener object invoking the event</param>
        /// <param name="punchEvent">The punch event containing the Punch gesture data</param>
        private void HandlePunch(object sender, GestureRecognition.Events.PunchEvent punchEvent)
        {
            SendKeys.SendWait(currentScreenReader.Punch);
        }
    }
}

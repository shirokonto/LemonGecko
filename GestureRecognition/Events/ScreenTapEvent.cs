using System;
using Leap;

namespace GestureRecognition.Events
{
    /// <summary>
    /// The class <c>ScreenTapEvent</c> represents the event data for the ScreenTap gesture, which is recognized by the Leap Motion Controller. The code is taken from the repository
    /// <see cref="https://github.com/Ben-Floyd/LeapMotionGestureControl/blob/master/GestureMap/Events/ScreenTapEvent.cs"/>
    /// </summary>
    public class ScreenTapEvent : EventArgs
    {
        private ScreenTapGesture _screenTap;

        /// <summary>
        /// This constructor initializes a new <c>ScreenTapEvent</c> with the screenTap gesture.
        /// </summary>
        /// <param name="screenTap"> The screenTap gesture</param>.
        public ScreenTapEvent(ScreenTapGesture screenTap)
        {
            _screenTap = screenTap;
        }

        /// <summary>
        /// Gets and sets the ScreenTap property.
        /// </summary>
        public ScreenTapGesture ScreenTap
        {
            get { return _screenTap; }
            set { _screenTap = value; }
        }
    }
}

using Leap;
using System;

namespace GestureRecognition.Events
{
    /// <summary>
    /// The class <c>CircleEvent</c> represents the event data for the Circle gesture, which is recognized by the Leap Motion Controller. The code is taken from the repository
    /// <see cref="https://github.com/Ben-Floyd/LeapMotionGestureControl/blob/master/GestureMap/Events/CircleEvent.cs"/>
    /// </summary>
    public class CircleEvent : EventArgs
    {
        private CircleGesture _circle;

        /// <summary>
        /// This constructor initializes a new <c>CircleEvent</c> with the 
        /// circle gesture.
        /// </summary>
        /// <param name="circle"> The circle gesture</param>.
        public CircleEvent(CircleGesture circle)
        {
            _circle = circle;
        }

        /// <summary>
        /// Gets and sets the circle gesture property.
        /// </summary>
        public CircleGesture Circle
        {
            get { return _circle; }
            set { _circle = value; }
        }
    }
}

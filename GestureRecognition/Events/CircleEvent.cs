using System;
using Leap;

namespace GestureRecognition.Events
{
    public class CircleEvent : EventArgs
    {
        private CircleGesture _circle;

        public CircleEvent(CircleGesture circle)
        {
            _circle = circle;
        }

        public CircleGesture Circle
        {
            get { return _circle; }
            set { _circle = value; }
        }
       
    }
}

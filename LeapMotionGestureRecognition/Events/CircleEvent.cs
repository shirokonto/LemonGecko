using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leap;

namespace LeapMotionGestureMapper.Events
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapMotionGestureMapper.Events
{
    public class HandSwipeEvent : EventArgs
    {
        private Gestures.HandSwipe _swipe;

        public HandSwipeEvent(Gestures.HandSwipe swipe)
        {
            _swipe = swipe;
        }

        public Gestures.HandSwipe Swipe
        {
            get { return _swipe; }
            set { _swipe = value; }
        }
    }
}

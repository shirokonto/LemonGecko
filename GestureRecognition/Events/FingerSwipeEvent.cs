using System;
using Leap;

namespace GestureRecognition.Events
{
    public class FingerSwipeEvent : EventArgs
    {
        private SwipeGesture _swipe;

        public FingerSwipeEvent(SwipeGesture swipe)
        {
            _swipe = swipe;
        }

        public SwipeGesture Swipe
        {
            get { return _swipe; }
            set { _swipe = value; }
        }
    }
}

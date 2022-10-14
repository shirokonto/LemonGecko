using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestureRecognition.Events
{
    public class FingerSwipeEvent : EventArgs
    {
        private Leap.SwipeGesture _swipe;

        public FingerSwipeEvent(Leap.SwipeGesture swipe)
        {
            _swipe = swipe;
        }

        public Leap.SwipeGesture Swipe
        {
            get { return _swipe; }
            set { _swipe = value; }
        }
    }
}

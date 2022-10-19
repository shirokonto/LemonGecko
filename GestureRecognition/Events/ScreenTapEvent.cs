using System;
using Leap;

namespace GestureRecognition.Events
{
    public class ScreenTapEvent : EventArgs
    {
        private ScreenTapGesture _screenTap;

        public ScreenTapEvent(ScreenTapGesture screenTap)
        {
            _screenTap = screenTap;
        }

        public ScreenTapGesture ScreenTap
        {
            get { return _screenTap; }
            set { _screenTap = value; }
        }
    }
}

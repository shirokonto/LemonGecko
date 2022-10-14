using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestureRecognition.Events
{
    public class ScreenTapEvent : EventArgs
    {
        private Leap.ScreenTapGesture _screenTap;

        public ScreenTapEvent(Leap.ScreenTapGesture screenTap)
        {
            _screenTap = screenTap;
        }

        public Leap.ScreenTapGesture ScreenTap
        {
            get { return _screenTap; }
            set { _screenTap = value; }
        }
    }
}

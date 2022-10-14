using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapMotionGestureMapper.Events
{
    public class ZoomOutEvent : EventArgs
    {
        private Gestures.ZoomOut _zoomOut;

        public ZoomOutEvent(Gestures.ZoomOut zoomOut)
        {
            _zoomOut = zoomOut;
        }

        public Gestures.ZoomOut ZoomOut
        {
            get { return _zoomOut; }
            set { _zoomOut = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapMotionGestureMapper.Events
{
    public class ZoomInEvent : EventArgs
    {
        private Gestures.ZoomIn _zoomIn;

        public ZoomInEvent(Gestures.ZoomIn zoomIn)
        {
            _zoomIn = zoomIn;
        }

        public Gestures.ZoomIn ZoomIn
        {
            get { return _zoomIn; }
            set { _zoomIn = value; }
        }
    }
}

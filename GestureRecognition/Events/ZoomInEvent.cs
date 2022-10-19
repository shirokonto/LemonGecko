using System;

namespace GestureRecognition.Events
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

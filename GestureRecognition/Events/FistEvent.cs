using System;

namespace GestureRecognition.Events
{
    public class FistEvent : EventArgs
    {
        private Gestures.Fist _fist;

        public FistEvent(Gestures.Fist fist)
        {
            _fist = fist;
        }

        public Gestures.Fist Fist
        {
            get { return _fist; }
            set { _fist = value; }
        }
    }
}

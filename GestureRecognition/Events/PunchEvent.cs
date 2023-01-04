using System;

namespace GestureRecognition.Events
{
    public class PunchEvent : EventArgs
    {
        private Gestures.Punch _punch;

        public PunchEvent(Gestures.Punch fist)
        {
            _punch = fist;
        }

        public Gestures.Punch Punch
        {
            get { return _punch; }
            set { _punch = value; }
        }
    }
}

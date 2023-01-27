using System;

namespace GestureRecognition.Events
{
    /// <summary>
    /// The class <c>PunchEvent</c> represents the event data for the Punch gesture.
    /// </summary>
    public class PunchEvent : EventArgs
    {
        private Gestures.Punch _punch;

        /// <summary>
        /// This constructor initializes a new <c>PunchEvent</c> with the punch gesture.
        /// </summary>
        /// <param name="punch"> The punch gesture</param>.
        public PunchEvent(Gestures.Punch punch)
        {
            _punch = punch;
        }

        /// <summary>
        /// Gets and sets the Punch property.
        /// </summary>
        public Gestures.Punch Punch
        {
            get { return _punch; }
            set { _punch = value; }
        }
    }
}

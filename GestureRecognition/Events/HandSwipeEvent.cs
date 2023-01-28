using System;

namespace GestureRecognition.Events
{
    /// <summary>
    /// The class <c>HandSwipeEvent</c> represents the event data for the HandSwipe gesture. In a modified form the code is taken from the repository
    /// <see cref="https://github.com/Ben-Floyd/LeapMotionGestureControl/blob/master/GestureMap/Events/HandSwipeEvent.cs"/>
    /// </summary>
    public class HandSwipeEvent : EventArgs
    {
        private Gestures.HandSwipe _handSwipe;

        /// <summary>
        /// This constructor initializes a new <c>HandSwipeEvent</c> with the handSwipe gesture.
        /// </summary>
        /// <param name="handSwipe"> The handswipe gesture</param>.
        public HandSwipeEvent(Gestures.HandSwipe handSwipe)
        {
            _handSwipe = handSwipe;
        }

        /// <summary>
        /// Gets and sets the HandSwipe property.
        /// </summary>
        public Gestures.HandSwipe HandSwipe
        {
            get { return _handSwipe; }
            set { _handSwipe = value; }
        }
    }
}

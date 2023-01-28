using Leap;

namespace GestureRecognition.Gestures
{
    /// <summary>Represents the supported types of the custom gestures.</summary>
    public enum CustomGestureType
    {
        /// <summary>A straight line movement by the hand.</summary>
        HAND_SWIPE,
        /// <summary>A forward punch movement by the hand.</summary>
        PUNCH
    };

    /// <summary>Represents the possible values of the state of the custom gestures.</summary>
    public enum GestureState
    {
        /// <summary>An invalid state.</summary>
        NA,
        /// <summary>The gesture is starting.</summary>
        START,
        /// <summary>The gesture is in progress.</summary>
        MIDDLE,
        /// <summary>The gesture has completed.</summary>
        END
    };

    /// <summary>
    /// The class <c>CustomGesture</c> represents the base class for the derived custom gestures. In a modified form the code is taken from the repository
    /// <see cref="https://github.com/Ben-Floyd/LeapMotionGestureControl/blob/master/GestureMap/Gestures/CustomGesture.cs"/>
    /// </summary>
    public class CustomGesture
    {
        protected CustomGestureType _type;
        protected HandList _handsForGesture;
        protected GestureState _state;

        /// <summary>
        /// Constructs a <c>CustomGesture</c> with the type of the custom gesture and frame.
        /// Used as base constructor for the derived custom gestures. 
        /// </summary>
        /// <param name="type"> Type of the custom gesture</param>
        /// <param name="frame"> Frame in which a movement was recognized</param>
        public CustomGesture(CustomGestureType type, Frame frame)
        {
            _type = type;
            _handsForGesture = frame.Hands;
            _state = GestureState.NA;
        }

        /// <summary>Gets the CustomGestureType property.</summary>
        public CustomGestureType Type
        {
            get { return _type; }
        }

        /// <summary>Gets the GestureState property.</summary>
        public GestureState State
        {
            get { return _state; }
        }

        /// <summary>Gets the HandList property.</summary>
        public HandList Hands
        {
            get { return _handsForGesture; }
        }

    }
}

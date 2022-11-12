using System;
using Leap;

namespace GestureRecognition.Gestures
{
    public enum CustomGestureType { HAND_SWIPE, FIST, OPEN_FIST, THUMBS_UP };
    public enum GestureState { NA, START, MIDDLE, END };
    public class CustomGesture
    {
        protected CustomGestureType _type;
        protected HandList _handsForGesture;
        protected PointableList _pointablesForGesture;
        protected GestureState _state;

        public CustomGesture(CustomGestureType type, Frame frame)
        {
            _type = type;
            _handsForGesture = frame.Hands;
            _pointablesForGesture = frame.Pointables;
            _state = GestureState.NA;
        }

        public CustomGestureType Type
        {
            get { return _type; }
        }

        public GestureState State
        {
            get { return _state; }
        }

        public HandList Hands
        {
            get { return _handsForGesture; }
        }

        public PointableList Pointables
        {
            get { return _pointablesForGesture; }
        }
    }
}

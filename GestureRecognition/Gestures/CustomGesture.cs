﻿using Leap;

namespace GestureRecognition.Gestures
{
    public enum CustomGestureType { HAND_SWIPE, PUNCH };
    public enum GestureState { NA, START, MIDDLE, END };
    public class CustomGesture
    {
        protected CustomGestureType _type;
        protected HandList _handsForGesture;
        protected GestureState _state;

        public CustomGesture(CustomGestureType type, Frame frame)
        {
            _type = type;
            _handsForGesture = frame.Hands;
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

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestureRecognition.Gestures
{
    public enum CustomGestureType { HAND_SWIPE, ZOOM_IN, ZOOM_OUT };
    public enum GestureState { NA, START, MIDDLE, END };
    public class CustomGesture
    {
        protected CustomGestureType _type;
        protected Leap.HandList _handsForGesture;
        protected Leap.PointableList _pointablesForGesture;
        protected GestureState _state;

        public CustomGesture(CustomGestureType type, Leap.Frame frame)
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

        public Leap.HandList Hands
        {
            get { return _handsForGesture; }
        }

        public Leap.PointableList Pointables
        {
            get { return _pointablesForGesture; }
        }
    }
}

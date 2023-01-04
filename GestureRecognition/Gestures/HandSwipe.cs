using System;
using Leap;

namespace GestureRecognition.Gestures
{
    public class HandSwipe : CustomGesture
    {
        public enum SwipeDirection { LEFT, RIGHT, DOWN, UP };
        private SwipeDirection _direction;
        private static HandSwipe _swipe = null;

        public HandSwipe(CustomGestureType type, Frame frame) : base(type, frame)
        {
            if (_swipe != null) 
            {
                if (_swipe.State.Equals(GestureState.NA))
                {
                    _state = GestureState.START;
                }
                else if (_swipe.State.Equals(GestureState.END))
                {
                    _state = GestureState.NA;
                }
                else
                {
                    _state = GestureState.MIDDLE;
                }
            }

            _swipe = this;

            foreach (Hand hand in _handsForGesture)
            {
                float xVelocity = hand.PalmVelocity.x;                
                float yVelocity = hand.PalmVelocity.y;
                if (Math.Abs(xVelocity) > Math.Abs(yVelocity))
                {
                    if (hand.PalmVelocity.x > 0)
                        _direction = SwipeDirection.RIGHT;
                    else
                        _direction = SwipeDirection.LEFT;
                }
                else
                {
                    if (hand.PalmVelocity.y > 0)
                        _direction = SwipeDirection.UP;
                    else
                        _direction = SwipeDirection.DOWN;
                }
            }
        }

        public static HandSwipe IsHandSwipe(Frame frame)
        {
            if (frame.IsValid)
            {
                HandList hands = frame.Hands;
                Hand hand = hands[0];

                if ((hands[0].IsValid && hands[1].IsValid))
                {
                    return null;
                }

                if (Math.Abs(hand.PalmVelocity.x) > 900 || Math.Abs(hand.PalmVelocity.y) > 900)
                {
                    HandSwipe handSwipe = new HandSwipe(CustomGestureType.HAND_SWIPE, frame);
                    return handSwipe;
                }
                else if (_swipe != null)
                {
                    if (_swipe.State.Equals(GestureState.END) || _swipe.State.Equals(GestureState.NA))
                    {
                        _swipe._state = GestureState.NA;
                        return _swipe;
                    }
                    else
                    {
                        _swipe._state = GestureState.END;
                        return _swipe;
                    }
                }
            }
            return null;
        }

        public SwipeDirection Direction
        {
            get { return _direction; }
        }
    }
}

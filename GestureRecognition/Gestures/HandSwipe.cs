using Leap;
using System;

namespace GestureRecognition.Gestures
{
    /// <summary>
    /// The class <c>HandSwipe</c> represents a straight line movement by the hand. In a modified form the code is taken from the repository
    /// <see cref="https://github.com/Ben-Floyd/LeapMotionGestureControl/blob/master/GestureMap/Gestures/HandSwipe.cs"/>
    /// </summary>
    public class HandSwipe : CustomGesture
    {
        /// <summary>
        /// Represents the direction in which the hand moves.
        /// </summary>
        public enum SwipeDirection { LEFT, RIGHT, DOWN, UP };
        private SwipeDirection _direction;
        private static HandSwipe _handSwipe = null;

        /// <summary>
        /// Constructs a <c>HandSwipe</c>-Object with the custom gesture type
        /// and frame in which the gesture was recognized. Derived from the base constructor <see cref="CustomGesture.CustomGesture(CustomGestureType, Frame)"/>. 
        /// </summary>
        /// <param name="type"> Type of the custom gesture</param>
        /// <param name="frame"> Frame in which a movement was recognized</param>.
        public HandSwipe(CustomGestureType type, Frame frame) : base(type, frame)
        {
            if (_handSwipe != null)
            {
                if (_handSwipe.State.Equals(GestureState.NA))
                {
                    _state = GestureState.START;
                }
                else if (_handSwipe.State.Equals(GestureState.END))
                {
                    _state = GestureState.NA;
                }
                else
                {
                    _state = GestureState.MIDDLE;
                }
            }

            _handSwipe = this;

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

        /// <summary>
        /// Determines whether the hand gesture detected in the frame was a HandSwipe or not.
        /// </summary>
        /// <param name="frame">Frame in which a movement was recognized</param>
        /// <returns> The HandSwipe-Object or null</returns>
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
                else if (_handSwipe != null)
                {
                    if (_handSwipe.State.Equals(GestureState.END) || _handSwipe.State.Equals(GestureState.NA))
                    {
                        _handSwipe._state = GestureState.NA;
                        return _handSwipe;
                    }
                    else
                    {
                        _handSwipe._state = GestureState.END;
                        return _handSwipe;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Gets the SwipeDirection property.
        /// </summary>
        public SwipeDirection Direction
        {
            get { return _direction; }
        }
    }
}

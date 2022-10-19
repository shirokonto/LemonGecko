using System;
using Leap;

namespace GestureRecognition.Gestures
{
    public class HandSwipe : CustomGesture
    {
        public enum SwipeDirection { LEFT, RIGHT };
        private SwipeDirection _direction;
        private static HandSwipe other = null;

        public HandSwipe(CustomGestureType type, Frame frame)
            : base(type, frame)
        {
            if (other != null)
            {
                if (other.State.Equals(GestureState.NA))
                {
                    _state = GestureState.START;
                }
                else if (other.State.Equals(GestureState.END))
                {
                    _state = GestureState.NA;
                }
                else
                {
                    _state = GestureState.MIDDLE;
                }
            }

            other = this;

            foreach (Hand hand in _handsForGesture)
            {
                if (hand.PalmVelocity.x > 0)
                    _direction = SwipeDirection.RIGHT;
                else
                    _direction = SwipeDirection.LEFT;
            }
        }

        public static HandSwipe IsHandSwipe(Frame frame)
        {
            if (frame.IsValid)
            {
                HandList hands = frame.Hands;

                if ((hands[0].IsValid && hands[1].IsValid) && HandsTogether(hands[0], hands[1]))
                {
                    return null;
                }

                if (Math.Abs(hands.Frontmost.PalmVelocity.x) > 900)
                {
                    HandSwipe handSwipe = new HandSwipe(CustomGestureType.HAND_SWIPE, frame);
                    return handSwipe;
                }
                else if ((other != null))
                {
                    if (other.State.Equals(GestureState.END) || other.State.Equals(GestureState.NA))
                    {
                        other._state = GestureState.NA;
                        return other;
                    }
                    else
                    {
                        other._state = GestureState.END;
                        return other;
                    }
                }
            }

            return null;
        }

        public SwipeDirection Direction
        {
            get { return _direction; }
        }

        private static bool HandsTogether(Hand hand1, Hand hand2)
        {
            float xdiff = Math.Abs(hand1.PalmPosition.x - hand2.PalmPosition.x),
                ydiff = Math.Abs(hand1.PalmPosition.y - hand2.PalmPosition.y),
                zdiff = Math.Abs(hand1.PalmPosition.z - hand2.PalmPosition.z);

            if ((xdiff + ydiff + zdiff) < 400)
                return true;

            return false;
        }
    }
}

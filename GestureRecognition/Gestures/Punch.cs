using Leap;
using System;

namespace GestureRecognition.Gestures
{
    /// <summary>
    /// The class <c>Punch</c> represents a forward punch movement by the hand.
    /// </summary>
    public class Punch : CustomGesture
    {
        private static Punch _punch = null;

        /// <summary>
        /// Constructs a <c>Punch</c>-Object with the custom gesture type
        /// and frame in which the gesture was recognized. Derived from the base constructor <see cref="CustomGesture.CustomGesture(CustomGestureType, Frame)"/>. 
        /// </summary>
        /// <param name="type"> Type of the custom gesture</param>
        /// <param name="frame"> Frame in which a movement was recognized</param>.
        public Punch(CustomGestureType type, Frame frame) : base(type, frame)
        {
            if (_punch != null)
            {
                if (_punch.State.Equals(GestureState.NA))
                {
                    _state = GestureState.START;
                }
                else if (_punch.State.Equals(GestureState.END))
                {
                    _state = GestureState.NA;
                }
                else
                {
                    _state = GestureState.MIDDLE;
                }
            }
            _punch = this;
        }

        /// <summary>
        /// Determines whether the hand gesture detected in the frame was a Punch or not.
        /// </summary>
        /// <param name="frame">Frame in which a movement was recognized</param>
        /// <returns> The Punch-Object or null</returns>
        public static Punch IsPunch(Frame frame)
        {
            if (frame.IsValid)
            {
                HandList hands = frame.Hands;
                Hand hand = hands[0];
                double threshold = 253.0;
                double sumDistance = 0;
                Vector palmPositionVector = hand.PalmPosition;

                if (hand.IsValid && hands[1].IsValid)
                {
                    return null;
                }

                for (int i = 0; i < hand.Fingers.Count; i++)
                {
                    double distance = CalculateDistance(palmPositionVector, hand.Fingers[i].StabilizedTipPosition);
                    if (hand.Fingers[i].Type == Finger.FingerType.TYPE_INDEX && hand.Fingers[i].IsExtended)
                    {
                        return null;
                    }
                    sumDistance += distance;
                }
                if (sumDistance < threshold && hand.PalmVelocity.z > 400)
                {
                    Punch fist = new Punch(CustomGestureType.PUNCH, frame);
                    return fist;
                }
                else if (_punch != null)
                {
                    if (_punch.State.Equals(GestureState.END) || _punch.State.Equals(GestureState.NA))
                    {
                        _punch._state = GestureState.NA;
                        return _punch;
                    }
                    else
                    {
                        _punch._state = GestureState.END;
                        return _punch;
                    }
                }

            }
            return null;
        }

        /// <summary>
        /// Calculates the euclidean distance between the center position of the palm and the given fingertip position.
        /// </summary>
        /// <param name="palmPos">Center position of the palm from the leap motion origin</param>
        /// <param name="fingerTipPos">Fingertip position</param>
        /// <returns></returns>
        private static Double CalculateDistance(Vector palmPos, Vector fingerTipPos)
        {
            var distanceX = Math.Pow(fingerTipPos.x - palmPos.x, 2);
            var distanceY = Math.Pow(fingerTipPos.y - palmPos.y, 2);
            var distanceZ = Math.Pow(fingerTipPos.z - palmPos.z, 2);
            return Math.Sqrt(distanceX + distanceY + distanceZ);
        }
    }
}

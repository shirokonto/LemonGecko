using System;
using Leap;

namespace GestureRecognition.Gestures
{
    public class Punch : CustomGesture
    {
        private static Punch _punch = null;        

        public Punch(CustomGestureType type, Frame frame) : base(type, frame)
        {
            if(_punch != null) 
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

            //for each hand

        }

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
                    if(hand.Fingers[i].Type == Finger.FingerType.TYPE_INDEX && hand.Fingers[i].IsExtended)
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

        private static Double CalculateDistance(Vector palmPos, Vector fingerTipPos)
        {
            var distanceX = Math.Pow(fingerTipPos.x - palmPos.x, 2);
            var distanceY = Math.Pow(fingerTipPos.y - palmPos.y, 2);
            var distanceZ = Math.Pow(fingerTipPos.z - palmPos.z, 2);
            return Math.Sqrt(distanceX + distanceY + distanceZ);
        }
    }
}

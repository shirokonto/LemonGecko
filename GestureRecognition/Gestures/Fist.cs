using System;
using Leap;

namespace GestureRecognition.Gestures
{
    public class Fist : CustomGesture
    {
        private static Fist _fist = null;        

        public Fist(CustomGestureType type, Frame frame) : base(type, frame)
        {
            if(_fist != null){
                if (_fist.State.Equals(GestureState.NA))
                {
                    _state = GestureState.START;
                }
                else if (_fist.State.Equals(GestureState.END))
                {
                    _state = GestureState.NA;
                }
                else
                {
                    _state = GestureState.MIDDLE;
                }
            }
            _fist = this;
        }

        public static Fist IsFist(Frame frame)
        {
            if (frame.IsValid)
            {
                HandList hands = frame.Hands;
                Hand hand = hands[0];
                double threshold = 260.0;
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
                if (sumDistance < threshold)
                {
                    Fist fist = new Fist(CustomGestureType.FIST, frame);
                    return fist;
                }
                else if (_fist != null)
                {
                    if (_fist.State.Equals(GestureState.END) || _fist.State.Equals(GestureState.NA))
                    {
                        _fist._state = GestureState.NA;
                        return _fist;
                    }
                    else
                    {
                        _fist._state = GestureState.END;
                        return _fist;
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

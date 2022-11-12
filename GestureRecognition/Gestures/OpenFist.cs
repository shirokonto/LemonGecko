using System;
using Leap;
using System.Linq;

namespace GestureRecognition.Gestures
{
    public class OpenFist : CustomGesture
    {
        private static OpenFist openFist = null;

        public OpenFist(CustomGestureType type, Frame frame) : base(type, frame)
        {
            if(openFist != null){
                if (openFist.State.Equals(GestureState.NA))
                {
                    _state = GestureState.START;
                }
                else if (openFist.State.Equals(GestureState.END))
                {
                    _state = GestureState.NA;
                }
                else
                {
                    _state = GestureState.MIDDLE;
                }
            }
            openFist = this;
        }

        public static OpenFist IsOpenFist(Frame frame)
        {
            if (frame.IsValid)
            {
                HandList hands = frame.Hands;

                if(hands[0].IsValid && hands[1].IsValid)
                {
                    //if both hands are visible return null
                    return null;
                } else
                {
                    //I found a good solution using
                    //the distance between each finger and the palm.
                    //Calculate the sum of these distances and
                    //check whether it's below a certain threshold

                    //distance each finger and palm
                    Hand hand = hands[0];

                    Console.WriteLine("Hand palm position: " + hand.PalmPosition);
                    for (int i = 0; i < hand.Fingers.Count; i++)
                    {
                        Console.WriteLine(hand.Fingers[i].Type + " Finger position: " + hand.Fingers[i].StabilizedTipPosition);
                    }
                    /**
                     * Hand palm position: (-124.417, 232.431, 50.188)
                        TYPE_THUMB Finger position: (-119.711, 274.693, -3.0027)
                        TYPE_INDEX Finger position: (-108.636, 264.722, 0.0150562)
                        TYPE_MIDDLE Finger position: (-94.458, 253.752, 3.65136)
                        TYPE_RING Finger position: (-88.3429, 237.385, 4.70001)
                        TYPE_PINKY Finger position: (-110.396, 208.556, -12.7724)
                     */
                    
                }

            }
            return null;
        }
    }
}

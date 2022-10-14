using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapMotionGestureMapper.Gestures
{
    public class ZoomOut : CustomGesture
    {
        private static ZoomOut other = null;

        public ZoomOut(CustomGestureType type, Leap.Frame frame)
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
        }

        public static ZoomOut IsZoomOut(Leap.Frame frame)
        {
            if (frame.IsValid)
            {
                Leap.HandList hands = frame.Hands;

                if ((hands[0].IsValid && hands[1].IsValid) && handsTogether(hands[0], hands[1]))
                {
                    if ((hands.Leftmost.PalmVelocity.x < 500) && (hands.Rightmost.PalmVelocity.x > -500))
                    {
                        ZoomOut zoomOut = new ZoomOut(CustomGestureType.ZOOM_OUT, frame);
                        return zoomOut;
                    }
                    else if (other != null)
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
            }

            return null;
        }

        private static bool handsTogether(Leap.Hand hand1, Leap.Hand hand2)
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

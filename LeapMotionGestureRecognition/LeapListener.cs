using Leap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapMotionGestureRecognition
{
    public class LeapListener : Listener
    {
        //fields
        private GestureList gestures = null;
        private HandList hands = null;
        private Vector pointerPosition = null;
        private Object thisLock = new Object();


        //constructor
        public LeapListener()
        {
        }

        

        private void SafeWriteLine(String line)
        {
            lock (thisLock)
            {
                Console.WriteLine(line);
            }
        }

        public override void OnConnect(Controller controller)
        {
            Console.WriteLine("Connected");
            controller.EnableGesture(Gesture.GestureType.TYPE_SWIPE);
            controller.EnableGesture(Leap.Gesture.GestureType.TYPE_CIRCLE);
            controller.EnableGesture(Leap.Gesture.GestureType.TYPE_SCREEN_TAP);

        }

        public override void OnFrame(Controller controller)
        {
            Frame frame = controller.Frame();

            InteractionBox interactionBox = frame.InteractionBox;
            pointerPosition = interactionBox.NormalizePoint(frame.Pointables.Frontmost.TipPosition);
            hands = frame.Hands;
            gestures = frame.Gestures();

            if (hands.Count.Equals(1))
            {
                string handName = hands[0].IsLeft ? "Left Hand" : "Right Hand";
                GetGesture(handName);
            } else if (hands.Count.Equals(2)){
                Print("Both hands up!");
            }                 
        }

        private void GetGesture(string handName)
        {
            foreach (Gesture gesture in gestures)
            {
                if (gesture.State.Equals(Gesture.GestureState.STATESTOP))
                {
                    if (gesture.Type.Equals(Gesture.GestureType.TYPE_SCREEN_TAP))
                    {
                        Print("Screen Tap Detected With " + handName);
                    }
                    if (gesture.Type.Equals(Gesture.GestureType.TYPE_SWIPE))
                    {
                        Print("Swipe Detected With " + handName);
                    }
                }
            }
        }

        private void Print(String output)
        {
            lock (thisLock)
            {
                Console.WriteLine("[OUTPUT] " + output);
            }
        }
    }
}

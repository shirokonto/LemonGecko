using Leap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace LeapMotionGestureMapper
{
    public class LeapListener : Listener
    {
        //fields
        private GestureList gestures = null;
        private HandList hands = null;
        private Object thisLock = new Object();
        private Controller controller = null;
        public event EventHandler<Events.CircleEvent> CircleDetected;

        static void Main()
        {
            LeapListener gestureMapper = new LeapListener();
        }

        //constructor
        public LeapListener()
        {
            controller = new Controller();
            //track data when app is not in the foreground
            controller.SetPolicyFlags(Controller.PolicyFlag.POLICY_BACKGROUND_FRAMES); 
            controller.AddListener(this);

            Console.ReadLine();            
        }

        //destructor
        ~ LeapListener()
        {
            controller.RemoveListener(this);
            controller.Dispose();
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
            controller.EnableGesture(Gesture.GestureType.TYPE_CIRCLE);
            controller.EnableGesture(Gesture.GestureType.TYPE_SCREEN_TAP);

        }

        public override void OnFrame(Controller controller)
        {
            Frame frame = controller.Frame();
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

        protected virtual void OnCircleDetected(Events.CircleEvent circle)
        {
            EventHandler<Events.CircleEvent> handler = CircleDetected;

            if (handler != null)
            {
                Print("Circle Event Called");
                handler(this, circle);
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
                        //select 
                    }
                    if (gesture.Type.Equals(Gesture.GestureType.TYPE_SWIPE))
                    {
                        Print("Swipe Detected With " + handName);
                        //next [tab]
                        //keybd_event((byte)ONE_KEY, (byte)0x02, 0, UIntPtr.Zero); //does work but only in terminal which is ok
                    }
                    if (gesture.Type.Equals(Gesture.GestureType.TYPE_CIRCLE))
                    {
                        Print("Circle Gesture Detected With " + handName);
                        CircleGesture circle = new CircleGesture(gesture);
                        Events.CircleEvent circleEvent = new Events.CircleEvent(circle);
                        OnCircleDetected(circleEvent);
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

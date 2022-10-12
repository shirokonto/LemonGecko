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
        public event EventHandler<Events.HandSwipeEvent> HandSwipeDetected;

        //key mapper
        private KeyHandler keyHandler;
        private Interop interop;

        static void Main()
        {
            LeapListener gestureMapper = new LeapListener();

            Console.ReadKey();
        }

        //constructor
        public LeapListener()
        {
            controller = new Controller();
            //track data when app is not in the foreground
            controller.SetPolicyFlags(Controller.PolicyFlag.POLICY_BACKGROUND_FRAMES);

            controller.EnableGesture(Gesture.GestureType.TYPE_SWIPE);
            controller.EnableGesture(Gesture.GestureType.TYPE_CIRCLE);
            controller.EnableGesture(Gesture.GestureType.TYPE_SCREEN_TAP);

            controller.AddListener(this);

            keyHandler = new KeyHandler();
            interop = new Interop(keyHandler);
        }

        //destructor
        ~ LeapListener()
        {
            controller.RemoveListener(this);
            controller.Dispose();
        }

        public override void OnConnect(Controller controller)
        {
            Console.WriteLine("Connected");            
        }

        public override void OnFrame(Controller controller)
        {
            Frame frame = controller.Frame();
            //hands = frame.Hands;
            gestures = frame.Gestures();

            foreach (Gesture gesture in gestures)
            {
                if (gesture.State.Equals(Gesture.GestureState.STATESTOP))
                {
                    if (gesture.Type.Equals(Gesture.GestureType.TYPE_SWIPE))
                    {
                        Print("Swipe Detected With ");
                        SwipeGesture swipe = new SwipeGesture(gesture);
                        //Events.FingerSwipeEvent swipeEvent = new Events.FingerSwipeEvent(swipe);
                        //OnFingerSwipeDetected(swipeEvent);
                        //next [tab]
                        //keybd_event((byte)ONE_KEY, (byte)0x02, 0, UIntPtr.Zero); //does work but only in terminal which is ok
                    }
                    if (gesture.Type.Equals(Gesture.GestureType.TYPE_CIRCLE))
                    {
                        Print("Circle Gesture Detected With ");
                        CircleGesture circle = new CircleGesture(gesture);
                        Events.CircleEvent circleEvent = new Events.CircleEvent(circle);
                        OnCircleDetected(circleEvent);
                    }
                    if (gesture.Type.Equals(Gesture.GestureType.TYPE_SCREEN_TAP))
                    {
                        Print("Screen Tap Detected With");
                        Leap.ScreenTapGesture screenTap = new Leap.ScreenTapGesture(gesture);
                        //Events.ScreenTapEvent screenTapEvent = new Events.ScreenTapEvent(screenTap);
                        //OnScreenTapDetected(screenTapEvent);
                    }
                }
            }
            Gestures.HandSwipe handSwipe = Gestures.HandSwipe.IsHandSwipe(frame);
            if (handSwipe != null)
            {
                if (handSwipe.State.Equals(Gestures.GestureState.END))
                {
                    Print("Hand Swipe Detected");

                    Events.HandSwipeEvent swipeEvent = new Events.HandSwipeEvent(handSwipe);
                    OnHandSwipeDetected(swipeEvent);
                }
            }
            /*if (hands.Count.Equals(1))
            {
                string handName = hands[0].IsLeft ? "Left Hand" : "Right Hand";
                
            } else if (hands.Count.Equals(2)){
                Print("Both hands up!");
            }               */  
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

        protected virtual void OnHandSwipeDetected(Events.HandSwipeEvent handSwipe)
        {
            EventHandler<Events.HandSwipeEvent> handler = HandSwipeDetected;

            if (handler != null)
            {
                Print("Hand Swipe Event Called");
                handler(this, handSwipe);
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

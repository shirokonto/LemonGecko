using Leap;
using System;

namespace GestureRecognition
{
    public class LeapListener : Listener
    {
        //fields
        private GestureList gestures = null;
        private HandList hands = null;
        private Object thisLock = new Object();
        private Controller controller = null;
        private bool isConnected;

        public event EventHandler<Events.CircleEvent> CircleDetected;
        public event EventHandler<Events.HandSwipeEvent> HandSwipeDetected;
        public event EventHandler<Events.ScreenTapEvent> ScreenTapDetected;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
        }

        //constructor
        public LeapListener()
        {
            controller = new Controller();
            isConnected = controller.IsConnected;

            //tracks data when app is not in the foreground
            controller.SetPolicyFlags(Controller.PolicyFlag.POLICY_BACKGROUND_FRAMES);
            controller.EnableGesture(Gesture.GestureType.TYPE_CIRCLE);
            controller.EnableGesture(Gesture.GestureType.TYPE_SCREEN_TAP);
            
            controller.AddListener(this);
        }

        //destructor
        ~ LeapListener()
        {
            //if app closes leap listener gets removed
            if (controller != null && isConnected)
            {
                controller.RemoveListener(this);
                controller.Dispose();
            }
        }

        public override void OnConnect(Controller controller)
        {            
            Console.WriteLine("Connected");            
        }

        public override void OnServiceDisconnect(Controller controller)
        {
            Console.WriteLine("Service disconnected");
            base.OnServiceDisconnect(controller);
        }

        public override void OnDisconnect(Controller controller)
        {
            Console.WriteLine("Disconnected");
            base.OnDisconnect(controller);
        }

        public bool IsControllerConnected()
        {
            return controller.IsConnected;
        }

        public override void OnFrame(Controller controller)
        {
            Frame frame = controller.Frame();
            Hand hand = frame.Hands[0];

            if (hand.IsValid)
            {

            }
            /*Console.WriteLine("Hand palm position: " + hand.PalmPosition);
            for (int i = 0; i < hand.Fingers.Count; i++)
            {
                Console.WriteLine(hand.Fingers[i].Type + " Finger position: " + hand.Fingers[i].StabilizedTipPosition);
            }
            Console.WriteLine("###############################");*/

            gestures = frame.Gestures();
            foreach (Gesture gesture in gestures)
            {
                if (gesture.State.Equals(Gesture.GestureState.STATESTOP))
                {
                    if (gesture.Type.Equals(Gesture.GestureType.TYPE_CIRCLE))
                    {
                        Print("Circle Gesture Detected ");
                        CircleGesture circle = new CircleGesture(gesture);
                        Events.CircleEvent circleEvent = new Events.CircleEvent(circle);
                        OnCircleDetected(circleEvent);
                    }
                    if (gesture.Type.Equals(Gesture.GestureType.TYPE_SCREEN_TAP))
                    {
                        Print("Screen Tap Detected ");
                        ScreenTapGesture screenTap = new ScreenTapGesture(gesture);
                        Events.ScreenTapEvent screenTapEvent = new Events.ScreenTapEvent(screenTap);
                        OnScreenTapDetected(screenTapEvent);
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

        protected virtual void OnScreenTapDetected(Events.ScreenTapEvent screenTap)
        {
            EventHandler<Events.ScreenTapEvent> handler = ScreenTapDetected;

            if (handler != null)
            {
                Print("Screen Tap Event Called");
                handler(this, screenTap);
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

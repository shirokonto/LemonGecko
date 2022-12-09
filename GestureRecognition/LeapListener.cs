using GestureRecognition.Events;
using Leap;
using System;

namespace GestureRecognition
{
    public class LeapListener : Listener
    {
        //fields
        private GestureList gestures = null;
        private Object thisLock = new Object();
        private Controller controller = null;
        private bool isConnected;


        public event EventHandler<DisconnectEvent> DisconnectDetected;
        public event EventHandler<CircleEvent> CircleDetected;
        public event EventHandler<HandSwipeEvent> HandSwipeDetected;
        public event EventHandler<ScreenTapEvent> ScreenTapDetected;
        public event EventHandler<FistEvent> FistDetected;

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
            //TODO stop session of app 
            //do it with an event
        }

        public override void OnDisconnect(Controller controller)
        {
            Console.WriteLine("Disconnected");
            base.OnDisconnect(controller);
            DisconnectEvent disconnectEvent = new DisconnectEvent(controller);
            OnDisconnectDetected(disconnectEvent);
            // stop session via event
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
                gestures = frame.Gestures();
                foreach (Gesture gesture in gestures)
                {
                    if (gesture.State.Equals(Gesture.GestureState.STATESTOP))
                    {
                        if (gesture.Type.Equals(Gesture.GestureType.TYPE_CIRCLE))
                        {
                            Print("Circle Gesture Detected ");
                            CircleGesture circle = new CircleGesture(gesture);
                            CircleEvent circleEvent = new CircleEvent(circle);
                            OnCircleDetected(circleEvent);
                        }
                        if (gesture.Type.Equals(Gesture.GestureType.TYPE_SCREEN_TAP))
                        {
                            Print("Screen Tap Detected ");
                            ScreenTapGesture screenTap = new ScreenTapGesture(gesture);
                            ScreenTapEvent screenTapEvent = new ScreenTapEvent(screenTap);
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

                        HandSwipeEvent swipeEvent = new HandSwipeEvent(handSwipe);
                        OnHandSwipeDetected(swipeEvent);
                    }
                }
                Gestures.Fist fist = Gestures.Fist.IsFist(frame);
                if (fist != null)
                {
                    if (fist.State.Equals(Gestures.GestureState.END))
                    {
                        Print("Fist Detected");

                        FistEvent fistEvent = new FistEvent(fist);
                        OnFistDetected(fistEvent);
                    }
                }
            }            
        }

        protected virtual void OnDisconnectDetected(DisconnectEvent disconnectEvent)
        {
            EventHandler<DisconnectEvent> handler = DisconnectDetected;

            if(handler != null)
            {
                Print("Disconnect Event Called");
                handler(this, disconnectEvent);
            }
        }

        protected virtual void OnCircleDetected(CircleEvent circle)
        {
            EventHandler<CircleEvent> handler = CircleDetected;

            if (handler != null)
            {
                Print("Circle Event Called");
                handler(this, circle);
            }
        }

        protected virtual void OnHandSwipeDetected(HandSwipeEvent handSwipe)
        {
            EventHandler<HandSwipeEvent> handler = HandSwipeDetected;

            if (handler != null)
            {
                Print("Hand Swipe Event Called");
                handler(this, handSwipe);
            }
        }

        protected virtual void OnScreenTapDetected(ScreenTapEvent screenTap)
        {
            EventHandler<ScreenTapEvent> handler = ScreenTapDetected;

            if (handler != null)
            {
                Print("Screen Tap Event Called");
                handler(this, screenTap);
            }
        }

        protected virtual void OnFistDetected(FistEvent fist)
        {
            EventHandler<FistEvent> handler = FistDetected;

            if(handler != null)
            {
                Print("Fist Event Called");
                handler(this, fist);
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

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
        private readonly bool isConnected;


        public event EventHandler<DisconnectEvent> DisconnectDetected;
        public event EventHandler<CircleEvent> CircleDetected;
        public event EventHandler<HandSwipeEvent> HandSwipeDetected;
        public event EventHandler<ScreenTapEvent> ScreenTapDetected;
        public event EventHandler<PunchEvent> PunchDetected;

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
            controller.SetPolicy(Controller.PolicyFlag.POLICY_BACKGROUND_FRAMES);
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
            Print("Connected");
        }

        public override void OnDisconnect(Controller controller)
        {
            Print("Disconnected");
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
                            CircleGesture circle = new CircleGesture(gesture);
                            CircleEvent circleEvent = new CircleEvent(circle);
                            if(circle.Pointable.Direction.AngleTo(circleEvent.Circle.Normal) <= Math.PI / 2)
                            {
                                Print("Frame: " + frame.Id + " & " + gesture.Type + "(CLOCKWISE)");
                            } else
                            {
                                Print("Frame: " + frame.Id + " & " + gesture.Type + "(COUNTERCLOCKWISE)");
                            }
                            
                            OnCircleDetected(circleEvent);
                            return;
                        }
                        if (gesture.Type.Equals(Gesture.GestureType.TYPE_SCREEN_TAP))
                        {
                            Print("Frame: " + frame.Id + " & " + gesture.Type);
                            ScreenTapGesture screenTap = new ScreenTapGesture(gesture);
                            ScreenTapEvent screenTapEvent = new ScreenTapEvent(screenTap);
                            OnScreenTapDetected(screenTapEvent);
                            return;
                        }
                    }
                }
                Gestures.HandSwipe handSwipe = Gestures.HandSwipe.IsHandSwipe(frame);
                if (handSwipe != null)
                {
                    
                    if (handSwipe.State.Equals(Gestures.GestureState.END))
                    {
                        HandSwipeEvent swipeEvent = new HandSwipeEvent(handSwipe);
                        OnHandSwipeDetected(swipeEvent);
                        Print("Frame: " + frame.Id + " & " + handSwipe.Type + "(" + handSwipe.Direction +")");
                        return;
                    }
                }
                Gestures.Punch punch = Gestures.Punch.IsPunch(frame);
                if (punch != null)
                {                    
                    if (punch.State.Equals(Gestures.GestureState.END))
                    {
                        Print("Frame: " + frame.Id + " & " + punch.Type);
                        PunchEvent punchEvent = new PunchEvent(punch);
                        OnPunchDetected(punchEvent);
                        return;
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
                handler(this, circle);
            }
        }

        protected virtual void OnHandSwipeDetected(HandSwipeEvent handSwipe)
        {
            EventHandler<HandSwipeEvent> handler = HandSwipeDetected;

            if (handler != null)
            {
                handler(this, handSwipe);
            }
        }

        protected virtual void OnScreenTapDetected(ScreenTapEvent screenTap)
        {
            EventHandler<ScreenTapEvent> handler = ScreenTapDetected;

            if (handler != null)
            {
                handler(this, screenTap);
            }
        }

        protected virtual void OnPunchDetected(PunchEvent punch)
        {
            EventHandler<PunchEvent> handler = PunchDetected;

            if(handler != null)
            {
                handler(this, punch);
            }
        }

        public void Print(String output)
        {
            lock (thisLock)
            {
                Console.WriteLine(output);
            }
        }
    }
}

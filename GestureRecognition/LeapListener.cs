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

        public event EventHandler<Events.CircleEvent> CircleDetected;
        public event EventHandler<Events.HandSwipeEvent> HandSwipeDetected;
        public event EventHandler<Events.FingerSwipeEvent> FingerSwipeDetected;
        public event EventHandler<Events.ScreenTapEvent> ScreenTapDetected;
        public event EventHandler<Events.ZoomInEvent> ZoomInDetected;
        public event EventHandler<Events.ZoomOutEvent> ZoomOutDetected;

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
                        Events.FingerSwipeEvent swipeEvent = new Events.FingerSwipeEvent(swipe);
                        OnFingerSwipeDetected(swipeEvent);
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
            Gestures.ZoomIn zoomIn = Gestures.ZoomIn.IsZoomIn(frame);
            if (zoomIn != null)
            {
                if (zoomIn.State.Equals(Gestures.GestureState.END))
                {
                    Print("ZoomIn Detected");

                    Events.ZoomInEvent zoomInEvent = new Events.ZoomInEvent(zoomIn);
                    OnZoomInDetected(zoomInEvent);
                }
            }
            Gestures.ZoomOut zoomOut = Gestures.ZoomOut.IsZoomOut(frame);
            if (zoomOut != null)
            {
                if (zoomOut.State.Equals(Gestures.GestureState.END))
                {
                    Print("ZoomOut Detected");

                    Events.ZoomOutEvent zoomOutEvent = new Events.ZoomOutEvent(zoomOut);
                    OnZoomOutDetected(zoomOutEvent);
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

        protected virtual void OnFingerSwipeDetected(Events.FingerSwipeEvent fingerSwipe)
        {
            EventHandler<Events.FingerSwipeEvent> handler = FingerSwipeDetected;

            if (handler != null)
            {
                Print("Finger Swipe Event Called");
                handler(this, fingerSwipe);
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
        protected virtual void OnZoomInDetected(Events.ZoomInEvent zoomIn)
        {
            EventHandler<Events.ZoomInEvent> handler = ZoomInDetected;

            if (handler != null)
            {
                Print("Zoom In Event Called");
                handler(this, zoomIn);
            }
        }
        protected virtual void OnZoomOutDetected(Events.ZoomOutEvent zoomOutSwipe)
        {
            EventHandler<Events.ZoomOutEvent> handler = ZoomOutDetected;

            if (handler != null)
            {
                Print("Zoom Out Event Called");
                handler(this, zoomOutSwipe);
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

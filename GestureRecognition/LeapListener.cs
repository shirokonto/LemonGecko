using GestureRecognition.Events;
using Leap;
using System;

namespace GestureRecognition
{
    /// <summary>
    /// The class <c>LeapListener</c> handles Leap Motion events which are invoked by the created <see cref="Controller"/>.
    /// This <see cref="Controller"/> calls the callback function of <c>LeapListener</c> when an event occurs.
    /// Furthermore the application receives frames as background application and the gestures 
    /// <see cref="Gesture.GestureType.TYPE_CIRCLE"/> and <see cref="Gesture.GestureType.TYPE_SCREEN_TAP"/> will be
    /// reported by the  <see cref="Controller"/>.
    /// In a modified form the code is taken from the repository <see cref="https://github.com/Ben-Floyd/LeapMotionGestureControl/blob/master/GestureMap/GestureMap.cs"/>
    /// </summary>
    public class LeapListener : Listener
    {
        //fields
        private GestureList gestures = null;
        private Object thisLock = new Object();
        private Controller controller = null;
        private readonly bool isConnected;

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

        /// <summary>
        /// Constructs a <c>LeapListener</c>-Object, which is a instance of <see cref="Listener"/>.
        /// </summary>
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
            if (controller != null && isConnected)
            {
                controller.RemoveListener(this);
                controller.Dispose();
            }
        }

        /// <summary>
        /// Called when the Controller object is connected to the Leap Motion software.
        /// </summary>
        /// <param name="controller">Connected controller</param>
        public override void OnConnect(Controller controller)
        {            
            Print("Leap Motion Controller is Connected");
        }

        /// <summary>
        /// Reports whether the controller is connected to the Leap Motion software and the hardware is plugged in.
        /// </summary>
        /// <returns>True, if there is a valid connection</returns>
        public bool IsControllerConnected()
        {
            return controller.IsConnected;
        }

        /// <summary>
        /// Called when a new frame of tracking data is available and determines
        /// whether a gesture type is in that frame.
        /// </summary>
        /// <param name="controller">Connected controller containing tracking data</param>
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
                                // Print("Frame: " + frame.Id + " & " + gesture.Type + "(CLOCKWISE)");
                            } else
                            {
                                // Print("Frame: " + frame.Id + " & " + gesture.Type + "(COUNTERCLOCKWISE)");
                            }

                            OnCircleDetected(circleEvent);
                            return;
                        }
                        if (gesture.Type.Equals(Gesture.GestureType.TYPE_SCREEN_TAP))
                        {
                            // Print("Frame: " + frame.Id + " & " + gesture.Type);
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
                        // Print("Frame: " + frame.Id + " & " + handSwipe.Type + "(" + handSwipe.Direction +")");
                        return;
                    }
                }
                Gestures.Punch punch = Gestures.Punch.IsPunch(frame);
                if (punch != null)
                {                    
                    if (punch.State.Equals(Gestures.GestureState.END))
                    {
                        // Print("Frame: " + frame.Id + " & " + punch.Type);
                        PunchEvent punchEvent = new PunchEvent(punch);
                        OnPunchDetected(punchEvent);
                        return;
                    }
                }
            }            
        }

        /// <summary>
        /// Called when a circle event is raised.
        /// </summary>
        /// <param name="circle">The raised Circle event associated with the EventHandler delegate</param>
        protected virtual void OnCircleDetected(CircleEvent circle)
        {
            EventHandler<CircleEvent> handler = CircleDetected;

            if (handler != null)
            {
                handler(this, circle);
            }
        }

        /// <summary>
        /// Called when a handSwipe event is raised.
        /// </summary>
        /// <param name="handSwipe">The raised HandSwipe event associated with the EventHandler delegate</param>
        protected virtual void OnHandSwipeDetected(HandSwipeEvent handSwipe)
        {
            EventHandler<HandSwipeEvent> handler = HandSwipeDetected;

            if (handler != null)
            {
                handler(this, handSwipe);
            }
        }

        /// <summary>
        /// Called when a screenTap event is raised.
        /// </summary>
        /// <param name="screenTap">The raised ScreenTap event associated with the EventHandler delegate</param>
        protected virtual void OnScreenTapDetected(ScreenTapEvent screenTap)
        {
            EventHandler<ScreenTapEvent> handler = ScreenTapDetected;

            if (handler != null)
            {
                handler(this, screenTap);
            }
        }

        /// <summary>
        /// Called when a punch event is raised.
        /// </summary>
        /// <param name="punch">The raised Punch event associated with the EventHandler delegate</param>
        protected virtual void OnPunchDetected(PunchEvent punch)
        {
            EventHandler<PunchEvent> handler = PunchDetected;

            if(handler != null)
            {
                handler(this, punch);
            }
        }

        /// <summary>
        /// Prints the given string in the console.
        /// </summary>
        /// <param name="output">Output string</param>
        public void Print(String output)
        {
            lock (thisLock)
            {
                Console.WriteLine(output);
            }
        }
    }
}

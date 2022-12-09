using Leap;
using System;

namespace GestureRecognition.Events
{
    public class DisconnectEvent : EventArgs
    {
        private Controller _controller;

        public DisconnectEvent(Controller controller)
        {
            _controller = controller;
        }

        public Controller Circle
        {
            get { return _controller; }
            set { _controller = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher
{
    public class ScreenReaderItem
    {
        public enum Gesture { SCREENTAP, SWIPERIGHT, SWIPELEFT }; //TODO: add more gestures
        private ScreenReaderMapping _gestureMapping;
        private string _screenReaderName;
        private int _id;

        public ScreenReaderItem()
        {
        }

        public string ScreenReaderName
        {
            get { return _screenReaderName; }
            set { _screenReaderName = value; }
        }

        public ScreenReaderMapping GestureMapping
        {
            get { return _gestureMapping; }
            set { _gestureMapping = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}

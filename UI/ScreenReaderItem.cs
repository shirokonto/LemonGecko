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
        private string _screenReaderName;
        private int _id;
        private Dictionary<Gesture, string> gestureMap;

        public ScreenReaderItem(string screenReaderName, int id)
        {
            _screenReaderName = screenReaderName;
            _id = id;
            gestureMap = new Dictionary<Gesture, string>();
        }
        public ScreenReaderItem()
        {
            gestureMap = new Dictionary<Gesture, string>();
        }

        public string ScreenReaderName
        {
            get { return _screenReaderName; }
            set { _screenReaderName = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public void MapKeyToGesture(Gesture gesture, string keystroke)
        {
            gestureMap.Add(gesture, keystroke);
        }

        public string GetKeyStrokeMapping(Gesture gesture)
        {
            if(gestureMap.ContainsKey(gesture))
            {
                return gestureMap[gesture];
            }
            return null;
        }
    }
}

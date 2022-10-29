using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher
{
    public class ScreenReaderItem
    {
        private GestureMapping _gestureMapping;
        private string _screenReaderName;

        public ScreenReaderItem()
        {
        }

        public string ScreenReaderName
        {
            get { return _screenReaderName; }
            set { _screenReaderName = value; }
        }

        public GestureMapping GestureMapping
        {
            get { return _gestureMapping; }
            set { _gestureMapping = value; }
        }
    }
}

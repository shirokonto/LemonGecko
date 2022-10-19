using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher
{
    public class ScreenReaderItem
    {
        private string _screenReaderName;
        private int _id;

        public ScreenReaderItem(string screenReaderName, int id)
        {
            _screenReaderName = screenReaderName;
            _id = id;
        }
        public ScreenReaderItem()
        {

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
    }
}

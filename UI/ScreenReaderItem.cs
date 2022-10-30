using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher
{
    public class ScreenReaderItem
    {
        public ScreenReaderItem()
        {
        }

        public string Name { get; set; }
        public string ScreenTap { get; set; }
        public string HandSwipeRight { get; set; }
        public string HandSwipeLeft { get; set; }
    }
}

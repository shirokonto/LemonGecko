using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher
{
    class ItemToPrint
    {

        private string gestureText;
        public ItemToPrint(string text)
        {
            SetPrintText(text);
        }

        public void SetPrintText(string text)
        {
            gestureText = text;
        }

        public string GetPrintText()
        {
            return gestureText;
        }
    }
}

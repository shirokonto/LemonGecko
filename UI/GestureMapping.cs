using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Launcher
{
    public class GestureMapping
    {
        private string _screenTap;
        public string Name { get; set; }
        public string ScreenTap
        {
            get { return _screenTap; }
            set { _screenTap = SetScreenTap(value); }
        }
        public string HandSwipeRight { get; set; }
        public string HandSwipeLeft { get; set; }

        private string SetScreenTap(string key)
        {
            KeyCodeMapping keyCodeMap = new KeyCodeMapping();
                //GetCodeForKey
            //special keys:
            // left [alt] is menu -> SendKeys.Send("+({F10})");
            // right [alt gr] key -> ControlKey (keys.Control | Keys.Alt ) )
            //(if not alphabet -> {} is used https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.sendkeys.send?view=windowsdesktop-7.0
            Console.WriteLine(key);
            Regex regex = new Regex("^[a-zA-Z][a-zA-Z0-9]*$");
            Regex regexBrackets = new Regex(@"(?<=\{)[^}]*(?=\})");

            if (key.Length > 1 || !regex.IsMatch(key))
            {
                //if string length is more than one!
                //get input key ("Enter")
                if (!regexBrackets.IsMatch(key))
                {
                    string newKey = "{" + key.ToUpper() + "}";
                    Console.WriteLine("new key: " + newKey);
                    return key;
                }
                //build string ({ENTER})
                //save into key and return it
                Console.WriteLine("does not match regex: " + key);
                return key;
            }
            Console.WriteLine("matches regex: " + key);
            return key;
        }
    }
}

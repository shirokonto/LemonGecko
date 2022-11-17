using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Launcher
{
    public class KeyMappingHelper
    {
        private JsonParser jsonParser;
        private readonly Regex AlphaRegex = new Regex("^[A-Za-z]+$");
        private readonly Regex RoundAndCurlyBracketsRegex = new Regex(@"[\({][^\)}]*[\)}]|[^{}()]+");

        public KeyMappingHelper() 
        {
            jsonParser = new JsonParser();
            jsonParser.LoadJsonForGestureMapping();
            jsonParser.LoadJsonForKeyMapping();
        }

        public List<string> GetKeysForCode(string code)
        {
            List<string> result = new List<string>();
            Match match = RoundAndCurlyBracketsRegex.Match(code);
            while (match.Success)
            {              
                if (match.Value.Length > 1 || !AlphaRegex.IsMatch(code)) // ^+* or (a) or {ENTER} 
                {
                    if (result.Count == 1 && match.Value.Contains("(")) //second command and (a)
                    {
                        string alphabet = match.Value.Substring(1, match.Value.Length - 2);
                        result.Add(alphabet.ToUpper());
                        return result;
                    }
                    KeyCodeObj mapping = jsonParser.GetKeyForCode(match.Value.ToUpper());
                    if (mapping != null)
                        result.Add(mapping.Key);
                }
                else // A 
                    result.Add(code);
                match = match.NextMatch();
            }
            return result;
        }

        public string GetCodeForKey(string firstKey, string secondKey)
        {
            string command = "";
            if(firstKey != "")
                command = HandleFirstCommand(firstKey);
            if (secondKey != "")
                command += HandleSecondCommand(secondKey);            
            return command;
        }

        private string HandleFirstCommand(string key)
        {
            if(key.Length == 2 && key != "UP" && AlphaRegex.IsMatch(key)) //aA is good ### F2, SHIFTKEY is bad UP should also not be tolerated
            {
                key = key.Remove(1, 1);
                return key.ToUpper();
            }
            else //F2, SHIFTKEY is good ### aA is bad  
            {
                KeyCodeObj mapping = jsonParser.GetCodeForKey(key.ToUpper());
                if (mapping != null)
                    return mapping.Code;
                return null;
            }            
        }

        private string HandleSecondCommand(string key)
        {
            if (key.Length == 2 && AlphaRegex.IsMatch(key))
            {
                key = key.Remove(1, 1).ToLower();
                key = "(" + key + ")";
                return key;
            }
            else
            {
                KeyCodeObj mapping = jsonParser.GetCodeForKey(key.ToUpper());
                if (mapping != null)
                    return mapping.Code;                
            }
            return null;
        }
    }
}

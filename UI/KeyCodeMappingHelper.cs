using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Launcher
{
    /// <summary>
    /// The class <c>KeyCodeMappingHelper</c> handles the conversion of keys to codes and vice versa to display the correct format for the view or save the gesture-to-key mapping.
    /// </summary>
    public class KeyCodeMappingHelper
    {
        private JsonParser jsonParser;
        private readonly Regex AlphaRegex = new Regex("^[A-Za-z]+$");
        private readonly Regex RoundAndCurlyBracketsRegex = new Regex(@"[\({][^\)}]*[\)}]|[^{}()]+");

        /// <summary>
        /// Constructs a new <c>KeyCodeMappingHelper</c> object.
        /// </summary>
        public KeyCodeMappingHelper()
        {
            jsonParser = new JsonParser();
            jsonParser.LoadJsonForKeyToGestureMapping();
            jsonParser.LoadJsonForKeyToCodeMapping();
        }

        /// <summary>
        /// Retrieves up to two keystrokes matching for the given code.
        /// </summary>
        /// <param name="code">The code used for the simulation containing up to two keystrokes</param>
        /// <returns>List of <see cref="KeyCodeObj.Key"/> which is mapped to the code</returns>
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
                else
                    result.Add(code);
                match = match.NextMatch();
            }
            return result;
        }

        /// <summary>
        /// Retrieves the given code for the given keystrokes.
        /// </summary>
        /// <param name="firstKey">first key of the shortcut</param>
        /// <param name="secondKey">second key of the shortcut</param>
        /// <returns>The code consisting of up to two keystrokes</returns>
        public string GetCodeForKey(string firstKey, string secondKey)
        {
            string command = "";
            if (firstKey != "")
                command = HandleFirstCommand(firstKey);
            if (secondKey != "")
                command += HandleSecondCommand(secondKey);
            return command;
        }

        private string HandleFirstCommand(string key)
        {
            if (key.Length == 2 && key != "UP" && AlphaRegex.IsMatch(key))
            {
                key = key.Remove(1, 1);
                return key.ToUpper();
            }
            else
            {
                KeyCodeObj mapping = jsonParser.GetCodeForKey(key.ToUpper());
                if (mapping != null)
                    return mapping.Code;
                return null;
            }
        }

        private string HandleSecondCommand(string key)
        {
            if (key.Length == 1 && AlphaRegex.IsMatch(key))
            {
                key = "(" + key + ")";
                return key;
            }
            else if (key.Length == 2 && key != "UP" && AlphaRegex.IsMatch(key))
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

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Launcher
{
    /// <summary>
    /// The class <c>JsonParser</c> handles the conversion of JSON Data to the .NET objects <see cref="ScreenReaderItem"/> 
    /// or <see cref="KeyCodeObj"/> and vice versa.
    /// </summary>
    class JsonParser
    {
        private List<ScreenReaderItem> screenReaders;
        private List<KeyCodeObj> keyCodes;
        private JArray array;

        /// <summary>
        /// Constructs a new <c>JsonParser</c> object.
        /// </summary>
        public JsonParser()
        {

        }

        /// <summary>
        /// Loads the key-to-gesture mapping of all screen readers and saves them in a list containing <see cref="ScreenReaderItem"/>.
        /// </summary>
        public void LoadJsonForKeyToGestureMapping()
        {
            string filePath = Properties.Settings.Default.GestureKeyMapping;
            string json = File.ReadAllText(filePath);

            screenReaders = JsonConvert.DeserializeObject<List<ScreenReaderItem>>(json);
        }

        /// <summary>
        /// Loads the key-to-code mappings for the key mapping in the settings view and saves them in a list containing <see cref="KeyCodeObj"/>.
        /// </summary>
        public void LoadJsonForKeyToCodeMapping()
        {
            string filePath = Properties.Settings.Default.KeyCodeMapping;
            string json = File.ReadAllText(filePath);
            keyCodes = JsonConvert.DeserializeObject<List<KeyCodeObj>>(json);
        }

        /// <summary>
        /// Stores the specified screen reader's new key-to-gesture mapping.
        /// </summary>
        /// <param name="item">The screen reader for which a new mapping is being set</param>
        public void SaveGestureMappingToJson(ScreenReaderItem item)
        {
            int index = screenReaders.FindIndex(searchedItem => searchedItem.Name == item.Name);
            if (index != -1)
            {
                screenReaders[index] = item;
            }
            array = JArray.FromObject(screenReaders);

            string path = Properties.Settings.Default.GestureKeyMapping;
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(writer, array);
                writer.Close();
            }
        }

        /// <summary>
        /// Retrieves the mapping data for the given screen reader.
        /// </summary>
        /// <param name="processName">The process name of the screen reader</param>
        /// <returns>The matching ScreenReaderItem with the key-to-gesture mapping or null, if it does not exist</returns>
        public ScreenReaderItem GetMappingForScreenReader(string processName)
        {
            List<ScreenReaderItem> items = screenReaders.Where(screenReader => screenReader.Name == processName).ToList();
            if (items.Count == 1)
            {
                return items[0];
            }
            return null;
        }

        /// <summary>
        /// Retrieves the mapping data for the specified key.
        /// </summary>
        /// <param name="key">The key which is presented in the Settings view</param>
        /// <returns>The KeyCodeObj with the matching code or null, if there is no match</returns>
        public KeyCodeObj GetCodeForKey(string key)
        {
            List<KeyCodeObj> mapping = keyCodes.Where(keyCode => keyCode.Key == key).ToList();
            if (mapping.Count == 1)
            {
                return mapping[0];
            }
            return null;
        }

        /// <summary>
        /// Retrieves the mapping data for the specified code.
        /// </summary>
        /// <param name="code">The code which is used for the keystroke simulation</param>
        /// <returns>The KeyCodeObj with the matching key or null, if there is no match</returns>
        public KeyCodeObj GetKeyForCode(string code)
        {
            List<KeyCodeObj> mapping = keyCodes.Where(keyCode => keyCode.Code == code).ToList();
            if (mapping.Count == 1)
            {
                return mapping[0];
            }
            return null;
        }

        /// <summary>
        /// Retrieve the key-to-gesture mapping of all screenreaders.
        /// </summary>
        /// <returns>A list of ScreenReaderItems</returns>
        public List<ScreenReaderItem> GetAllScreenReader()
        {
            return screenReaders;
        }
    }
}

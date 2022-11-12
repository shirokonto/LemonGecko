using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Launcher
{
    class JsonParser
    {
        List<ScreenReaderItem> screenReaders;
        List<KeyCodeObj> keyCodes;
        JArray array;
        public JsonParser() {
            LoadJsonForGestureMapping();
        }

        public void LoadJsonForGestureMapping()
        {
            string filePath = Properties.Settings.Default.GestureKeyMapping;
            string json = File.ReadAllText(filePath);
            
            screenReaders = JsonConvert.DeserializeObject<List<ScreenReaderItem>>(json);
        }

        public void LoadJsonForKeyMapping()
        {
            string filePath = Properties.Settings.Default.KeyCodeMapping;
            string json = File.ReadAllText(filePath);
            keyCodes = JsonConvert.DeserializeObject<List<KeyCodeObj>>(json);
        }

        public void SaveChangesToJson(ScreenReaderItem item)
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

        public ScreenReaderItem GetMappingForScreenReader(string processName)
        {
            List<ScreenReaderItem> items = screenReaders.Where(screenReader => screenReader.Name == processName).ToList();
            if(items.Count == 1)
            {
                return items[0];
            }
            return null;
        }

        public KeyCodeObj GetCodeForKey(string key)
        {
            List<KeyCodeObj> mapping = keyCodes.Where(keyCode => keyCode.Key == key).ToList();
            if(mapping.Count == 1)
            {
                return mapping[0];
            } 
            return null;
        }

        public List<ScreenReaderItem> GetAllScreenReader()
        {
            return screenReaders;
        }
    }
}

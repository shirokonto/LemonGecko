using System;
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
            array = JArray.FromObject(screenReaders);
            JToken newToken = JToken.FromObject(item);

            foreach(JToken t in array)
            {
                if(t["Name"].ToString() == (item.Name))
                {
                    t.Replace(newToken);
                    break;
                }                
            }
            FileStream fs = null;
            try
            {
                fs = new FileStream(Properties.Settings.Default.GestureKeyMapping, FileMode.Open);
                using (StreamWriter file = new StreamWriter(fs))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, array);
                }
            }
            finally
            {
                if (fs != null) fs.Dispose();
            }
            //https://stackoverflow.com/questions/21695185/change-values-in-json-file-writing-files#21695462
            
            //close stream!
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

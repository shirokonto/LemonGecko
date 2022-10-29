using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Json.Net;

namespace Launcher
{
    class JsonParser
    {
        List<GestureMapping> screenReaders;
        List<KeyCodeMapping> keyCodes;
        public JsonParser()
        {
            LoadJson();
            LoadJsonForKeyMapping();
        }

        private void LoadJson()
        {
            string filePath = Properties.Settings.Default.GestureKeyMapping;
            string json = File.ReadAllText(filePath);
            screenReaders = JsonNet.Deserialize<List<GestureMapping>>(json);
        }

        private void LoadJsonForKeyMapping()
        {
            string filePath = Properties.Settings.Default.KeyCodeMapping;
            string json = File.ReadAllText(filePath);
            keyCodes = JsonNet.Deserialize<List<KeyCodeMapping>>(json);
        }

        public void SaveChangesToJson(string change)
        {
            var newMapping = new GestureMapping
            {
                Name = change,
                ScreenTap = change,
                HandSwipeRight = change,
                HandSwipeLeft = change
            };
            string json = JsonNet.Serialize(newMapping);
        }

        public GestureMapping GetMappingForScreenReader(string processName)
        {
            List<GestureMapping> mapping = screenReaders.Where(screenReader => screenReader.Name == processName).ToList();
            if(mapping.Count == 1)
            {
                return mapping[0];
            }
            return null;
        }

        public KeyCodeMapping GetCodeForKey(string key)
        {
            List<KeyCodeMapping> mapping = keyCodes.Where(keyCode => keyCode.Key == key).ToList();
            if(mapping.Count == 1)
            {
                return mapping[0];
            } 
            return null;
        }
    }
}

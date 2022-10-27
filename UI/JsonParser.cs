using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Json.Net;

namespace Launcher
{
    class JsonParser
    {
        List<ScreenReaderMapping> screenReaders;
        public JsonParser()
        {
            LoadJson();
        }

        private void LoadJson()
        {
            string filePath = Properties.Settings.Default.GestureKeyMapping;
            string json = File.ReadAllText(filePath);
            screenReaders = JsonNet.Deserialize<List<ScreenReaderMapping>>(json);
        }

        public void SaveChangesToJson(string change)
        {
            var newMapping = new ScreenReaderMapping
            {
                Name = change,
                ScreenTap = change,
                HandSwipeRight = change,
                HandSwipeLeft = change
            };
            string json = JsonNet.Serialize(newMapping);
        }

        public ScreenReaderMapping GetMappingForScreenReader(string processName)
        {
            List<ScreenReaderMapping> mapping = screenReaders.Where(screenReader => screenReader.Name == processName).ToList();
            if(mapping.Count == 1)
            {
                return mapping[0];
            }
            return null;
        }
    }

    public class ScreenReaderMapping
    {
        public string Name { get; set; }
        public string ScreenTap { get; set; }
        public string HandSwipeRight { get; set; }
        public string HandSwipeLeft { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace Launcher
{
    /// <summary>
    /// The class <c>ScreenReaderDetection</c> determines the currently running screen reader on the operating system
    /// including JAWS, NVDA and Narrator. 
    /// </summary>
    class ScreenReaderDetection
    {
        private List<ScreenReaderItem> activeScreenReaders;
        private JsonParser jsonParser = null;

        /// <summary>
        /// Constructs a <c>ScreenReaderDetection</c> object which determins the currently running screen reader.
        /// </summary>
        public ScreenReaderDetection()
        {
            activeScreenReaders = new List<ScreenReaderItem>();
            jsonParser = new JsonParser();
            jsonParser.LoadJsonForKeyToGestureMapping();
            IEnumerable<Process> processes =
                new[] { "Narrator", "nvda", "jfw" }
                .SelectMany(Process.GetProcessesByName);

            Process[] screenReaderProcesses = processes.ToArray();
            if (screenReaderProcesses.Length == 0)
            {
                Console.WriteLine("no active screen reader");
            } else
            {
                foreach(Process process in screenReaderProcesses)
                {
                    string processName = process.ProcessName;
                    if (process.ProcessName == "jfw")
                    {
                        processName = "JAWS";
                    }
                    // search for processName in json and map keys
                    ScreenReaderItem screenReader = jsonParser.GetMappingForScreenReader(processName);
                    if(screenReader != null)
                    {
                        activeScreenReaders.Add(screenReader);
                    }
                }
            }            
        }

        /// <summary>
        /// Retrieves all screen readers with their key-to-gesture mappings which are currently active.
        /// </summary>
        /// <returns>List of <see cref="ScreenReaderItem"/> objects</returns>
        public List<ScreenReaderItem> GetAllScreenReaders()
        {
            return activeScreenReaders;
        }

        /// <summary>
        /// Retrieves the key-to-gesture mapping of the given screenreader.
        /// </summary>
        /// <param name="name">The name of the screenreader</param>
        /// <returns><see cref="ScreenReaderItem"/> object or null if there is no match</returns>
        public ScreenReaderItem GetScreenReaderByName(string name)
        {  
            if(activeScreenReaders.Count != 0)
            {
                return activeScreenReaders.Where(i => i.Name.Equals(name)).First();
            }
            return null;
        }
    }
}

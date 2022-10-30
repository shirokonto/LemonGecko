using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Launcher
{
    /**
     * Detects the currently running screen reader
     * including JAWS, NVDA, Narrator and Dolphin ScreenReader 
     */
    class ScreenReaderDetection
    {
        private List<ScreenReaderItem> activeScreenReaders;
        private JsonParser jsonParser = null;

        public ScreenReaderDetection()
        {
            activeScreenReaders = new List<ScreenReaderItem>();
            jsonParser = new JsonParser();
            IEnumerable<Process> processes =
                new[] { "Narrator", "nvda", "jfw", "Hal" }
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
                    if(process.ProcessName == "Hal")
                    {
                        processName = "Dolphin SR";
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

        public List<ScreenReaderItem> GetAllScreenReaders()
        {
            return activeScreenReaders;
        }

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

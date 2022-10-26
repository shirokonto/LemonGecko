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
        public enum ScreenReader {NVDA, NARRATOR, JAWS};
        private ScreenReader currentScreenReader;
        private List<ScreenReaderItem> activeScreenReaders;

        public ScreenReaderDetection()
        {
            activeScreenReaders = new List<ScreenReaderItem>();

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
                    activeScreenReaders.Add(new ScreenReaderItem() { Id = process.Id, ScreenReaderName = processName });
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
                return activeScreenReaders.Where(i => i.ScreenReaderName.Equals(name)).First();
            }
            return null;
        }

    }
}

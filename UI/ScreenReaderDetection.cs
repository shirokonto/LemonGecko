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
     * include JAWS, NVDA, Narrator and co. 
     */
    class ScreenReaderDetection
    {
        public enum ScreenReader {NVDA, NARRATOR, JAWS};
        private ScreenReader currentScreenReader;
        private List<ScreenReaderItem> activeScreenReaders;

        public ScreenReaderDetection()
        {
            activeScreenReaders = new List<ScreenReaderItem>();
            Process[] narratorProcesses = Process.GetProcessesByName("Narrator");
            Process[] nvdaProcesses = Process.GetProcessesByName("nvda"); //add others "Jaws"

            IEnumerable<Process> processes =
                new[] { "Narrator", "nvda" }
                .SelectMany(Process.GetProcessesByName);

            Process[] screenReaderProcesses = processes.ToArray();
            if (screenReaderProcesses.Length == 0)
            {
                Console.WriteLine("no active screen reader");
            } else
            {
                foreach(Process process in screenReaderProcesses)
                {
                    activeScreenReaders.Add(new ScreenReaderItem() { Id = process.Id, ScreenReaderName = process.ProcessName });
                }
            }

            //if there are two 

            /*if (Process.GetProcessesByName("nvda").Any() && Process.GetProcessesByName("Narrator").Any()) //Narrator
            {
                currentScreenReader = ScreenReader.NVDA;
                Console.WriteLine("NVDA and Narrator are active");
                // if more than one screen reader is active ask the user which one should be focused?
                // Set the current screen reader as first value in dropdown
                // and set the default values in the gesture mapper in the UI
                // (!!! if the user has mapped own keys, dont change that)
            } else if(Process.GetProcessesByName("Narrator").Any())
            {
                Console.WriteLine("Narrator is active");
            } else
            {
                Console.WriteLine("No screen reader detected");
            }*/
        }

        public List<ScreenReaderItem> GetActiveScreenReader()
        {
            return activeScreenReaders;
        }

    }
}

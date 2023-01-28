using System;
using System.Windows.Forms;

namespace Launcher
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Console.WriteLine("Starting Launcher...");
            Application.Run(new Forms.Launcher());
        }
    }
}

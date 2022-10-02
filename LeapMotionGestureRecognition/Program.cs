using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leap;

namespace LeapMotionGestureRecognition
{
    public class Program
    {
        static void Main()
        {
            //create listener and controller
            Controller controller = new Controller();
            LeapListener listener = new LeapListener();
            controller.AddListener(listener);

            // Keep this process running until Enter is pressed
            Console.WriteLine("Press Enter to quit...");
            Console.ReadLine();

            controller.RemoveListener(listener);
            controller.Dispose();
        }


    }
}

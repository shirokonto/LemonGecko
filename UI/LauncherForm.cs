using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using GestureRecognition;

namespace Launcher
{
    public partial class LauncherForm : Form
    {
        // Fields
        private static readonly Queue<ItemToPrint> PrintQueue = new Queue<ItemToPrint>();
        private static LeapListener gestureMapper;

        // Constructor
        public LauncherForm()
        {
            InitializeComponent();
            InitializeBackgroundWorker();            
        }

        // Set up the BackgroundWorker object by attaching event handlers.
        private void InitializeBackgroundWorker()
        {
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;

            backgroundWorker.DoWork +=
                new DoWorkEventHandler(BackgroundWorker_DoWork);
            backgroundWorker.ProgressChanged +=
                new ProgressChangedEventHandler(BackgroundWorker_ProgressChanged);
            backgroundWorker.RunWorkerCompleted +=
                new RunWorkerCompletedEventHandler(
            BackgroundWorker_RunWorkerCompleted);
        }

        private void StartGestureControlButton_Click(Object sender, EventArgs e)
        {
            gestureMapper = new LeapListener();

            // Reset the text in the result box.
            gestureDetectionConsole.Clear();

            // Disable the Start button until the asynchronous operation is done.
            this.startGestureControlButton.Enabled = false;

            // Enable the Cancel button while the asynchronous operation runs.
            this.stopGestureControlButton.Enabled = true;



            for (int i = 0; i <= 10; i++)
            {
                AddItemToPrintQueue(i.ToString());
            }

            // Start the asynchronous operation.
            backgroundWorker.RunWorkerAsync();
        }

        private void StopGestureControlButton_Click(Object sender, EventArgs e)
        {
            // Cancel the asynchronous operation.
            backgroundWorker.CancelAsync();

            // Disable the Cancel button.
            stopGestureControlButton.Enabled = false;
        }
                
        // This event handler is where the actual, potentially time-consuming work is done.
        private void BackgroundWorker_DoWork(object sender,
            DoWorkEventArgs e)
        {
            // Get the BackgroundWorker that raised this event.
            BackgroundWorker worker = sender as BackgroundWorker;
             
            Console.WriteLine("Do work...");

            while (!worker.CancellationPending)
            {
                //Prevent writing to queue while we are reading /editing it
                lock (PrintQueue)
                {
                    if(PrintQueue.Count > 0)
                    {
                        ItemToPrint item = PrintQueue.Dequeue();
                        Print(item.GetPrintText());
                    }
                   
                    //gestureMapper.CircleDetected += HandleCircle;
                }
            }
        }
        private void HandleCircle(object sender, GestureRecognition.Events.CircleEvent circle)
        {
            Console.WriteLine("CircleEventReceived");
            Print("CircleEventReceived");
        }

        private void Print(string item)
        {
            gestureDetectionConsole.Invoke(new Action(() =>
            {
                gestureDetectionConsole.AppendText(item);
                gestureDetectionConsole.AppendText(Environment.NewLine);
            }));            
        }

        private void AddItemToPrintQueue(string number)
        {
            ItemToPrint item = new ItemToPrint(" Gesture " + number);
            lock (PrintQueue)
            {
                PrintQueue.Enqueue(item);
            }
        }

        //Maybe not needed since we don't report a progress
        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ItemToPrint item = e.UserState as ItemToPrint;
            Print(item.GetPrintText());
        }

        // This event handler deals with the results of the
        // background operation.
        private void BackgroundWorker_RunWorkerCompleted(
            object sender, RunWorkerCompletedEventArgs e)
        {
            // First, handle the case where an exception was thrown.
            if (e.Error != null)
            {
                // There was an error during the operation.
                string msg = String.Format("An error occurred: {0}", e.Error.Message);
                MessageBox.Show(msg);
            }
            else if (e.Cancelled)
            {
                // Next, handle the case where the user canceled the operation.
                // Note that due to a race condition in the DoWork event handler, the Cancelled
                // flag may not have been set, even though CancelAsync was called.
                MessageBox.Show("Operation was canceled");
            }
            else
            {
                // Finally, handle the case where the operation succeeded.
                string msg = String.Format("Result = {0}", e.Result);
            }

            // Enable the Start button.
            startGestureControlButton.Enabled = true;
            // Disable the Cancel button.
            stopGestureControlButton.Enabled = false;
        }
    }
}

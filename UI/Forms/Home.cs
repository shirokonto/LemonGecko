using System;
using System.Linq;
using System.Windows.Forms;
using GestureRecognition;
using System.Runtime.InteropServices;

namespace Launcher.Forms
{
    public partial class Home : Form
    {
        private static LeapListener listener;
        private ScreenReaderDetection activeScreenReaders;
        private ScreenReaderItem currentScreenReader;
        private bool controllerConnected;
        private bool sessionInProgress = false;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        private const int CB_SETCUEBANNER = 0x1703;

        // Constructor
        public Home()
        {
            listener = new LeapListener();
            InitializeComponent();
            InitializeScreenReaderSettings();
        }

        private void InitializeScreenReaderSettings()
        {
            FillScreenReaderComboBox();
            CheckControllerState();
        }

        private void FillScreenReaderComboBox()
        {
            activeScreenReaders = new ScreenReaderDetection();
            StopGestureControlButton.Enabled = false;
            if (!activeScreenReaders.GetAllScreenReaders().Any()) //if list is empty
            {
                if (ScreenReaderComboBox.Items.Count != 0)
                {
                    ScreenReaderComboBox.Items.Clear();
                    currentScreenReader = null;
                }
                SendMessage(ScreenReaderComboBox.Handle, CB_SETCUEBANNER, 0, "No active screen reader");
                StartGestureControlButton.Enabled = false;                
            }
            else
            {
                foreach (ScreenReaderItem item in activeScreenReaders.GetAllScreenReaders())
                {
                    if (!ScreenReaderComboBox.Items.Contains(item.Name))
                    {
                        ScreenReaderComboBox.Items.Add(item.Name);
                    }
                }
                ScreenReaderComboBox.SelectedIndex = 0;
                currentScreenReader = activeScreenReaders.GetScreenReaderByName(ScreenReaderComboBox.SelectedItem.ToString());
            }
        }

        private void CheckControllerState()
        {
            controllerConnected = listener.IsControllerConnected();
            // TODO: add case: IF Controller is removed after refresh!!        
            if (controllerConnected)
            {
                LeapMotionStateTxt.Text = "Connected";
            }
            else
            {
                LeapMotionStateTxt.Text = "Not Connected";
                StartGestureControlButton.Enabled = false;
            }
        }

        /**
        * HANDLE EVENTS 
        */
        private void HandleCircle(object sender, GestureRecognition.Events.CircleEvent circleEvent)
        {
            Console.WriteLine("Circle event received");
            if(circleEvent.Circle.Pointable.Direction.AngleTo(circleEvent.Circle.Normal) <= Math.PI/2)
            {
                //clockwise
                Console.WriteLine("Clockwise");
            } else
            {
                //counter clockwise
                Console.WriteLine("Counter Clockwise");
            }
        }

        private void HandleHandSwipe(object sender, GestureRecognition.Events.HandSwipeEvent handSwipeEvent)
        {
            Console.WriteLine("Hand Swipe event received");
            
            if (handSwipeEvent.Swipe.Direction.Equals(GestureRecognition.Gestures.HandSwipe.SwipeDirection.RIGHT))
            {
                Console.WriteLine("Next");
                SendKeys.SendWait(currentScreenReader.HandSwipeRight);
            }
            else if(handSwipeEvent.Swipe.Direction.Equals(GestureRecognition.Gestures.HandSwipe.SwipeDirection.LEFT))
            {
                Console.WriteLine("Previous");
                //+ is shift
                SendKeys.SendWait(currentScreenReader.HandSwipeLeft);
            }
            else if(handSwipeEvent.Swipe.Direction.Equals(GestureRecognition.Gestures.HandSwipe.SwipeDirection.UP))
            {
                Console.WriteLine("UP");
                SendKeys.SendWait(currentScreenReader.HandSwipeUp);
            } else
            {
                Console.WriteLine("DOWN");
                SendKeys.SendWait(currentScreenReader.HandSwipeDown);
            }
        }

        private void HandleScreenTap(object sender, GestureRecognition.Events.ScreenTapEvent screenTapEvent)
        {
            Console.WriteLine("Screen Tap event received");
            SendKeys.SendWait(currentScreenReader.ScreenTap);
        }

        private void BackToNavBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            if (!sessionInProgress)
            {
                InitializeScreenReaderSettings();
                StartGestureControlButton.Enabled =
                    (controllerConnected && currentScreenReader != null) && controllerConnected;
            }
            else
            {
                MessageBox.Show("Stop current session first");
            }            
        }

        private void StartGestureControlButton_Click(object sender, EventArgs e)
        {
            if (currentScreenReader != null)
            {
                listener.CircleDetected += HandleCircle;
                listener.HandSwipeDetected += HandleHandSwipe;
                listener.ScreenTapDetected += HandleScreenTap;

                this.StartGestureControlButton.Enabled = false;
                this.StopGestureControlButton.Enabled = true;
                sessionInProgress = true;

                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.StartGestureControlSound);
                player.Play();
                this.ParentForm.WindowState = FormWindowState.Minimized;
            }
        }

        private void StopGestureControlButton_Click(object sender, EventArgs e)
        {
            listener.CircleDetected -= HandleCircle;
            listener.HandSwipeDetected -= HandleHandSwipe;
            listener.ScreenTapDetected -= HandleScreenTap;

            StopGestureControlButton.Enabled = false;
            StartGestureControlButton.Enabled = true;
            sessionInProgress = false;

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.StopGestureControlSound);
            player.Play();
        }

        private void ScreenReaderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ScreenReaderComboBox.SelectedItem != null)
            {
                currentScreenReader = activeScreenReaders.GetScreenReaderByName(ScreenReaderComboBox.SelectedItem.ToString());                
            }
        }
    }
}

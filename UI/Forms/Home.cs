using System;
using System.Linq;
using System.Windows.Forms;
using GestureRecognition;
using System.Runtime.InteropServices;

namespace Launcher.Forms
{
    public partial class Home : Form
    {
        private static LeapListener gestureMapper;
        private JsonParser jsonParser;
        private ScreenReaderDetection activeScreenReaders;
        private ScreenReaderItem currentScreenReader;
        private bool controllerConnected;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        private const int CB_SETCUEBANNER = 0x1703;

        // Constructor
        public Home()
        {
            gestureMapper = new LeapListener();
            jsonParser = new JsonParser();
            jsonParser.LoadJsonForKeyMapping();
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
            controllerConnected = gestureMapper.IsControllerConnected();
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
        private void HandleCircle(object sender, GestureRecognition.Events.CircleEvent circle)
        {
            Console.WriteLine("CircleEventReceived");
        }

        private void HandleHandSwipe(object sender, GestureRecognition.Events.HandSwipeEvent handSwipeEvent)
        {
            if (handSwipeEvent.Swipe.Hands.Count == 1)
            {
                if (handSwipeEvent.Swipe.Hands[0].IsLeft)
                {
                    Console.WriteLine("Hand Swipe event received LEFT");
                    if (handSwipeEvent.Swipe.Direction.Equals(GestureRecognition.Gestures.HandSwipe.SwipeDirection.RIGHT))
                    {
                        Console.WriteLine("Next");
                        SendKeys.SendWait(currentScreenReader.HandSwipeRight);
                    }
                    else if (handSwipeEvent.Swipe.Direction.Equals(GestureRecognition.Gestures.HandSwipe.SwipeDirection.LEFT))
                    {
                        Console.WriteLine("Previous");
                        //+ is shift
                        SendKeys.SendWait(currentScreenReader.HandSwipeLeft);
                    }
                }
                else if (handSwipeEvent.Swipe.Hands[0].IsRight)
                {
                    Console.WriteLine("Hand Swipe event received RIGHT");
                    if (handSwipeEvent.Swipe.Direction.Equals(GestureRecognition.Gestures.HandSwipe.SwipeDirection.RIGHT))
                    {
                        Console.WriteLine("Next");
                        //SendKeys.SendWait(currentScreenReader.RightHandSwipeRight);
                    }
                    else if (handSwipeEvent.Swipe.Direction.Equals(GestureRecognition.Gestures.HandSwipe.SwipeDirection.LEFT))
                    {
                        Console.WriteLine("Previous");
                        //+ is shift
                        //SendKeys.SendWait(currentScreenReader.RightHandSwipeLeft);
                    }
                }
            }
            else
            {
                Console.WriteLine("Hand Swipe event received BOTH or null");
            }
        }

        private void HandleFingerSwipe(object sender, GestureRecognition.Events.FingerSwipeEvent fingerSwipeEvent)
        {
            Console.WriteLine("Finger Swipe event received");
        }

        private void HandleScreenTap(object sender, GestureRecognition.Events.ScreenTapEvent screenTapEvent)
        {

            if (screenTapEvent.ScreenTap.Hands[0].IsRight)
            {
                Console.WriteLine("Screen Tap event received with right hand");
                SendKeys.SendWait(currentScreenReader.ScreenTap);
            }
        }

        private void HandleZoomIn(object sender, GestureRecognition.Events.ZoomInEvent zoomInEvent)
        {
            Console.WriteLine("Zoom In event received");
        }

        private void HandleZoomOut(object sender, GestureRecognition.Events.ZoomOutEvent zoomOutEvent)
        {
            Console.WriteLine("Zoom Out event received");
        }


        private void BackToNavBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            InitializeScreenReaderSettings();
            StartGestureControlButton.Enabled = 
                (controllerConnected && currentScreenReader != null) && controllerConnected;
        }

        private void StartGestureControlButton_Click(object sender, EventArgs e)
        {
            if (currentScreenReader != null)
            {
                gestureMapper.CircleDetected += HandleCircle;
                gestureMapper.HandSwipeDetected += HandleHandSwipe;
                gestureMapper.FingerSwipeDetected += HandleFingerSwipe;
                gestureMapper.ScreenTapDetected += HandleScreenTap;
                gestureMapper.ZoomInDetected += HandleZoomIn;
                gestureMapper.ZoomOutDetected += HandleZoomOut;

                this.StartGestureControlButton.Enabled = false;
                this.StopGestureControlButton.Enabled = true;

                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.StartGestureControlSound);
                player.Play();
                this.ParentForm.WindowState = FormWindowState.Minimized;
            }
        }

        private void StopGestureControlButton_Click(object sender, EventArgs e)
        {
            gestureMapper.CircleDetected -= HandleCircle;
            gestureMapper.HandSwipeDetected -= HandleHandSwipe;
            gestureMapper.FingerSwipeDetected -= HandleFingerSwipe;
            gestureMapper.ScreenTapDetected -= HandleScreenTap;
            gestureMapper.ZoomInDetected -= HandleZoomIn;
            gestureMapper.ZoomOutDetected -= HandleZoomOut;

            StopGestureControlButton.Enabled = false;
            StartGestureControlButton.Enabled = true;

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

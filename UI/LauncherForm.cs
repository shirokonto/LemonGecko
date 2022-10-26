using System;
using System.Linq;
using System.Windows.Forms;
using GestureRecognition;

namespace Launcher
{
    public partial class LauncherForm : Form
    {
        private static LeapListener gestureMapper;
        private ScreenReaderDetection activeScreenReaders;
        private ScreenReaderItem currentScreenReader;
        private bool controllerConnected;

        private const int CB_SETCUEBANNER = 0x1703;
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam);

        // Constructor
        public LauncherForm()
        {
            gestureMapper = new LeapListener();
            InitializeComponent();
            InitializeScreenReaderSettings();
            CsvParser parser = new CsvParser();
        }

        private void InitializeScreenReaderSettings()
        {
            FillScreenReaderComboBox();
            SetKeyMappings();
            CheckControllerState();
        }
       
        private void FillScreenReaderComboBox()
        {
            activeScreenReaders = new ScreenReaderDetection();
            if (!activeScreenReaders.GetAllScreenReaders().Any()) //if list is empty
            {
                if (ScreenReaderComboBox.Items.Count != 0)
                {
                    ScreenReaderComboBox.Items.Clear();
                    currentScreenReader = null;
                }
                SendMessage(ScreenReaderComboBox.Handle, CB_SETCUEBANNER, 0, "No active screen reader");
                startGestureControlButton.Enabled = false;
                EnableButtons(false);

            } else
            {
                foreach (ScreenReaderItem item in activeScreenReaders.GetAllScreenReaders())
                {
                    if (!ScreenReaderComboBox.Items.Contains(item.ScreenReaderName))
                    {
                        ScreenReaderComboBox.Items.Add(item.ScreenReaderName);
                    }                    
                }
                ScreenReaderComboBox.SelectedIndex = 0;
                EnableButtons(true);
                currentScreenReader = activeScreenReaders.GetScreenReaderByName(ScreenReaderComboBox.SelectedItem.ToString());
            }            
        }

        private void EnableButtons(bool enabled)
        {
            ScreenTapMappingBtn.Enabled = enabled;
            SwipeLeftMappingBtn.Enabled = enabled;
            SwipeRightMappingBtn.Enabled = enabled;
        }
        private void SetKeyMappings()
        {
            if (currentScreenReader != null)
            {                
                KeyMapping.Text = "Key Mapping for " + currentScreenReader.ScreenReaderName;
                //get data from csv
                ScreenTapMappingLabel.Text = "Screen Tap:[KEY]" + currentScreenReader.GetKeyStrokeMapping(ScreenReaderItem.Gesture.SCREENTAP);
            } else
            {
                KeyMapping.Text = "Refresh for Key Mapping";
            }            
        }

        private void CheckControllerState()
        {
            //if controller is not connected gray out start and state that it is not connected
            controllerConnected = gestureMapper.IsControllerConnected();    //TODO: add case: IF Controller is removed after refresh!!        
            if(controllerConnected)
            {
                LeapMotionStateLabel.Text = "Leap Motion Connected";               
            }
            else
            {
                LeapMotionStateLabel.Text = "Leap Motion Controller Not Found";                
            }            
        }

        /*
        * UI ELEMENETS
        */
        private void StartGestureControlButton_Click(Object sender, EventArgs e)
        {
            //TODO: see if gestureMapper is connected
            //TODO: if listener is not active or no screenreader is detected
            gestureMapper.CircleDetected += HandleCircle;
            gestureMapper.HandSwipeDetected += HandleHandSwipe;
            gestureMapper.FingerSwipeDetected += HandleFingerSwipe;
            gestureMapper.ScreenTapDetected += HandleScreenTap;
            gestureMapper.ZoomInDetected += HandleZoomIn;
            gestureMapper.ZoomOutDetected += HandleZoomOut;

            this.startGestureControlButton.Enabled = false;
            this.stopGestureControlButton.Enabled = true;

            //notice user that gesture starts            
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.mixkit_quick_win_video_game_notification_269);
            player.Play();
            //minimize window
            this.WindowState = FormWindowState.Minimized;
        }

        private void StopGestureControlButton_Click(Object sender, EventArgs e)
        {
            stopGestureControlButton.Enabled = false;
            startGestureControlButton.Enabled = true;
            //notice user that gesture stops
            //TODO: different sound
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.mixkit_quick_win_video_game_notification_269);
            player.Play();
            //TODO: end leap support
        }

        private void ScreenReaderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {           
            if(ScreenReaderComboBox.SelectedItem != null)
            {
                currentScreenReader = activeScreenReaders.GetScreenReaderByName(ScreenReaderComboBox.SelectedItem.ToString());
                if(currentScreenReader != null)
                {
                    KeyMapping.Text = "Key Mapping for " + currentScreenReader.ScreenReaderName;
                }                
            }
            
            // activeScreenReaders
            // TODO: map gesture to keys -> keyset??
        }

        private void RefreshListBtn_Click(object sender, EventArgs e)
        {
            InitializeScreenReaderSettings();
            if (controllerConnected && currentScreenReader != null)
            {
                startGestureControlButton.Enabled = controllerConnected;
            } else
            {
                startGestureControlButton.Enabled = false;
            }
        }

        /**
         * HANDLE EVENTS 
         */
        private void HandleCircle(object sender, GestureRecognition.Events.CircleEvent circle)
        {
            Console.WriteLine("CircleEventReceived");
        }

        private static void HandleHandSwipe(object sender, GestureRecognition.Events.HandSwipeEvent handSwipeEvent)
        {
            Console.WriteLine("Hand Swipe event received");
            if (handSwipeEvent.Swipe.Direction.Equals(GestureRecognition.Gestures.HandSwipe.SwipeDirection.RIGHT))
            {
                Console.WriteLine("Next");
                //currentScreenReader GetSwipeRightKey
                //SendKeys.SendWait(currentScreenReader.SwipeRight)
                //
                //GestureKeystrokeMapping

                SendKeys.SendWait("{TAB}");
            }
            else if (handSwipeEvent.Swipe.Direction.Equals(GestureRecognition.Gestures.HandSwipe.SwipeDirection.LEFT))
            {
                Console.WriteLine("Previous");
                //+ is shift
                SendKeys.SendWait("+{TAB}");
            }
        }

        private void HandleFingerSwipe(object sender, GestureRecognition.Events.FingerSwipeEvent fingerSwipeEvent)
        {
            Console.WriteLine("Finger Swipe event received");
        }

        private void HandleScreenTap(object sender, GestureRecognition.Events.ScreenTapEvent screenTapEvent)
        {
            Console.WriteLine("Screen Tap event received");
            bool bo = screenTapEvent.ScreenTap.Hands[0].IsRight;
            //SendKeys.SendWait("{ENTER}");
        }

        private void HandleZoomIn(object sender, GestureRecognition.Events.ZoomInEvent zoomInEvent)
        {
            Console.WriteLine("Zoom In event received");
        }

        private void HandleZoomOut(object sender, GestureRecognition.Events.ZoomOutEvent zoomOutEvent)
        {
            Console.WriteLine("Zoom Out event received");
        }

        
    }
}

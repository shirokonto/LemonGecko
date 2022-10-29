﻿using System;
using System.Linq;
using System.Windows.Forms;
using GestureRecognition;
using System.Runtime.InteropServices;

namespace Launcher
{
    public partial class LauncherForm : Form
    {
        public event Action simpleEvent;
        private static LeapListener gestureMapper;
        private ScreenReaderDetection activeScreenReaders;
        private ScreenReaderItem currentScreenReader;
        private bool controllerConnected;
        private const int CB_SETCUEBANNER = 0x1703;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        // Constructor
        public LauncherForm()
        {
            gestureMapper = new LeapListener();
            simpleEvent += () => MyMethod();
            InitializeComponent();
            InitializeScreenReaderSettings();
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
                ScreenTapMappingLabel.Text = "Screen Tap:" + currentScreenReader.GestureMapping.ScreenTap;
                SwipeRightMappingLabel.Text = "Swipe Right:" + currentScreenReader.GestureMapping.HandSwipeRight;
                SwipeLeftMappingLabel.Text = "Swipe Left:" + currentScreenReader.GestureMapping.HandSwipeLeft;
            } else
            {
                KeyMapping.Text = "Refresh for Key Mapping";
                ScreenTapMappingLabel.Text = "Screen Tap";
                SwipeRightMappingLabel.Text = "Swipe Right";
                SwipeLeftMappingLabel.Text = "Swipe Left";
            }            
        }

        private void CheckControllerState()
        {
            controllerConnected = gestureMapper.IsControllerConnected();    
            // TODO: add case: IF Controller is removed after refresh!!        
            if(controllerConnected)
            {
                LeapMotionStateLabel.Text = "Leap Motion Connected";               
            }
            else
            {
                LeapMotionStateLabel.Text = "Leap Motion Not Connected";
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

        private void HandleHandSwipe(object sender, GestureRecognition.Events.HandSwipeEvent handSwipeEvent)
        {
            Console.WriteLine("Hand Swipe event received");
            if (handSwipeEvent.Swipe.Direction.Equals(GestureRecognition.Gestures.HandSwipe.SwipeDirection.RIGHT))
            {
                Console.WriteLine("Next");
                if (currentScreenReader != null)
                {
                    SendKeys.SendWait(currentScreenReader.GestureMapping.HandSwipeRight);
                }
            }
            else if (handSwipeEvent.Swipe.Direction.Equals(GestureRecognition.Gestures.HandSwipe.SwipeDirection.LEFT))
            {
                Console.WriteLine("Previous");
                //+ is shift
                SendKeys.SendWait(currentScreenReader.GestureMapping.HandSwipeLeft);
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
                SendKeys.SendWait(currentScreenReader.GestureMapping.ScreenTap);
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

        /*
        * UI ELEMENETS
        */
        private void StartGestureControlButton_Click(Object sender, EventArgs e)
        {
            gestureMapper.CircleDetected += HandleCircle;
            gestureMapper.HandSwipeDetected += HandleHandSwipe;
            gestureMapper.FingerSwipeDetected += HandleFingerSwipe;
            gestureMapper.ScreenTapDetected += HandleScreenTap;
            gestureMapper.ZoomInDetected += HandleZoomIn;
            gestureMapper.ZoomOutDetected += HandleZoomOut;

            this.startGestureControlButton.Enabled = false;
            this.stopGestureControlButton.Enabled = true;
          
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.StartGestureControlSound);
            player.Play();
            this.WindowState = FormWindowState.Minimized;
        }

        private void StopGestureControlButton_Click(Object sender, EventArgs e)
        {
            gestureMapper.CircleDetected -= HandleCircle;
            gestureMapper.HandSwipeDetected -= HandleHandSwipe;
            gestureMapper.FingerSwipeDetected -= HandleFingerSwipe;
            gestureMapper.ScreenTapDetected -= HandleScreenTap;
            gestureMapper.ZoomInDetected -= HandleZoomIn;
            gestureMapper.ZoomOutDetected -= HandleZoomOut;
            stopGestureControlButton.Enabled = false;
            startGestureControlButton.Enabled = true;

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.StopGestureControlSound);
            player.Play();
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

        private void ScreenTapMappingBtn_Click(object sender, EventArgs e)
        {
            // listen to keystroke(s)
            Button button = (Button)sender;
            ScreenTapTxtBox.Text = "button clicked";
            if (simpleEvent != null) simpleEvent();            
            //MessageBox.Show(button.Name);
            // map new key to gesture
            // currentScreenReader.
        }

        private void MyMethod()
        {
            // TODO Remove 
            //listen to key input???  
            Console.Read();
        }

        private void SwipeRightMappingBtn_Click(object sender, EventArgs e)
        {

        }

        private void SwipeLeftMappingBtn_Click(object sender, EventArgs e)
        {

        }

        private void ScreenTapTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            // TODO: map incoming key and 
            // TODO: if no screenreader is active: gray out or something
            //incoming keys are these: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.keys?view=windowsdesktop-7.0
            //(Keys Enum)
            // TAP cannot be used since the user springs to the next item!
            ScreenTapTxtBox.Text = e.KeyCode.ToString();
            if(currentScreenReader != null)
            {
                currentScreenReader.GestureMapping.ScreenTap = e.KeyCode.ToString();
                Console.WriteLine(currentScreenReader.GestureMapping.ScreenTap);
            }
            
        }
    }
}
﻿using System;
using System.Linq;
using System.Windows.Forms;
using GestureRecognition;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Launcher
{
    public partial class LauncherForm : Form
    {
        private static LeapListener gestureMapper;
        private ScreenReaderDetection activeScreenReaders;
        private ScreenReaderItem currentScreenReader;
        private bool controllerConnected;
        private const int CB_SETCUEBANNER = 0x1703;
        private JsonParser jsonParser;
        private Regex alphaNumRegex = new Regex("^[a-zA-Z][a-zA-Z0-9]*$");
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        // Constructor
        public LauncherForm()
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
                    if (!ScreenReaderComboBox.Items.Contains(item.Name))
                    {
                        ScreenReaderComboBox.Items.Add(item.Name);
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
                KeyMappingGroupBox.Text = "Key Mapping for " + currentScreenReader.Name;
                KeyMappingGroupBox.Text = "Key Mapping for " + currentScreenReader.Name;

                ScreenTapMappingLabel.Text = "Screen Tap:" + currentScreenReader.ScreenTap;
                SwipeRightMappingLabel.Text = "Swipe Right:" + currentScreenReader.HandSwipeRight;
                SwipeLeftMappingLabel.Text = "Swipe Left:" + currentScreenReader.HandSwipeLeft;
            } else
            {
                KeyMappingGroupBox.Text = "Refresh for Key Mapping";
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
                LeapMotionStateTxt.Text = "Connected";               
            }
            else
            {
                LeapMotionStateTxt.Text = "Not Connected";
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
            if(handSwipeEvent.Swipe.Hands.Count == 1)
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
            } else
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

        /*
        * UI ELEMENETS
        */
        private void StartGestureControlButton_Click(Object sender, EventArgs e)
        {
            if(currentScreenReader != null)
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
                    KeyMappingGroupBox.Text = "Key Mapping for " + currentScreenReader.Name;
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
        }

        private void SwipeRightMappingBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void SwipeLeftMappingBtn_Click(object sender, EventArgs e)
        {

        }

        private void ScreenTapTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            ScreenTapTxtBox.Text = e.KeyCode.ToString();
            if (currentScreenReader != null)
            {
                currentScreenReader.ScreenTap = SetNewKey(e.KeyCode.ToString());
                jsonParser.SaveChangesToJson(currentScreenReader);
                SetKeyMappings();
            }
        }

        private void SwipeRightTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            SwipeRightTxtBox.Text = e.KeyCode.ToString();
            if (currentScreenReader != null)
            {
                currentScreenReader.HandSwipeRight = SetNewKey(e.KeyCode.ToString());
                jsonParser.SaveChangesToJson(currentScreenReader);
                SetKeyMappings();
            }
        }

        private void SwipeLeftTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            SwipeLeftTxtBox.Text = e.KeyCode.ToString();
            if(currentScreenReader != null)
            {
                currentScreenReader.HandSwipeLeft = SetNewKey(e.KeyCode.ToString());
                jsonParser.SaveChangesToJson(currentScreenReader);
                SetKeyMappings();
            }            
        }

        private string SetNewKey(string keyCode)
        {
            //incoming keys are: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.keys?view=windowsdesktop-7.0
            //(Keys Enum)
            // TAP cannot be used since the user springs to the next item!
            //special keys:
            // left [alt] is menu -> SendKeys.Send("+({F10})");
            // right [alt gr] key -> ControlKey (keys.Control | Keys.Alt ) )
            //(if not alphabet -> {} is used https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.sendkeys.send?view=windowsdesktop-7.0
            if (keyCode.Length > 1 || !alphaNumRegex.IsMatch(keyCode))
            {
                KeyCodeObj mapping = jsonParser.GetCodeForKey(keyCode.ToUpper());
                if (mapping != null)
                {
                    return mapping.Code;
                }
            }
            return keyCode;
        }

        private void OpenNewLauncherBtn_Click(object sender, EventArgs e)
        {
            Launcher launcher = new Launcher();
            launcher.Show();
        }
    }
}

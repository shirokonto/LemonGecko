using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestureRecognition;

namespace Launcher
{
    public partial class LauncherForm : Form
    {
        private static LeapListener gestureMapper;
        private ScreenReaderDetection activeScreenReaders;
        private bool controllerConnected;

        private const int CB_SETCUEBANNER = 0x1703;
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam);

        // Constructor
        public LauncherForm()
        {            
            InitializeComponent();
            FillUpComboBox();
            //TODO: does not work since it is not async
            CheckControllerState();
        }

        private void CheckControllerState()
        {
            gestureMapper = new LeapListener();
            //if controller is not connected gray out start and say that it is not connected
            controllerConnected = gestureMapper.IsControllerConnected();
            startGestureControlButton.Enabled = controllerConnected;
            if (!controllerConnected)
            {
                LeapMotionStateLabel.Text = "Leap Motion Controller Not Found";
            }
        }

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
            //TODO: end leap support
        }

        private void ScreenReaderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if a different screenreader is selected --> map to those keys
        }

        private void FillUpComboBox()
        {
            activeScreenReaders = new ScreenReaderDetection();
            if (!activeScreenReaders.GetActiveScreenReader().Any()) //if list is empty
            {
                SendMessage(ScreenReaderComboBox.Handle, CB_SETCUEBANNER, 0, "No active screen reader");
            } else
            {
                foreach (ScreenReaderItem item in activeScreenReaders.GetActiveScreenReader())
                {
                    ScreenReaderComboBox.Items.Add(item.ScreenReaderName);
                }
                ScreenReaderComboBox.SelectedIndex = 0;
            }            
        }

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
            //" " i space key
            //Keys key = Keys.Space;
            //SendKeys.SendWait("{SPACE}");
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

using System;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Launcher.Forms
{
    public partial class Home : Form
    {
        private GestureMapper mapper;
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
            mapper = new GestureMapper();
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
            if (!activeScreenReaders.GetAllScreenReaders().Any()) //if list is empty
            {
                if (ScreenReaderComboBox.Items.Count != 0)
                {
                    ScreenReaderComboBox.Items.Clear();
                    currentScreenReader = null;
                }
                SendMessage(ScreenReaderComboBox.Handle, CB_SETCUEBANNER, 0, "No active screen reader");               
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
                mapper.SetCurrentScreenReader(currentScreenReader);
            }
        }

        private void CheckControllerState()
        {
            controllerConnected = mapper.GetControllerState();
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

        private void BackToMenuBtn_Click(object sender, EventArgs e)
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
                MessageBox.Show("Stop current session first"); //TODO Add accessibility settings
            }            
        }

        private void StartGestureControlButton_Click(object sender, EventArgs e)
        {
            if (sessionInProgress)
            {
                MessageBox.Show("Stop current session first");
                return;
            }
            if (currentScreenReader != null)
            {
                mapper.StartGestureControl();
                sessionInProgress = true;

                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.StartGestureControlSound);
                player.Play();
                this.ParentForm.WindowState = FormWindowState.Minimized;
            }
        }

        private void StopGestureControlButton_Click(object sender, EventArgs e)
        {
            if (!sessionInProgress)
            {
                MessageBox.Show("Start a new session first");
            } else
            {
                mapper.StopGestureControl();
                //TODO how to remove listener?

                sessionInProgress = false;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.StopGestureControlSound);
                player.Play();
            }            
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

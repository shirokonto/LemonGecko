using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Launcher.Forms
{
    /// <summary>
    /// The partial class <c>Settings</c> represents the displayed Settings view and the underlying logic in the User Interface.
    /// </summary>
    public partial class Settings : Form
    {
        private JsonParser jsonParser;
        private KeyCodeMappingHelper keyCodeMappingHelper;
        private List<ScreenReaderItem> allScreenReader;
        private ScreenReaderItem selectedScreenReader;
        private ScreenReaderItem defaultScreenReaderSettings;
        private bool TextWasChanged = false;

        /// <summary>
        /// Constructs a new <c>Settings</c> Object and initializing the needed user interface components for the view.
        /// </summary>
        public Settings()
        {
            InitializeComponent();
            keyCodeMappingHelper = new KeyCodeMappingHelper();
            jsonParser = new JsonParser();
            jsonParser.LoadJsonForKeyToGestureMapping();
            jsonParser.LoadJsonForKeyToCodeMapping();            
            LoadScreenReaderComboBox();
            LoadKeyMappings(selectedScreenReader);
        }

        private void LoadScreenReaderComboBox()
        {
            allScreenReader = jsonParser.GetAllScreenReader();
            foreach (ScreenReaderItem item in allScreenReader)
            {
                if (!ScreenReaderComboBox.Items.Contains(item.Name))
                {
                    ScreenReaderComboBox.Items.Add(item.Name);
                }
            }
            ScreenReaderComboBox.SelectedIndex = 0;
            selectedScreenReader = allScreenReader.Where(item => item.Name.Equals(ScreenReaderComboBox.SelectedItem.ToString())).First();
            defaultScreenReaderSettings = selectedScreenReader;
        }

        private void LoadKeyMappings(ScreenReaderItem screenreader)
        {
            FillTextboxes(ScreenTapTextBox, ScreenTapTextBox2, screenreader.ScreenTap);
            FillTextboxes(SwipeRightTextBox, SwipeRightTextBox2, screenreader.HandSwipeRight);
            FillTextboxes(SwipeLeftTextBox, SwipeLeftTextBox2, screenreader.HandSwipeLeft);
            FillTextboxes(SwipeUpTextBox, SwipeUpTextBox2, screenreader.HandSwipeUp);
            FillTextboxes(SwipeDownTextBox, SwipeDownTextBox2, screenreader.HandSwipeDown);
            FillTextboxes(CircleClockwiseTextBox, CircleClockwiseTextBox2, screenreader.CircleClockwise);
            FillTextboxes(CircleCounterClockwiseTextBox, CircleCounterClockwiseTextBox2, screenreader.CircleCounterClockwise);
            FillTextboxes(PunchTextBox, PunchTextBox2, screenreader.Punch);
        }

        private void FillTextboxes(TextBox firstBox, TextBox secondBox, string gesture)
        {
            firstBox.ReadOnly = true;
            secondBox.ReadOnly = true;
            List<string> commands = keyCodeMappingHelper.GetKeysForCode(gesture);
            if(commands.Count != 0)
            {
                firstBox.Text = commands[0];
                secondBox.Clear();
                if (commands.Count == 2)
                    secondBox.Text = commands[1];
            }
        }

        private void ScreenReaderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedScreenReader = allScreenReader.Where(item => item.Name.Equals(ScreenReaderComboBox.SelectedItem.ToString())).First();
            defaultScreenReaderSettings = selectedScreenReader;
            LoadKeyMappings(selectedScreenReader);
        }

        private void BackToMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //see if the entries where changed
            selectedScreenReader.ScreenTap = keyCodeMappingHelper.GetCodeForKey(ScreenTapTextBox.Text, ScreenTapTextBox2.Text);
            selectedScreenReader.HandSwipeRight = keyCodeMappingHelper.GetCodeForKey(SwipeRightTextBox.Text, SwipeRightTextBox2.Text);
            selectedScreenReader.HandSwipeLeft = keyCodeMappingHelper.GetCodeForKey(SwipeLeftTextBox.Text,SwipeLeftTextBox2.Text);
            selectedScreenReader.HandSwipeUp = keyCodeMappingHelper.GetCodeForKey(SwipeUpTextBox.Text, SwipeUpTextBox2.Text);
            selectedScreenReader.HandSwipeDown = keyCodeMappingHelper.GetCodeForKey(SwipeDownTextBox.Text, SwipeDownTextBox2.Text);
            selectedScreenReader.CircleClockwise = keyCodeMappingHelper.GetCodeForKey(CircleClockwiseTextBox.Text, CircleClockwiseTextBox2.Text);
            selectedScreenReader.CircleCounterClockwise = keyCodeMappingHelper.GetCodeForKey(CircleCounterClockwiseTextBox.Text, CircleCounterClockwiseTextBox2.Text);
            selectedScreenReader.Punch = keyCodeMappingHelper.GetCodeForKey(PunchTextBox.Text, PunchTextBox2.Text);
            //save changes
            jsonParser.SaveGestureMappingToJson(selectedScreenReader);
            defaultScreenReaderSettings = selectedScreenReader;
            LoadKeyMappings(selectedScreenReader);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //loads saved data from before the changes
            LoadKeyMappings(defaultScreenReaderSettings);
        }

        private void ChangeKeyInTextBox(object sender, PreviewKeyDownEventArgs e, TextBox currentTextbox)
        {
            if (currentTextbox.ReadOnly && (e.KeyCode.Equals(Keys.Enter) || e.KeyCode.Equals(Keys.Space)))
            {
                currentTextbox.ReadOnly = false;
                return;
            }
            if (!currentTextbox.ReadOnly)
            {                
                if ((e.KeyCode.Equals(Keys.Enter) || e.KeyCode.Equals(Keys.Space)) && TextWasChanged)
                {
                    currentTextbox.ReadOnly = true;
                    TextWasChanged = false;
                    return;
                }
                if (e.KeyCode.Equals(Keys.Space))
                {
                    currentTextbox.Text = "SPACE";
                    TextWasChanged = true;
                    return;
                }
                if (e.KeyCode.Equals(Keys.Return))
                {
                    currentTextbox.Text = "ENTER";
                    TextWasChanged = true;
                    return;
                }
                currentTextbox.Text = e.KeyCode.ToString().ToUpper();
                TextWasChanged = true;
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextWasChanged = true;
        }

        private void ScreenTapTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ChangeKeyInTextBox(sender, e, ScreenTapTextBox);
        }

        private void ScreenTapTextBox2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ChangeKeyInTextBox(sender, e, ScreenTapTextBox2);
        }

        private void SwipeRightTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ChangeKeyInTextBox(sender, e, SwipeRightTextBox);
        }

        private void SwipeRightTextBox2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ChangeKeyInTextBox(sender, e, SwipeRightTextBox2);
        }

        private void SwipeLeftTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ChangeKeyInTextBox(sender, e, SwipeLeftTextBox);            
        }

        private void SwipeLeftTextBox2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ChangeKeyInTextBox(sender, e, SwipeLeftTextBox2);
        }

        private void SwipeUpTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ChangeKeyInTextBox(sender, e, SwipeUpTextBox);
        }

        private void SwipeUpTextBox2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ChangeKeyInTextBox(sender, e, SwipeUpTextBox2);
        }

        private void SwipeDownTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ChangeKeyInTextBox(sender, e, SwipeDownTextBox);
        }

        private void SwipeDownTextBox2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ChangeKeyInTextBox(sender, e, SwipeDownTextBox2);
        }

        private void CircleClockwiseTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ChangeKeyInTextBox(sender, e, CircleClockwiseTextBox);
        }

        private void CircleClockwiseTextBox2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ChangeKeyInTextBox(sender, e, CircleClockwiseTextBox2);
        }

        private void CircleCounterClockwiseTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ChangeKeyInTextBox(sender, e, CircleCounterClockwiseTextBox);
        }

        private void CircleCounterClockwiseTextBox2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ChangeKeyInTextBox(sender, e, CircleCounterClockwiseTextBox2);
        }

        private void PunchTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ChangeKeyInTextBox(sender, e, PunchTextBox);
        }

        private void PunchTextBox2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ChangeKeyInTextBox(sender, e, PunchTextBox2);
        }
    }
}

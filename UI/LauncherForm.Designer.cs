
namespace Launcher
{
    partial class LauncherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startGestureControlButton = new System.Windows.Forms.Button();
            this.stopGestureControlButton = new System.Windows.Forms.Button();
            this.gestureControlLabel = new System.Windows.Forms.Label();
            this.KeyMapping = new System.Windows.Forms.Label();
            this.selectedScreenReader = new System.Windows.Forms.Label();
            this.ScreenReaderComboBox = new System.Windows.Forms.ComboBox();
            this.LeapMotionStateLabel = new System.Windows.Forms.Label();
            this.SwipeToLeftImage = new System.Windows.Forms.PictureBox();
            this.SwipeLeftMappingBtn = new System.Windows.Forms.Button();
            this.SwipeLeftMappingLabel = new System.Windows.Forms.Label();
            this.SwipeLeftPanel = new System.Windows.Forms.Panel();
            this.SwipeLeftTxtBox = new System.Windows.Forms.TextBox();
            this.SwipeRightPanel = new System.Windows.Forms.Panel();
            this.SwipeRightTxtBox = new System.Windows.Forms.TextBox();
            this.SwipeRightMappingLabel = new System.Windows.Forms.Label();
            this.SwipeRightMappingBtn = new System.Windows.Forms.Button();
            this.SwipeToRightImage = new System.Windows.Forms.PictureBox();
            this.ScreenTapPanel = new System.Windows.Forms.Panel();
            this.ScreenTapTxtBox = new System.Windows.Forms.TextBox();
            this.ScreenTapMappingLabel = new System.Windows.Forms.Label();
            this.ScreenTapMappingBtn = new System.Windows.Forms.Button();
            this.ScreenTapImage = new System.Windows.Forms.PictureBox();
            this.KeyMappingPanel = new System.Windows.Forms.Panel();
            this.GestureControlPanel = new System.Windows.Forms.Panel();
            this.ControllerScreenReaderStatePanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RefreshListBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SwipeToLeftImage)).BeginInit();
            this.SwipeLeftPanel.SuspendLayout();
            this.SwipeRightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SwipeToRightImage)).BeginInit();
            this.ScreenTapPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenTapImage)).BeginInit();
            this.KeyMappingPanel.SuspendLayout();
            this.GestureControlPanel.SuspendLayout();
            this.ControllerScreenReaderStatePanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startGestureControlButton
            // 
            this.startGestureControlButton.Location = new System.Drawing.Point(35, 66);
            this.startGestureControlButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startGestureControlButton.Name = "startGestureControlButton";
            this.startGestureControlButton.Size = new System.Drawing.Size(167, 23);
            this.startGestureControlButton.TabIndex = 24;
            this.startGestureControlButton.Text = "Start";
            this.startGestureControlButton.UseVisualStyleBackColor = true;
            this.startGestureControlButton.Click += new System.EventHandler(this.StartGestureControlButton_Click);
            // 
            // stopGestureControlButton
            // 
            this.stopGestureControlButton.Enabled = false;
            this.stopGestureControlButton.Location = new System.Drawing.Point(35, 93);
            this.stopGestureControlButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stopGestureControlButton.Name = "stopGestureControlButton";
            this.stopGestureControlButton.Size = new System.Drawing.Size(167, 23);
            this.stopGestureControlButton.TabIndex = 12;
            this.stopGestureControlButton.Text = "Stop";
            this.stopGestureControlButton.UseVisualStyleBackColor = true;
            this.stopGestureControlButton.Click += new System.EventHandler(this.StopGestureControlButton_Click);
            // 
            // gestureControlLabel
            // 
            this.gestureControlLabel.AutoSize = true;
            this.gestureControlLabel.Location = new System.Drawing.Point(35, 44);
            this.gestureControlLabel.Name = "gestureControlLabel";
            this.gestureControlLabel.Size = new System.Drawing.Size(100, 16);
            this.gestureControlLabel.TabIndex = 11;
            this.gestureControlLabel.Text = "Gesture Control";
            this.gestureControlLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // KeyMapping
            // 
            this.KeyMapping.AutoSize = true;
            this.KeyMapping.Location = new System.Drawing.Point(10, 12);
            this.KeyMapping.Name = "KeyMapping";
            this.KeyMapping.Size = new System.Drawing.Size(83, 20);
            this.KeyMapping.TabIndex = 5;
            this.KeyMapping.Text = "Key Mapping";
            this.KeyMapping.UseCompatibleTextRendering = true;
            // 
            // selectedScreenReader
            // 
            this.selectedScreenReader.AutoSize = true;
            this.selectedScreenReader.Location = new System.Drawing.Point(6, 54);
            this.selectedScreenReader.Name = "selectedScreenReader";
            this.selectedScreenReader.Size = new System.Drawing.Size(160, 16);
            this.selectedScreenReader.TabIndex = 2;
            this.selectedScreenReader.Text = "Selected Screen Reader:";
            // 
            // ScreenReaderComboBox
            // 
            this.ScreenReaderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScreenReaderComboBox.FormattingEnabled = true;
            this.ScreenReaderComboBox.Location = new System.Drawing.Point(172, 51);
            this.ScreenReaderComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ScreenReaderComboBox.Name = "ScreenReaderComboBox";
            this.ScreenReaderComboBox.Size = new System.Drawing.Size(122, 24);
            this.ScreenReaderComboBox.TabIndex = 3;
            this.ScreenReaderComboBox.SelectedIndexChanged += new System.EventHandler(this.ScreenReaderComboBox_SelectedIndexChanged);
            // 
            // LeapMotionStateLabel
            // 
            this.LeapMotionStateLabel.AccessibleDescription = "States if the Leap Motion Controller is plugged in";
            this.LeapMotionStateLabel.AccessibleName = "Leap Motion Controller State";
            this.LeapMotionStateLabel.AutoSize = true;
            this.LeapMotionStateLabel.Location = new System.Drawing.Point(6, 27);
            this.LeapMotionStateLabel.Name = "LeapMotionStateLabel";
            this.LeapMotionStateLabel.Size = new System.Drawing.Size(122, 16);
            this.LeapMotionStateLabel.TabIndex = 1;
            this.LeapMotionStateLabel.Text = "Leap Motion Status";
            // 
            // SwipeToLeftImage
            // 
            this.SwipeToLeftImage.AccessibleDescription = "Icon of a hand swiping to left";
            this.SwipeToLeftImage.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.SwipeToLeftImage.BackColor = System.Drawing.Color.Green;
            this.SwipeToLeftImage.Location = new System.Drawing.Point(4, 4);
            this.SwipeToLeftImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SwipeToLeftImage.Name = "SwipeToLeftImage";
            this.SwipeToLeftImage.Size = new System.Drawing.Size(43, 41);
            this.SwipeToLeftImage.TabIndex = 14;
            this.SwipeToLeftImage.TabStop = false;
            // 
            // SwipeLeftMappingBtn
            // 
            this.SwipeLeftMappingBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.SwipeLeftMappingBtn.Location = new System.Drawing.Point(115, 21);
            this.SwipeLeftMappingBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SwipeLeftMappingBtn.Name = "SwipeLeftMappingBtn";
            this.SwipeLeftMappingBtn.Size = new System.Drawing.Size(82, 23);
            this.SwipeLeftMappingBtn.TabIndex = 18;
            this.SwipeLeftMappingBtn.Text = "Map to key";
            this.SwipeLeftMappingBtn.UseVisualStyleBackColor = true;
            this.SwipeLeftMappingBtn.Click += new System.EventHandler(this.SwipeLeftMappingBtn_Click);
            // 
            // SwipeLeftMappingLabel
            // 
            this.SwipeLeftMappingLabel.AutoSize = true;
            this.SwipeLeftMappingLabel.Location = new System.Drawing.Point(52, 3);
            this.SwipeLeftMappingLabel.Name = "SwipeLeftMappingLabel";
            this.SwipeLeftMappingLabel.Size = new System.Drawing.Size(112, 16);
            this.SwipeLeftMappingLabel.TabIndex = 17;
            this.SwipeLeftMappingLabel.Text = "Swipe Left : [KEY]";
            // 
            // SwipeLeftPanel
            // 
            this.SwipeLeftPanel.Controls.Add(this.SwipeLeftTxtBox);
            this.SwipeLeftPanel.Controls.Add(this.SwipeLeftMappingLabel);
            this.SwipeLeftPanel.Controls.Add(this.SwipeLeftMappingBtn);
            this.SwipeLeftPanel.Controls.Add(this.SwipeToLeftImage);
            this.SwipeLeftPanel.Location = new System.Drawing.Point(10, 180);
            this.SwipeLeftPanel.Name = "SwipeLeftPanel";
            this.SwipeLeftPanel.Size = new System.Drawing.Size(248, 54);
            this.SwipeLeftPanel.TabIndex = 19;
            // 
            // SwipeLeftTxtBox
            // 
            this.SwipeLeftTxtBox.Location = new System.Drawing.Point(56, 21);
            this.SwipeLeftTxtBox.MaxLength = 2;
            this.SwipeLeftTxtBox.Name = "SwipeLeftTxtBox";
            this.SwipeLeftTxtBox.Size = new System.Drawing.Size(42, 22);
            this.SwipeLeftTxtBox.TabIndex = 24;
            this.SwipeLeftTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SwipeLeftTxtBox_KeyDown);
            // 
            // SwipeRightPanel
            // 
            this.SwipeRightPanel.Controls.Add(this.SwipeRightTxtBox);
            this.SwipeRightPanel.Controls.Add(this.SwipeRightMappingLabel);
            this.SwipeRightPanel.Controls.Add(this.SwipeRightMappingBtn);
            this.SwipeRightPanel.Controls.Add(this.SwipeToRightImage);
            this.SwipeRightPanel.Location = new System.Drawing.Point(10, 111);
            this.SwipeRightPanel.Name = "SwipeRightPanel";
            this.SwipeRightPanel.Size = new System.Drawing.Size(248, 51);
            this.SwipeRightPanel.TabIndex = 20;
            // 
            // SwipeRightTxtBox
            // 
            this.SwipeRightTxtBox.Location = new System.Drawing.Point(56, 21);
            this.SwipeRightTxtBox.MaxLength = 2;
            this.SwipeRightTxtBox.Name = "SwipeRightTxtBox";
            this.SwipeRightTxtBox.Size = new System.Drawing.Size(42, 22);
            this.SwipeRightTxtBox.TabIndex = 23;
            this.SwipeRightTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SwipeRightTxtBox_KeyDown);
            // 
            // SwipeRightMappingLabel
            // 
            this.SwipeRightMappingLabel.AutoSize = true;
            this.SwipeRightMappingLabel.Location = new System.Drawing.Point(52, 3);
            this.SwipeRightMappingLabel.Name = "SwipeRightMappingLabel";
            this.SwipeRightMappingLabel.Size = new System.Drawing.Size(122, 16);
            this.SwipeRightMappingLabel.TabIndex = 17;
            this.SwipeRightMappingLabel.Text = "Swipe Right : [KEY]";
            // 
            // SwipeRightMappingBtn
            // 
            this.SwipeRightMappingBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.SwipeRightMappingBtn.Location = new System.Drawing.Point(115, 21);
            this.SwipeRightMappingBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SwipeRightMappingBtn.Name = "SwipeRightMappingBtn";
            this.SwipeRightMappingBtn.Size = new System.Drawing.Size(82, 23);
            this.SwipeRightMappingBtn.TabIndex = 18;
            this.SwipeRightMappingBtn.Text = "Map to key";
            this.SwipeRightMappingBtn.UseVisualStyleBackColor = true;
            this.SwipeRightMappingBtn.Click += new System.EventHandler(this.SwipeRightMappingBtn_Click);
            // 
            // SwipeToRightImage
            // 
            this.SwipeToRightImage.AccessibleDescription = "Icon of a hand swiping to right";
            this.SwipeToRightImage.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.SwipeToRightImage.BackColor = System.Drawing.Color.Green;
            this.SwipeToRightImage.Location = new System.Drawing.Point(4, 4);
            this.SwipeToRightImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SwipeToRightImage.Name = "SwipeToRightImage";
            this.SwipeToRightImage.Size = new System.Drawing.Size(43, 41);
            this.SwipeToRightImage.TabIndex = 14;
            this.SwipeToRightImage.TabStop = false;
            // 
            // ScreenTapPanel
            // 
            this.ScreenTapPanel.Controls.Add(this.ScreenTapTxtBox);
            this.ScreenTapPanel.Controls.Add(this.ScreenTapMappingLabel);
            this.ScreenTapPanel.Controls.Add(this.ScreenTapMappingBtn);
            this.ScreenTapPanel.Controls.Add(this.ScreenTapImage);
            this.ScreenTapPanel.Location = new System.Drawing.Point(10, 45);
            this.ScreenTapPanel.Name = "ScreenTapPanel";
            this.ScreenTapPanel.Size = new System.Drawing.Size(248, 50);
            this.ScreenTapPanel.TabIndex = 21;
            // 
            // ScreenTapTxtBox
            // 
            this.ScreenTapTxtBox.Location = new System.Drawing.Point(56, 21);
            this.ScreenTapTxtBox.MaxLength = 2;
            this.ScreenTapTxtBox.Name = "ScreenTapTxtBox";
            this.ScreenTapTxtBox.Size = new System.Drawing.Size(42, 22);
            this.ScreenTapTxtBox.TabIndex = 22;
            this.ScreenTapTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ScreenTapTxtBox_KeyDown);
            // 
            // ScreenTapMappingLabel
            // 
            this.ScreenTapMappingLabel.AutoSize = true;
            this.ScreenTapMappingLabel.Location = new System.Drawing.Point(51, 3);
            this.ScreenTapMappingLabel.Name = "ScreenTapMappingLabel";
            this.ScreenTapMappingLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScreenTapMappingLabel.Size = new System.Drawing.Size(119, 16);
            this.ScreenTapMappingLabel.TabIndex = 17;
            this.ScreenTapMappingLabel.Text = "Screen Tap: [KEY]";
            // 
            // ScreenTapMappingBtn
            // 
            this.ScreenTapMappingBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ScreenTapMappingBtn.Location = new System.Drawing.Point(115, 21);
            this.ScreenTapMappingBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ScreenTapMappingBtn.Name = "ScreenTapMappingBtn";
            this.ScreenTapMappingBtn.Size = new System.Drawing.Size(82, 23);
            this.ScreenTapMappingBtn.TabIndex = 18;
            this.ScreenTapMappingBtn.Text = "Map to key";
            this.ScreenTapMappingBtn.UseVisualStyleBackColor = true;
            this.ScreenTapMappingBtn.Click += new System.EventHandler(this.ScreenTapMappingBtn_Click);
            // 
            // ScreenTapImage
            // 
            this.ScreenTapImage.AccessibleDescription = "Icon of a hand pointing";
            this.ScreenTapImage.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.ScreenTapImage.BackColor = System.Drawing.Color.Green;
            this.ScreenTapImage.Location = new System.Drawing.Point(3, 4);
            this.ScreenTapImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ScreenTapImage.Name = "ScreenTapImage";
            this.ScreenTapImage.Size = new System.Drawing.Size(43, 41);
            this.ScreenTapImage.TabIndex = 14;
            this.ScreenTapImage.TabStop = false;
            // 
            // KeyMappingPanel
            // 
            this.KeyMappingPanel.Controls.Add(this.ScreenTapPanel);
            this.KeyMappingPanel.Controls.Add(this.KeyMapping);
            this.KeyMappingPanel.Controls.Add(this.SwipeRightPanel);
            this.KeyMappingPanel.Controls.Add(this.SwipeLeftPanel);
            this.KeyMappingPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.KeyMappingPanel.Location = new System.Drawing.Point(279, 163);
            this.KeyMappingPanel.Name = "KeyMappingPanel";
            this.KeyMappingPanel.Size = new System.Drawing.Size(286, 287);
            this.KeyMappingPanel.TabIndex = 22;
            // 
            // GestureControlPanel
            // 
            this.GestureControlPanel.Controls.Add(this.startGestureControlButton);
            this.GestureControlPanel.Controls.Add(this.stopGestureControlButton);
            this.GestureControlPanel.Controls.Add(this.gestureControlLabel);
            this.GestureControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GestureControlPanel.Location = new System.Drawing.Point(0, 163);
            this.GestureControlPanel.Name = "GestureControlPanel";
            this.GestureControlPanel.Size = new System.Drawing.Size(279, 292);
            this.GestureControlPanel.TabIndex = 23;
            // 
            // ControllerScreenReaderStatePanel
            // 
            this.ControllerScreenReaderStatePanel.Controls.Add(this.groupBox1);
            this.ControllerScreenReaderStatePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControllerScreenReaderStatePanel.Location = new System.Drawing.Point(0, 0);
            this.ControllerScreenReaderStatePanel.Name = "ControllerScreenReaderStatePanel";
            this.ControllerScreenReaderStatePanel.Size = new System.Drawing.Size(565, 163);
            this.ControllerScreenReaderStatePanel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LeapMotionStateLabel);
            this.groupBox1.Controls.Add(this.RefreshListBtn);
            this.groupBox1.Controls.Add(this.ScreenReaderComboBox);
            this.groupBox1.Controls.Add(this.selectedScreenReader);
            this.groupBox1.Location = new System.Drawing.Point(50, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 109);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "State";
            // 
            // RefreshListBtn
            // 
            this.RefreshListBtn.Location = new System.Drawing.Point(9, 76);
            this.RefreshListBtn.Name = "RefreshListBtn";
            this.RefreshListBtn.Size = new System.Drawing.Size(67, 23);
            this.RefreshListBtn.TabIndex = 4;
            this.RefreshListBtn.Text = "Refresh";
            this.RefreshListBtn.UseVisualStyleBackColor = true;
            this.RefreshListBtn.Click += new System.EventHandler(this.RefreshListBtn_Click);
            // 
            // LauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.GestureControlPanel);
            this.Controls.Add(this.KeyMappingPanel);
            this.Controls.Add(this.ControllerScreenReaderStatePanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LauncherForm";
            this.Text = "Screen Reader Gesture Controller";
            ((System.ComponentModel.ISupportInitialize)(this.SwipeToLeftImage)).EndInit();
            this.SwipeLeftPanel.ResumeLayout(false);
            this.SwipeLeftPanel.PerformLayout();
            this.SwipeRightPanel.ResumeLayout(false);
            this.SwipeRightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SwipeToRightImage)).EndInit();
            this.ScreenTapPanel.ResumeLayout(false);
            this.ScreenTapPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenTapImage)).EndInit();
            this.KeyMappingPanel.ResumeLayout(false);
            this.KeyMappingPanel.PerformLayout();
            this.GestureControlPanel.ResumeLayout(false);
            this.GestureControlPanel.PerformLayout();
            this.ControllerScreenReaderStatePanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button startGestureControlButton;
        private System.Windows.Forms.Button stopGestureControlButton;
        private System.Windows.Forms.Label gestureControlLabel;
        private System.Windows.Forms.Label KeyMapping;
        private System.Windows.Forms.Label selectedScreenReader;
        private System.Windows.Forms.ComboBox ScreenReaderComboBox;
        private System.Windows.Forms.Label LeapMotionStateLabel;
        private System.Windows.Forms.PictureBox SwipeToLeftImage;
        private System.Windows.Forms.Button SwipeLeftMappingBtn;
        private System.Windows.Forms.Label SwipeLeftMappingLabel;
        private System.Windows.Forms.Panel SwipeLeftPanel;
        private System.Windows.Forms.Panel SwipeRightPanel;
        private System.Windows.Forms.Label SwipeRightMappingLabel;
        private System.Windows.Forms.Button SwipeRightMappingBtn;
        private System.Windows.Forms.PictureBox SwipeToRightImage;
        private System.Windows.Forms.Panel ScreenTapPanel;
        private System.Windows.Forms.Label ScreenTapMappingLabel;
        private System.Windows.Forms.Button ScreenTapMappingBtn;
        private System.Windows.Forms.PictureBox ScreenTapImage;
        private System.Windows.Forms.Panel KeyMappingPanel;
        private System.Windows.Forms.Panel GestureControlPanel;
        private System.Windows.Forms.Panel ControllerScreenReaderStatePanel;
        private System.Windows.Forms.Button RefreshListBtn;
        private System.Windows.Forms.TextBox ScreenTapTxtBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SwipeLeftTxtBox;
        private System.Windows.Forms.TextBox SwipeRightTxtBox;
    }
}



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
            this.SwipeRightPanel = new System.Windows.Forms.Panel();
            this.SwipeRightMappingLabel = new System.Windows.Forms.Label();
            this.SwipeRightMappingBtn = new System.Windows.Forms.Button();
            this.SwipeToRightImage = new System.Windows.Forms.PictureBox();
            this.ScreenTapPanel = new System.Windows.Forms.Panel();
            this.ScreenTapMappingLabel = new System.Windows.Forms.Label();
            this.ScreenTapMappingBtn = new System.Windows.Forms.Button();
            this.ScreenTapImage = new System.Windows.Forms.PictureBox();
            this.KeyMappingPanel = new System.Windows.Forms.Panel();
            this.GestureControlPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SelectedScreenReaderPanel = new System.Windows.Forms.Panel();
            this.RefreshListBtn = new System.Windows.Forms.Button();
            this.ScreenTapTxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SwipeToLeftImage)).BeginInit();
            this.SwipeLeftPanel.SuspendLayout();
            this.SwipeRightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SwipeToRightImage)).BeginInit();
            this.ScreenTapPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenTapImage)).BeginInit();
            this.KeyMappingPanel.SuspendLayout();
            this.GestureControlPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SelectedScreenReaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // startGestureControlButton
            // 
            this.startGestureControlButton.Location = new System.Drawing.Point(20, 33);
            this.startGestureControlButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startGestureControlButton.Name = "startGestureControlButton";
            this.startGestureControlButton.Size = new System.Drawing.Size(167, 23);
            this.startGestureControlButton.TabIndex = 0;
            this.startGestureControlButton.Text = "Start";
            this.startGestureControlButton.UseVisualStyleBackColor = true;
            this.startGestureControlButton.Click += new System.EventHandler(this.StartGestureControlButton_Click);
            // 
            // stopGestureControlButton
            // 
            this.stopGestureControlButton.Enabled = false;
            this.stopGestureControlButton.Location = new System.Drawing.Point(20, 60);
            this.stopGestureControlButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stopGestureControlButton.Name = "stopGestureControlButton";
            this.stopGestureControlButton.Size = new System.Drawing.Size(167, 23);
            this.stopGestureControlButton.TabIndex = 1;
            this.stopGestureControlButton.Text = "Stop";
            this.stopGestureControlButton.UseVisualStyleBackColor = true;
            this.stopGestureControlButton.Click += new System.EventHandler(this.StopGestureControlButton_Click);
            // 
            // gestureControlLabel
            // 
            this.gestureControlLabel.AutoSize = true;
            this.gestureControlLabel.Location = new System.Drawing.Point(20, 11);
            this.gestureControlLabel.Name = "gestureControlLabel";
            this.gestureControlLabel.Size = new System.Drawing.Size(100, 16);
            this.gestureControlLabel.TabIndex = 4;
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
            this.selectedScreenReader.Location = new System.Drawing.Point(20, 13);
            this.selectedScreenReader.Name = "selectedScreenReader";
            this.selectedScreenReader.Size = new System.Drawing.Size(157, 16);
            this.selectedScreenReader.TabIndex = 9;
            this.selectedScreenReader.Text = "Selected Screen Reader";
            // 
            // ScreenReaderComboBox
            // 
            this.ScreenReaderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScreenReaderComboBox.FormattingEnabled = true;
            this.ScreenReaderComboBox.Location = new System.Drawing.Point(20, 40);
            this.ScreenReaderComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ScreenReaderComboBox.Name = "ScreenReaderComboBox";
            this.ScreenReaderComboBox.Size = new System.Drawing.Size(167, 24);
            this.ScreenReaderComboBox.TabIndex = 11;
            this.ScreenReaderComboBox.SelectedIndexChanged += new System.EventHandler(this.ScreenReaderComboBox_SelectedIndexChanged);
            // 
            // LeapMotionStateLabel
            // 
            this.LeapMotionStateLabel.AutoSize = true;
            this.LeapMotionStateLabel.Location = new System.Drawing.Point(20, 19);
            this.LeapMotionStateLabel.Name = "LeapMotionStateLabel";
            this.LeapMotionStateLabel.Size = new System.Drawing.Size(122, 16);
            this.LeapMotionStateLabel.TabIndex = 12;
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
            this.SwipeLeftMappingBtn.Location = new System.Drawing.Point(56, 22);
            this.SwipeLeftMappingBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SwipeLeftMappingBtn.Name = "SwipeLeftMappingBtn";
            this.SwipeLeftMappingBtn.Size = new System.Drawing.Size(171, 23);
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
            this.SwipeLeftPanel.Controls.Add(this.SwipeLeftMappingLabel);
            this.SwipeLeftPanel.Controls.Add(this.SwipeLeftMappingBtn);
            this.SwipeLeftPanel.Controls.Add(this.SwipeToLeftImage);
            this.SwipeLeftPanel.Location = new System.Drawing.Point(10, 180);
            this.SwipeLeftPanel.Name = "SwipeLeftPanel";
            this.SwipeLeftPanel.Size = new System.Drawing.Size(248, 54);
            this.SwipeLeftPanel.TabIndex = 19;
            // 
            // SwipeRightPanel
            // 
            this.SwipeRightPanel.Controls.Add(this.SwipeRightMappingLabel);
            this.SwipeRightPanel.Controls.Add(this.SwipeRightMappingBtn);
            this.SwipeRightPanel.Controls.Add(this.SwipeToRightImage);
            this.SwipeRightPanel.Location = new System.Drawing.Point(10, 111);
            this.SwipeRightPanel.Name = "SwipeRightPanel";
            this.SwipeRightPanel.Size = new System.Drawing.Size(248, 51);
            this.SwipeRightPanel.TabIndex = 20;
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
            this.SwipeRightMappingBtn.Location = new System.Drawing.Point(56, 22);
            this.SwipeRightMappingBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SwipeRightMappingBtn.Name = "SwipeRightMappingBtn";
            this.SwipeRightMappingBtn.Size = new System.Drawing.Size(171, 23);
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
            // ScreenTapMappingLabel
            // 
            this.ScreenTapMappingLabel.AutoSize = true;
            this.ScreenTapMappingLabel.Location = new System.Drawing.Point(51, 3);
            this.ScreenTapMappingLabel.Name = "ScreenTapMappingLabel";
            this.ScreenTapMappingLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScreenTapMappingLabel.Size = new System.Drawing.Size(122, 16);
            this.ScreenTapMappingLabel.TabIndex = 17;
            this.ScreenTapMappingLabel.Text = "Screen Tap:  [KEY]";
            // 
            // ScreenTapMappingBtn
            // 
            this.ScreenTapMappingBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ScreenTapMappingBtn.Location = new System.Drawing.Point(55, 22);
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
            this.KeyMappingPanel.Location = new System.Drawing.Point(279, 58);
            this.KeyMappingPanel.Name = "KeyMappingPanel";
            this.KeyMappingPanel.Size = new System.Drawing.Size(286, 392);
            this.KeyMappingPanel.TabIndex = 22;
            // 
            // GestureControlPanel
            // 
            this.GestureControlPanel.Controls.Add(this.startGestureControlButton);
            this.GestureControlPanel.Controls.Add(this.stopGestureControlButton);
            this.GestureControlPanel.Controls.Add(this.gestureControlLabel);
            this.GestureControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GestureControlPanel.Location = new System.Drawing.Point(0, 148);
            this.GestureControlPanel.Name = "GestureControlPanel";
            this.GestureControlPanel.Size = new System.Drawing.Size(279, 292);
            this.GestureControlPanel.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LeapMotionStateLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 58);
            this.panel1.TabIndex = 24;
            // 
            // SelectedScreenReaderPanel
            // 
            this.SelectedScreenReaderPanel.Controls.Add(this.RefreshListBtn);
            this.SelectedScreenReaderPanel.Controls.Add(this.selectedScreenReader);
            this.SelectedScreenReaderPanel.Controls.Add(this.ScreenReaderComboBox);
            this.SelectedScreenReaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SelectedScreenReaderPanel.Location = new System.Drawing.Point(0, 58);
            this.SelectedScreenReaderPanel.Name = "SelectedScreenReaderPanel";
            this.SelectedScreenReaderPanel.Size = new System.Drawing.Size(279, 90);
            this.SelectedScreenReaderPanel.TabIndex = 25;
            // 
            // RefreshListBtn
            // 
            this.RefreshListBtn.Location = new System.Drawing.Point(194, 40);
            this.RefreshListBtn.Name = "RefreshListBtn";
            this.RefreshListBtn.Size = new System.Drawing.Size(67, 23);
            this.RefreshListBtn.TabIndex = 12;
            this.RefreshListBtn.Text = "Refresh";
            this.RefreshListBtn.UseVisualStyleBackColor = true;
            this.RefreshListBtn.Click += new System.EventHandler(this.RefreshListBtn_Click);
            // 
            // ScreenTapTxtBox
            // 
            this.ScreenTapTxtBox.Location = new System.Drawing.Point(143, 22);
            this.ScreenTapTxtBox.Name = "ScreenTapTxtBox";
            this.ScreenTapTxtBox.Size = new System.Drawing.Size(100, 22);
            this.ScreenTapTxtBox.TabIndex = 22;
            // 
            // LauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.GestureControlPanel);
            this.Controls.Add(this.SelectedScreenReaderPanel);
            this.Controls.Add(this.KeyMappingPanel);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SelectedScreenReaderPanel.ResumeLayout(false);
            this.SelectedScreenReaderPanel.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SelectedScreenReaderPanel;
        private System.Windows.Forms.Button RefreshListBtn;
        private System.Windows.Forms.TextBox ScreenTapTxtBox;
    }
}


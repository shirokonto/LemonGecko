
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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.startGestureControlButton = new System.Windows.Forms.Button();
            this.stopGestureControlButton = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.gestureControlLabel = new System.Windows.Forms.Label();
            this.keyMapping = new System.Windows.Forms.Label();
            this.ScreenTapImage = new System.Windows.Forms.PictureBox();
            this.ScreenTapMappingLabel = new System.Windows.Forms.Label();
            this.changeScreenTapMappingBtn = new System.Windows.Forms.Button();
            this.selectedScreenReader = new System.Windows.Forms.Label();
            this.ScreenReaderComboBox = new System.Windows.Forms.ComboBox();
            this.LeapMotionStateLabel = new System.Windows.Forms.Label();
            this.SwipeToRightImage = new System.Windows.Forms.PictureBox();
            this.SwipeToLeftImage = new System.Windows.Forms.PictureBox();
            this.changeSwipeRightMappingBtn = new System.Windows.Forms.Button();
            this.SwipeRightMappingLabel = new System.Windows.Forms.Label();
            this.changeSwipeLeftMappingBtn = new System.Windows.Forms.Button();
            this.SwipeLeftMappingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenTapImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwipeToRightImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwipeToLeftImage)).BeginInit();
            this.SuspendLayout();
            // 
            // startGestureControlButton
            // 
            this.startGestureControlButton.Location = new System.Drawing.Point(31, 250);
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
            this.stopGestureControlButton.Location = new System.Drawing.Point(31, 291);
            this.stopGestureControlButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stopGestureControlButton.Name = "stopGestureControlButton";
            this.stopGestureControlButton.Size = new System.Drawing.Size(167, 23);
            this.stopGestureControlButton.TabIndex = 1;
            this.stopGestureControlButton.Text = "Stop";
            this.stopGestureControlButton.UseVisualStyleBackColor = true;
            this.stopGestureControlButton.Click += new System.EventHandler(this.StopGestureControlButton_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // gestureControlLabel
            // 
            this.gestureControlLabel.AutoSize = true;
            this.gestureControlLabel.Location = new System.Drawing.Point(31, 220);
            this.gestureControlLabel.Name = "gestureControlLabel";
            this.gestureControlLabel.Size = new System.Drawing.Size(100, 16);
            this.gestureControlLabel.TabIndex = 4;
            this.gestureControlLabel.Text = "Gesture Control";
            // 
            // keyMapping
            // 
            this.keyMapping.AutoSize = true;
            this.keyMapping.Location = new System.Drawing.Point(263, 44);
            this.keyMapping.Name = "keyMapping";
            this.keyMapping.Size = new System.Drawing.Size(83, 20);
            this.keyMapping.TabIndex = 5;
            this.keyMapping.Text = "Key Mapping";
            this.keyMapping.UseCompatibleTextRendering = true;
            // 
            // ScreenTapImage
            // 
            this.ScreenTapImage.AccessibleDescription = "Icon of a hand pointing";
            this.ScreenTapImage.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.ScreenTapImage.Location = new System.Drawing.Point(263, 76);
            this.ScreenTapImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ScreenTapImage.Name = "ScreenTapImage";
            this.ScreenTapImage.Size = new System.Drawing.Size(43, 41);
            this.ScreenTapImage.TabIndex = 6;
            this.ScreenTapImage.TabStop = false;
            // 
            // ScreenTapMappingLabel
            // 
            this.ScreenTapMappingLabel.AutoSize = true;
            this.ScreenTapMappingLabel.Location = new System.Drawing.Point(311, 79);
            this.ScreenTapMappingLabel.Name = "ScreenTapMappingLabel";
            this.ScreenTapMappingLabel.Size = new System.Drawing.Size(190, 16);
            this.ScreenTapMappingLabel.TabIndex = 7;
            this.ScreenTapMappingLabel.Text = "Screen Tap Mapped To [KEY]";
            // 
            // changeScreenTapMappingBtn
            // 
            this.changeScreenTapMappingBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.changeScreenTapMappingBtn.Location = new System.Drawing.Point(315, 98);
            this.changeScreenTapMappingBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeScreenTapMappingBtn.Name = "changeScreenTapMappingBtn";
            this.changeScreenTapMappingBtn.Size = new System.Drawing.Size(171, 23);
            this.changeScreenTapMappingBtn.TabIndex = 8;
            this.changeScreenTapMappingBtn.Text = "Map to different key";
            this.changeScreenTapMappingBtn.UseVisualStyleBackColor = true;
            // 
            // selectedScreenReader
            // 
            this.selectedScreenReader.AutoSize = true;
            this.selectedScreenReader.Location = new System.Drawing.Point(31, 123);
            this.selectedScreenReader.Name = "selectedScreenReader";
            this.selectedScreenReader.Size = new System.Drawing.Size(157, 16);
            this.selectedScreenReader.TabIndex = 9;
            this.selectedScreenReader.Text = "Selected Screen Reader";
            // 
            // ScreenReaderComboBox
            // 
            this.ScreenReaderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScreenReaderComboBox.FormattingEnabled = true;
            this.ScreenReaderComboBox.Location = new System.Drawing.Point(31, 150);
            this.ScreenReaderComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ScreenReaderComboBox.Name = "ScreenReaderComboBox";
            this.ScreenReaderComboBox.Size = new System.Drawing.Size(167, 24);
            this.ScreenReaderComboBox.TabIndex = 11;
            this.ScreenReaderComboBox.SelectedIndexChanged += new System.EventHandler(this.ScreenReaderComboBox_SelectedIndexChanged);
            // 
            // LeapMotionStateLabel
            // 
            this.LeapMotionStateLabel.AutoSize = true;
            this.LeapMotionStateLabel.Location = new System.Drawing.Point(31, 44);
            this.LeapMotionStateLabel.Name = "LeapMotionStateLabel";
            this.LeapMotionStateLabel.Size = new System.Drawing.Size(150, 16);
            this.LeapMotionStateLabel.TabIndex = 12;
            this.LeapMotionStateLabel.Text = "Leap Motion Connected";
            // 
            // SwipeToRightImage
            // 
            this.SwipeToRightImage.AccessibleDescription = "Icon of a hand swiping to right";
            this.SwipeToRightImage.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.SwipeToRightImage.Location = new System.Drawing.Point(263, 133);
            this.SwipeToRightImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SwipeToRightImage.Name = "SwipeToRightImage";
            this.SwipeToRightImage.Size = new System.Drawing.Size(43, 41);
            this.SwipeToRightImage.TabIndex = 13;
            this.SwipeToRightImage.TabStop = false;
            // 
            // SwipeToLeftImage
            // 
            this.SwipeToLeftImage.AccessibleDescription = "Icon of a hand swiping to left";
            this.SwipeToLeftImage.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.SwipeToLeftImage.Location = new System.Drawing.Point(263, 195);
            this.SwipeToLeftImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SwipeToLeftImage.Name = "SwipeToLeftImage";
            this.SwipeToLeftImage.Size = new System.Drawing.Size(43, 41);
            this.SwipeToLeftImage.TabIndex = 14;
            this.SwipeToLeftImage.TabStop = false;
            // 
            // changeSwipeRightMappingBtn
            // 
            this.changeSwipeRightMappingBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.changeSwipeRightMappingBtn.Location = new System.Drawing.Point(315, 151);
            this.changeSwipeRightMappingBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeSwipeRightMappingBtn.Name = "changeSwipeRightMappingBtn";
            this.changeSwipeRightMappingBtn.Size = new System.Drawing.Size(171, 23);
            this.changeSwipeRightMappingBtn.TabIndex = 16;
            this.changeSwipeRightMappingBtn.Text = "Map to different key";
            this.changeSwipeRightMappingBtn.UseVisualStyleBackColor = true;
            // 
            // SwipeRightMappingLabel
            // 
            this.SwipeRightMappingLabel.AutoSize = true;
            this.SwipeRightMappingLabel.Location = new System.Drawing.Point(311, 132);
            this.SwipeRightMappingLabel.Name = "SwipeRightMappingLabel";
            this.SwipeRightMappingLabel.Size = new System.Drawing.Size(190, 16);
            this.SwipeRightMappingLabel.TabIndex = 15;
            this.SwipeRightMappingLabel.Text = "Swipe Right Mapped To [KEY]";
            // 
            // changeSwipeLeftMappingBtn
            // 
            this.changeSwipeLeftMappingBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.changeSwipeLeftMappingBtn.Location = new System.Drawing.Point(315, 213);
            this.changeSwipeLeftMappingBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeSwipeLeftMappingBtn.Name = "changeSwipeLeftMappingBtn";
            this.changeSwipeLeftMappingBtn.Size = new System.Drawing.Size(171, 23);
            this.changeSwipeLeftMappingBtn.TabIndex = 18;
            this.changeSwipeLeftMappingBtn.Text = "Map to different key";
            this.changeSwipeLeftMappingBtn.UseVisualStyleBackColor = true;
            // 
            // SwipeLeftMappingLabel
            // 
            this.SwipeLeftMappingLabel.AutoSize = true;
            this.SwipeLeftMappingLabel.Location = new System.Drawing.Point(311, 194);
            this.SwipeLeftMappingLabel.Name = "SwipeLeftMappingLabel";
            this.SwipeLeftMappingLabel.Size = new System.Drawing.Size(180, 16);
            this.SwipeLeftMappingLabel.TabIndex = 17;
            this.SwipeLeftMappingLabel.Text = "Swipe Left Mapped To [KEY]";
            // 
            // LauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 450);
            this.Controls.Add(this.changeSwipeLeftMappingBtn);
            this.Controls.Add(this.SwipeLeftMappingLabel);
            this.Controls.Add(this.changeSwipeRightMappingBtn);
            this.Controls.Add(this.SwipeRightMappingLabel);
            this.Controls.Add(this.SwipeToLeftImage);
            this.Controls.Add(this.SwipeToRightImage);
            this.Controls.Add(this.LeapMotionStateLabel);
            this.Controls.Add(this.ScreenReaderComboBox);
            this.Controls.Add(this.selectedScreenReader);
            this.Controls.Add(this.changeScreenTapMappingBtn);
            this.Controls.Add(this.ScreenTapMappingLabel);
            this.Controls.Add(this.ScreenTapImage);
            this.Controls.Add(this.keyMapping);
            this.Controls.Add(this.gestureControlLabel);
            this.Controls.Add(this.stopGestureControlButton);
            this.Controls.Add(this.startGestureControlButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LauncherForm";
            this.Text = "Screen Reader Gesture Controller";
            ((System.ComponentModel.ISupportInitialize)(this.ScreenTapImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwipeToRightImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwipeToLeftImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Button startGestureControlButton;
        private System.Windows.Forms.Button stopGestureControlButton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label gestureControlLabel;
        private System.Windows.Forms.Label keyMapping;
        private System.Windows.Forms.PictureBox ScreenTapImage;
        private System.Windows.Forms.Label ScreenTapMappingLabel;
        private System.Windows.Forms.Button changeScreenTapMappingBtn;
        private System.Windows.Forms.Label selectedScreenReader;
        private System.Windows.Forms.ComboBox ScreenReaderComboBox;
        private System.Windows.Forms.Label LeapMotionStateLabel;
        private System.Windows.Forms.PictureBox SwipeToRightImage;
        private System.Windows.Forms.PictureBox SwipeToLeftImage;
        private System.Windows.Forms.Button changeSwipeRightMappingBtn;
        private System.Windows.Forms.Label SwipeRightMappingLabel;
        private System.Windows.Forms.Button changeSwipeLeftMappingBtn;
        private System.Windows.Forms.Label SwipeLeftMappingLabel;
    }
}


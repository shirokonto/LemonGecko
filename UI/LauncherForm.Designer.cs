
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
            this.selectedScreenReader = new System.Windows.Forms.Label();
            this.ScreenReaderComboBox = new System.Windows.Forms.ComboBox();
            this.SwipeLeftMappingBtn = new System.Windows.Forms.Button();
            this.SwipeLeftMappingLabel = new System.Windows.Forms.Label();
            this.SwipeLeftTxtBox = new System.Windows.Forms.TextBox();
            this.SwipeRightMappingLabel = new System.Windows.Forms.Label();
            this.SwipeRightMappingBtn = new System.Windows.Forms.Button();
            this.ScreenTapMappingLabel = new System.Windows.Forms.Label();
            this.ScreenTapMappingBtn = new System.Windows.Forms.Button();
            this.KeyMappingPanel = new System.Windows.Forms.Panel();
            this.KeyMappingGroupBox = new System.Windows.Forms.GroupBox();
            this.SwipeRightTxtBox = new System.Windows.Forms.TextBox();
            this.ScreenTapTxtBox = new System.Windows.Forms.TextBox();
            this.GestureControlPanel = new System.Windows.Forms.Panel();
            this.ControllerScreenReaderStatePanel = new System.Windows.Forms.Panel();
            this.DeviceStatus = new System.Windows.Forms.GroupBox();
            this.LeapMotionStateTxt = new System.Windows.Forms.TextBox();
            this.LeapMotionStateLabel = new System.Windows.Forms.Label();
            this.RefreshListBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyMappingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenNewLauncherBtn = new System.Windows.Forms.Button();
            this.KeyMappingPanel.SuspendLayout();
            this.KeyMappingGroupBox.SuspendLayout();
            this.GestureControlPanel.SuspendLayout();
            this.ControllerScreenReaderStatePanel.SuspendLayout();
            this.DeviceStatus.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            // selectedScreenReader
            // 
            this.selectedScreenReader.AutoSize = true;
            this.selectedScreenReader.Location = new System.Drawing.Point(6, 54);
            this.selectedScreenReader.Name = "selectedScreenReader";
            this.selectedScreenReader.Size = new System.Drawing.Size(160, 16);
            this.selectedScreenReader.TabIndex = 4;
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
            this.ScreenReaderComboBox.TabIndex = 5;
            this.ScreenReaderComboBox.SelectedIndexChanged += new System.EventHandler(this.ScreenReaderComboBox_SelectedIndexChanged);
            // 
            // SwipeLeftMappingBtn
            // 
            this.SwipeLeftMappingBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.SwipeLeftMappingBtn.Location = new System.Drawing.Point(124, 73);
            this.SwipeLeftMappingBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SwipeLeftMappingBtn.Name = "SwipeLeftMappingBtn";
            this.SwipeLeftMappingBtn.Size = new System.Drawing.Size(82, 23);
            this.SwipeLeftMappingBtn.TabIndex = 7;
            this.SwipeLeftMappingBtn.Text = "Map to key";
            this.SwipeLeftMappingBtn.UseVisualStyleBackColor = true;
            this.SwipeLeftMappingBtn.Visible = false;
            this.SwipeLeftMappingBtn.Click += new System.EventHandler(this.SwipeLeftMappingBtn_Click);
            // 
            // SwipeLeftMappingLabel
            // 
            this.SwipeLeftMappingLabel.AutoSize = true;
            this.SwipeLeftMappingLabel.Location = new System.Drawing.Point(6, 67);
            this.SwipeLeftMappingLabel.Name = "SwipeLeftMappingLabel";
            this.SwipeLeftMappingLabel.Size = new System.Drawing.Size(112, 16);
            this.SwipeLeftMappingLabel.TabIndex = 17;
            this.SwipeLeftMappingLabel.Text = "Swipe Left : [KEY]";
            // 
            // SwipeLeftTxtBox
            // 
            this.SwipeLeftTxtBox.Location = new System.Drawing.Point(18, 190);
            this.SwipeLeftTxtBox.MaxLength = 2;
            this.SwipeLeftTxtBox.Name = "SwipeLeftTxtBox";
            this.SwipeLeftTxtBox.Size = new System.Drawing.Size(42, 22);
            this.SwipeLeftTxtBox.TabIndex = 24;
            this.SwipeLeftTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SwipeLeftTxtBox_KeyDown);
            // 
            // SwipeRightMappingLabel
            // 
            this.SwipeRightMappingLabel.AutoSize = true;
            this.SwipeRightMappingLabel.Location = new System.Drawing.Point(6, 46);
            this.SwipeRightMappingLabel.Name = "SwipeRightMappingLabel";
            this.SwipeRightMappingLabel.Size = new System.Drawing.Size(122, 16);
            this.SwipeRightMappingLabel.TabIndex = 17;
            this.SwipeRightMappingLabel.Text = "Swipe Right : [KEY]";
            // 
            // SwipeRightMappingBtn
            // 
            this.SwipeRightMappingBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.SwipeRightMappingBtn.Location = new System.Drawing.Point(131, 46);
            this.SwipeRightMappingBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SwipeRightMappingBtn.Name = "SwipeRightMappingBtn";
            this.SwipeRightMappingBtn.Size = new System.Drawing.Size(82, 23);
            this.SwipeRightMappingBtn.TabIndex = 18;
            this.SwipeRightMappingBtn.Text = "Map to key";
            this.SwipeRightMappingBtn.UseVisualStyleBackColor = true;
            this.SwipeRightMappingBtn.Click += new System.EventHandler(this.SwipeRightMappingBtn_Click);
            // 
            // ScreenTapMappingLabel
            // 
            this.ScreenTapMappingLabel.AutoSize = true;
            this.ScreenTapMappingLabel.Location = new System.Drawing.Point(6, 25);
            this.ScreenTapMappingLabel.Name = "ScreenTapMappingLabel";
            this.ScreenTapMappingLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScreenTapMappingLabel.Size = new System.Drawing.Size(119, 16);
            this.ScreenTapMappingLabel.TabIndex = 17;
            this.ScreenTapMappingLabel.Text = "Screen Tap: [KEY]";
            // 
            // ScreenTapMappingBtn
            // 
            this.ScreenTapMappingBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ScreenTapMappingBtn.Location = new System.Drawing.Point(131, 21);
            this.ScreenTapMappingBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ScreenTapMappingBtn.Name = "ScreenTapMappingBtn";
            this.ScreenTapMappingBtn.Size = new System.Drawing.Size(82, 23);
            this.ScreenTapMappingBtn.TabIndex = 18;
            this.ScreenTapMappingBtn.Text = "Map to key";
            this.ScreenTapMappingBtn.UseVisualStyleBackColor = true;
            this.ScreenTapMappingBtn.Click += new System.EventHandler(this.ScreenTapMappingBtn_Click);
            // 
            // KeyMappingPanel
            // 
            this.KeyMappingPanel.Controls.Add(this.KeyMappingGroupBox);
            this.KeyMappingPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.KeyMappingPanel.Location = new System.Drawing.Point(279, 163);
            this.KeyMappingPanel.Name = "KeyMappingPanel";
            this.KeyMappingPanel.Size = new System.Drawing.Size(286, 287);
            this.KeyMappingPanel.TabIndex = 22;
            // 
            // KeyMappingGroupBox
            // 
            this.KeyMappingGroupBox.Controls.Add(this.SwipeLeftTxtBox);
            this.KeyMappingGroupBox.Controls.Add(this.SwipeRightTxtBox);
            this.KeyMappingGroupBox.Controls.Add(this.ScreenTapTxtBox);
            this.KeyMappingGroupBox.Controls.Add(this.ScreenTapMappingLabel);
            this.KeyMappingGroupBox.Controls.Add(this.SwipeLeftMappingBtn);
            this.KeyMappingGroupBox.Controls.Add(this.SwipeRightMappingBtn);
            this.KeyMappingGroupBox.Controls.Add(this.ScreenTapMappingBtn);
            this.KeyMappingGroupBox.Controls.Add(this.SwipeLeftMappingLabel);
            this.KeyMappingGroupBox.Controls.Add(this.SwipeRightMappingLabel);
            this.KeyMappingGroupBox.Location = new System.Drawing.Point(17, 16);
            this.KeyMappingGroupBox.Name = "KeyMappingGroupBox";
            this.KeyMappingGroupBox.Size = new System.Drawing.Size(257, 248);
            this.KeyMappingGroupBox.TabIndex = 25;
            this.KeyMappingGroupBox.TabStop = false;
            this.KeyMappingGroupBox.Text = "Key Mapping";
            // 
            // SwipeRightTxtBox
            // 
            this.SwipeRightTxtBox.Location = new System.Drawing.Point(18, 162);
            this.SwipeRightTxtBox.MaxLength = 2;
            this.SwipeRightTxtBox.Name = "SwipeRightTxtBox";
            this.SwipeRightTxtBox.Size = new System.Drawing.Size(42, 22);
            this.SwipeRightTxtBox.TabIndex = 23;
            this.SwipeRightTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SwipeRightTxtBox_KeyDown);
            // 
            // ScreenTapTxtBox
            // 
            this.ScreenTapTxtBox.Location = new System.Drawing.Point(18, 134);
            this.ScreenTapTxtBox.MaxLength = 2;
            this.ScreenTapTxtBox.Name = "ScreenTapTxtBox";
            this.ScreenTapTxtBox.Size = new System.Drawing.Size(42, 22);
            this.ScreenTapTxtBox.TabIndex = 22;
            this.ScreenTapTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ScreenTapTxtBox_KeyDown);
            // 
            // GestureControlPanel
            // 
            this.GestureControlPanel.Controls.Add(this.OpenNewLauncherBtn);
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
            this.ControllerScreenReaderStatePanel.Controls.Add(this.DeviceStatus);
            this.ControllerScreenReaderStatePanel.Controls.Add(this.menuStrip1);
            this.ControllerScreenReaderStatePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControllerScreenReaderStatePanel.Location = new System.Drawing.Point(0, 0);
            this.ControllerScreenReaderStatePanel.Name = "ControllerScreenReaderStatePanel";
            this.ControllerScreenReaderStatePanel.Size = new System.Drawing.Size(565, 163);
            this.ControllerScreenReaderStatePanel.TabIndex = 28;
            // 
            // DeviceStatus
            // 
            this.DeviceStatus.Controls.Add(this.LeapMotionStateTxt);
            this.DeviceStatus.Controls.Add(this.LeapMotionStateLabel);
            this.DeviceStatus.Controls.Add(this.RefreshListBtn);
            this.DeviceStatus.Controls.Add(this.ScreenReaderComboBox);
            this.DeviceStatus.Controls.Add(this.selectedScreenReader);
            this.DeviceStatus.Location = new System.Drawing.Point(50, 36);
            this.DeviceStatus.Name = "DeviceStatus";
            this.DeviceStatus.Size = new System.Drawing.Size(413, 109);
            this.DeviceStatus.TabIndex = 5;
            this.DeviceStatus.TabStop = false;
            this.DeviceStatus.Text = "State";
            // 
            // LeapMotionStateTxt
            // 
            this.LeapMotionStateTxt.Location = new System.Drawing.Point(155, 28);
            this.LeapMotionStateTxt.Name = "LeapMotionStateTxt";
            this.LeapMotionStateTxt.ReadOnly = true;
            this.LeapMotionStateTxt.Size = new System.Drawing.Size(100, 22);
            this.LeapMotionStateTxt.TabIndex = 3;
            // 
            // LeapMotionStateLabel
            // 
            this.LeapMotionStateLabel.AutoSize = true;
            this.LeapMotionStateLabel.Location = new System.Drawing.Point(6, 28);
            this.LeapMotionStateLabel.Name = "LeapMotionStateLabel";
            this.LeapMotionStateLabel.Size = new System.Drawing.Size(142, 16);
            this.LeapMotionStateLabel.TabIndex = 2;
            this.LeapMotionStateLabel.Text = "Leap Motion Controller";
            // 
            // RefreshListBtn
            // 
            this.RefreshListBtn.Location = new System.Drawing.Point(9, 76);
            this.RefreshListBtn.Name = "RefreshListBtn";
            this.RefreshListBtn.Size = new System.Drawing.Size(67, 23);
            this.RefreshListBtn.TabIndex = 6;
            this.RefreshListBtn.Text = "Refresh";
            this.RefreshListBtn.UseVisualStyleBackColor = true;
            this.RefreshListBtn.Click += new System.EventHandler(this.RefreshListBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(565, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keyMappingToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // keyMappingToolStripMenuItem
            // 
            this.keyMappingToolStripMenuItem.Name = "keyMappingToolStripMenuItem";
            this.keyMappingToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.keyMappingToolStripMenuItem.Text = "Key Mapping";
            // 
            // OpenNewLauncherBtn
            // 
            this.OpenNewLauncherBtn.Location = new System.Drawing.Point(38, 150);
            this.OpenNewLauncherBtn.Name = "OpenNewLauncherBtn";
            this.OpenNewLauncherBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenNewLauncherBtn.TabIndex = 25;
            this.OpenNewLauncherBtn.Text = "Open new Launcher";
            this.OpenNewLauncherBtn.UseVisualStyleBackColor = true;
            this.OpenNewLauncherBtn.Click += new System.EventHandler(this.OpenNewLauncherBtn_Click);
            // 
            // LauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.GestureControlPanel);
            this.Controls.Add(this.KeyMappingPanel);
            this.Controls.Add(this.ControllerScreenReaderStatePanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LauncherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screen Reader Gesture Controller";
            this.KeyMappingPanel.ResumeLayout(false);
            this.KeyMappingGroupBox.ResumeLayout(false);
            this.KeyMappingGroupBox.PerformLayout();
            this.GestureControlPanel.ResumeLayout(false);
            this.GestureControlPanel.PerformLayout();
            this.ControllerScreenReaderStatePanel.ResumeLayout(false);
            this.ControllerScreenReaderStatePanel.PerformLayout();
            this.DeviceStatus.ResumeLayout(false);
            this.DeviceStatus.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button startGestureControlButton;
        private System.Windows.Forms.Button stopGestureControlButton;
        private System.Windows.Forms.Label gestureControlLabel;
        private System.Windows.Forms.Label selectedScreenReader;
        private System.Windows.Forms.ComboBox ScreenReaderComboBox;
        private System.Windows.Forms.Button SwipeLeftMappingBtn;
        private System.Windows.Forms.Label SwipeLeftMappingLabel;
        private System.Windows.Forms.Label SwipeRightMappingLabel;
        private System.Windows.Forms.Button SwipeRightMappingBtn;
        private System.Windows.Forms.Label ScreenTapMappingLabel;
        private System.Windows.Forms.Button ScreenTapMappingBtn;
        private System.Windows.Forms.Panel KeyMappingPanel;
        private System.Windows.Forms.Panel GestureControlPanel;
        private System.Windows.Forms.Panel ControllerScreenReaderStatePanel;
        private System.Windows.Forms.Button RefreshListBtn;
        private System.Windows.Forms.GroupBox DeviceStatus;
        private System.Windows.Forms.TextBox SwipeLeftTxtBox;
        private System.Windows.Forms.TextBox LeapMotionStateTxt;
        private System.Windows.Forms.Label LeapMotionStateLabel;
        private System.Windows.Forms.GroupBox KeyMappingGroupBox;
        private System.Windows.Forms.TextBox SwipeRightTxtBox;
        private System.Windows.Forms.TextBox ScreenTapTxtBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keyMappingToolStripMenuItem;
        private System.Windows.Forms.Button OpenNewLauncherBtn;
    }
}


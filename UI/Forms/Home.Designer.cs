
namespace Launcher.Forms
{
    partial class Home
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
            this.LeapMotionStateLabel = new System.Windows.Forms.Label();
            this.LeapMotionStateTxt = new System.Windows.Forms.TextBox();
            this.SelectedScreenReader = new System.Windows.Forms.Label();
            this.ScreenReaderComboBox = new System.Windows.Forms.ComboBox();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.DeviceStatus = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackToMenuBtn = new System.Windows.Forms.Button();
            this.HomeLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HomeHeader = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.StopGestureControlButton = new System.Windows.Forms.Button();
            this.StartGestureControlButton = new System.Windows.Forms.Button();
            this.GestureControlLabel = new System.Windows.Forms.Label();
            this.DeviceStatus.SuspendLayout();
            this.panel1.SuspendLayout();
            this.HomeLayoutPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeapMotionStateLabel
            // 
            this.LeapMotionStateLabel.AutoSize = true;
            this.LeapMotionStateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeapMotionStateLabel.Location = new System.Drawing.Point(17, 43);
            this.LeapMotionStateLabel.Name = "LeapMotionStateLabel";
            this.LeapMotionStateLabel.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.LeapMotionStateLabel.Size = new System.Drawing.Size(232, 28);
            this.LeapMotionStateLabel.TabIndex = 0;
            this.LeapMotionStateLabel.Text = "Leap Motion Controller:";
            // 
            // LeapMotionStateTxt
            // 
            this.LeapMotionStateTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.LeapMotionStateTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeapMotionStateTxt.Location = new System.Drawing.Point(233, 40);
            this.LeapMotionStateTxt.Name = "LeapMotionStateTxt";
            this.LeapMotionStateTxt.ReadOnly = true;
            this.LeapMotionStateTxt.Size = new System.Drawing.Size(207, 34);
            this.LeapMotionStateTxt.TabIndex = 1;
            // 
            // SelectedScreenReader
            // 
            this.SelectedScreenReader.AutoSize = true;
            this.SelectedScreenReader.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedScreenReader.Location = new System.Drawing.Point(17, 84);
            this.SelectedScreenReader.Name = "SelectedScreenReader";
            this.SelectedScreenReader.Size = new System.Drawing.Size(224, 28);
            this.SelectedScreenReader.TabIndex = 2;
            this.SelectedScreenReader.Text = "Selected screen reader:";
            // 
            // ScreenReaderComboBox
            // 
            this.ScreenReaderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScreenReaderComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenReaderComboBox.FormattingEnabled = true;
            this.ScreenReaderComboBox.Location = new System.Drawing.Point(233, 81);
            this.ScreenReaderComboBox.Name = "ScreenReaderComboBox";
            this.ScreenReaderComboBox.Size = new System.Drawing.Size(121, 36);
            this.ScreenReaderComboBox.TabIndex = 3;
            this.ScreenReaderComboBox.SelectedIndexChanged += new System.EventHandler(this.ScreenReaderComboBox_SelectedIndexChanged);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.Location = new System.Drawing.Point(21, 117);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Padding = new System.Windows.Forms.Padding(2);
            this.RefreshBtn.Size = new System.Drawing.Size(103, 32);
            this.RefreshBtn.TabIndex = 4;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // DeviceStatus
            // 
            this.DeviceStatus.Controls.Add(this.LeapMotionStateLabel);
            this.DeviceStatus.Controls.Add(this.RefreshBtn);
            this.DeviceStatus.Controls.Add(this.LeapMotionStateTxt);
            this.DeviceStatus.Controls.Add(this.ScreenReaderComboBox);
            this.DeviceStatus.Controls.Add(this.SelectedScreenReader);
            this.DeviceStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.DeviceStatus.Location = new System.Drawing.Point(23, 17);
            this.DeviceStatus.Name = "DeviceStatus";
            this.DeviceStatus.Size = new System.Drawing.Size(446, 165);
            this.DeviceStatus.TabIndex = 6;
            this.DeviceStatus.TabStop = false;
            this.DeviceStatus.Text = "Device Status";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BackToMenuBtn);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 48);
            this.panel1.TabIndex = 5;
            // 
            // BackToMenuBtn
            // 
            this.BackToMenuBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToMenuBtn.Location = new System.Drawing.Point(13, 13);
            this.BackToMenuBtn.Name = "BackToMenuBtn";
            this.BackToMenuBtn.Size = new System.Drawing.Size(205, 32);
            this.BackToMenuBtn.TabIndex = 0;
            this.BackToMenuBtn.Text = "Back To Menu";
            this.BackToMenuBtn.UseVisualStyleBackColor = true;
            this.BackToMenuBtn.Click += new System.EventHandler(this.BackToMenuBtn_Click);
            // 
            // HomeLayoutPanel
            // 
            this.HomeLayoutPanel.Controls.Add(this.panel1);
            this.HomeLayoutPanel.Controls.Add(this.panel2);
            this.HomeLayoutPanel.Controls.Add(this.panel3);
            this.HomeLayoutPanel.Controls.Add(this.panel4);
            this.HomeLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.HomeLayoutPanel.Name = "HomeLayoutPanel";
            this.HomeLayoutPanel.Size = new System.Drawing.Size(527, 516);
            this.HomeLayoutPanel.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.HomeHeader);
            this.panel2.Location = new System.Drawing.Point(3, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(524, 52);
            this.panel2.TabIndex = 7;
            // 
            // HomeHeader
            // 
            this.HomeHeader.AutoSize = true;
            this.HomeHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.HomeHeader.Location = new System.Drawing.Point(23, 19);
            this.HomeHeader.Name = "HomeHeader";
            this.HomeHeader.Size = new System.Drawing.Size(68, 28);
            this.HomeHeader.TabIndex = 0;
            this.HomeHeader.Text = "Home";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DeviceStatus);
            this.panel3.Location = new System.Drawing.Point(3, 115);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(524, 196);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.StopGestureControlButton);
            this.panel4.Controls.Add(this.StartGestureControlButton);
            this.panel4.Controls.Add(this.GestureControlLabel);
            this.panel4.Location = new System.Drawing.Point(3, 317);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(524, 173);
            this.panel4.TabIndex = 9;
            // 
            // StopGestureControlButton
            // 
            this.StopGestureControlButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopGestureControlButton.Location = new System.Drawing.Point(185, 99);
            this.StopGestureControlButton.Name = "StopGestureControlButton";
            this.StopGestureControlButton.Padding = new System.Windows.Forms.Padding(2);
            this.StopGestureControlButton.Size = new System.Drawing.Size(103, 32);
            this.StopGestureControlButton.TabIndex = 6;
            this.StopGestureControlButton.Text = "Stop";
            this.StopGestureControlButton.UseVisualStyleBackColor = true;
            this.StopGestureControlButton.Click += new System.EventHandler(this.StopGestureControlButton_Click);
            // 
            // StartGestureControlButton
            // 
            this.StartGestureControlButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGestureControlButton.Location = new System.Drawing.Point(185, 51);
            this.StartGestureControlButton.Name = "StartGestureControlButton";
            this.StartGestureControlButton.Padding = new System.Windows.Forms.Padding(2);
            this.StartGestureControlButton.Size = new System.Drawing.Size(103, 32);
            this.StartGestureControlButton.TabIndex = 5;
            this.StartGestureControlButton.Text = "Start";
            this.StartGestureControlButton.UseVisualStyleBackColor = true;
            this.StartGestureControlButton.Click += new System.EventHandler(this.StartGestureControlButton_Click);
            // 
            // GestureControlLabel
            // 
            this.GestureControlLabel.AutoSize = true;
            this.GestureControlLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.GestureControlLabel.Location = new System.Drawing.Point(27, 16);
            this.GestureControlLabel.Name = "GestureControlLabel";
            this.GestureControlLabel.Size = new System.Drawing.Size(161, 28);
            this.GestureControlLabel.TabIndex = 0;
            this.GestureControlLabel.Text = "Gesture Control:";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 516);
            this.Controls.Add(this.HomeLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.DeviceStatus.ResumeLayout(false);
            this.DeviceStatus.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.HomeLayoutPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LeapMotionStateLabel;
        private System.Windows.Forms.TextBox LeapMotionStateTxt;
        private System.Windows.Forms.Label SelectedScreenReader;
        private System.Windows.Forms.ComboBox ScreenReaderComboBox;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.GroupBox DeviceStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BackToMenuBtn;
        private System.Windows.Forms.FlowLayoutPanel HomeLayoutPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label HomeHeader;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button StopGestureControlButton;
        private System.Windows.Forms.Button StartGestureControlButton;
        private System.Windows.Forms.Label GestureControlLabel;
    }
}
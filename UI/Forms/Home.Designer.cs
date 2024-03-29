﻿
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
            this.HomeHeader = new System.Windows.Forms.Label();
            this.BackToMenuBtn = new System.Windows.Forms.Button();
            this.HomeLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SessionExplanation = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SessionGroupBox = new System.Windows.Forms.GroupBox();
            this.StartGestureControlButton = new System.Windows.Forms.Button();
            this.StopGestureControlButton = new System.Windows.Forms.Button();
            this.DeviceStatus.SuspendLayout();
            this.panel1.SuspendLayout();
            this.HomeLayoutPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SessionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeapMotionStateLabel
            // 
            this.LeapMotionStateLabel.AutoSize = true;
            this.LeapMotionStateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeapMotionStateLabel.Location = new System.Drawing.Point(17, 43);
            this.LeapMotionStateLabel.Name = "LeapMotionStateLabel";
            this.LeapMotionStateLabel.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.LeapMotionStateLabel.Size = new System.Drawing.Size(189, 21);
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
            this.LeapMotionStateTxt.Size = new System.Drawing.Size(207, 29);
            this.LeapMotionStateTxt.TabIndex = 1;
            // 
            // SelectedScreenReader
            // 
            this.SelectedScreenReader.AutoSize = true;
            this.SelectedScreenReader.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedScreenReader.Location = new System.Drawing.Point(17, 84);
            this.SelectedScreenReader.Name = "SelectedScreenReader";
            this.SelectedScreenReader.Size = new System.Drawing.Size(165, 21);
            this.SelectedScreenReader.TabIndex = 2;
            this.SelectedScreenReader.Text = "Active screen reader:";
            // 
            // ScreenReaderComboBox
            // 
            this.ScreenReaderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScreenReaderComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenReaderComboBox.FormattingEnabled = true;
            this.ScreenReaderComboBox.Location = new System.Drawing.Point(233, 81);
            this.ScreenReaderComboBox.Name = "ScreenReaderComboBox";
            this.ScreenReaderComboBox.Size = new System.Drawing.Size(207, 29);
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
            this.DeviceStatus.Location = new System.Drawing.Point(23, 104);
            this.DeviceStatus.Name = "DeviceStatus";
            this.DeviceStatus.Size = new System.Drawing.Size(446, 165);
            this.DeviceStatus.TabIndex = 6;
            this.DeviceStatus.TabStop = false;
            this.DeviceStatus.Text = "Device Status";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HomeHeader);
            this.panel1.Controls.Add(this.BackToMenuBtn);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 48);
            this.panel1.TabIndex = 5;
            // 
            // HomeHeader
            // 
            this.HomeHeader.AutoSize = true;
            this.HomeHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.HomeHeader.Location = new System.Drawing.Point(222, 12);
            this.HomeHeader.Name = "HomeHeader";
            this.HomeHeader.Size = new System.Drawing.Size(64, 25);
            this.HomeHeader.TabIndex = 0;
            this.HomeHeader.Text = "Home";
            // 
            // BackToMenuBtn
            // 
            this.BackToMenuBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToMenuBtn.Location = new System.Drawing.Point(23, 9);
            this.BackToMenuBtn.Name = "BackToMenuBtn";
            this.BackToMenuBtn.Size = new System.Drawing.Size(149, 32);
            this.BackToMenuBtn.TabIndex = 0;
            this.BackToMenuBtn.Text = "Back To Menu";
            this.BackToMenuBtn.UseVisualStyleBackColor = true;
            this.BackToMenuBtn.Click += new System.EventHandler(this.BackToMenuBtn_Click);
            // 
            // HomeLayoutPanel
            // 
            this.HomeLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeLayoutPanel.Controls.Add(this.panel1);
            this.HomeLayoutPanel.Controls.Add(this.panel3);
            this.HomeLayoutPanel.Controls.Add(this.panel4);
            this.HomeLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.HomeLayoutPanel.Name = "HomeLayoutPanel";
            this.HomeLayoutPanel.Size = new System.Drawing.Size(524, 516);
            this.HomeLayoutPanel.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SessionExplanation);
            this.panel3.Controls.Add(this.DeviceStatus);
            this.panel3.Location = new System.Drawing.Point(3, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(524, 295);
            this.panel3.TabIndex = 8;
            // 
            // SessionExplanation
            // 
            this.SessionExplanation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SessionExplanation.Cursor = System.Windows.Forms.Cursors.Default;
            this.SessionExplanation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.SessionExplanation.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SessionExplanation.Location = new System.Drawing.Point(23, 36);
            this.SessionExplanation.Multiline = true;
            this.SessionExplanation.Name = "SessionExplanation";
            this.SessionExplanation.ReadOnly = true;
            this.SessionExplanation.Size = new System.Drawing.Size(446, 39);
            this.SessionExplanation.TabIndex = 4;
            this.SessionExplanation.Text = "If this is your first time starting a session go to Help and Settings for the fir" +
    "st steps and gesture mappings.";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.SessionGroupBox);
            this.panel4.Location = new System.Drawing.Point(3, 358);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(524, 144);
            this.panel4.TabIndex = 9;
            // 
            // SessionGroupBox
            // 
            this.SessionGroupBox.Controls.Add(this.StartGestureControlButton);
            this.SessionGroupBox.Controls.Add(this.StopGestureControlButton);
            this.SessionGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.SessionGroupBox.Location = new System.Drawing.Point(23, 18);
            this.SessionGroupBox.Name = "SessionGroupBox";
            this.SessionGroupBox.Size = new System.Drawing.Size(446, 96);
            this.SessionGroupBox.TabIndex = 0;
            this.SessionGroupBox.TabStop = false;
            this.SessionGroupBox.Text = "Session";
            // 
            // StartGestureControlButton
            // 
            this.StartGestureControlButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGestureControlButton.Location = new System.Drawing.Point(62, 41);
            this.StartGestureControlButton.Name = "StartGestureControlButton";
            this.StartGestureControlButton.Padding = new System.Windows.Forms.Padding(2);
            this.StartGestureControlButton.Size = new System.Drawing.Size(103, 32);
            this.StartGestureControlButton.TabIndex = 5;
            this.StartGestureControlButton.Text = "Start";
            this.StartGestureControlButton.UseVisualStyleBackColor = true;
            this.StartGestureControlButton.Click += new System.EventHandler(this.StartGestureControlButton_Click);
            // 
            // StopGestureControlButton
            // 
            this.StopGestureControlButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopGestureControlButton.Location = new System.Drawing.Point(260, 41);
            this.StopGestureControlButton.Name = "StopGestureControlButton";
            this.StopGestureControlButton.Padding = new System.Windows.Forms.Padding(2);
            this.StopGestureControlButton.Size = new System.Drawing.Size(103, 32);
            this.StopGestureControlButton.TabIndex = 6;
            this.StopGestureControlButton.Text = "Stop";
            this.StopGestureControlButton.UseVisualStyleBackColor = true;
            this.StopGestureControlButton.Click += new System.EventHandler(this.StopGestureControlButton_Click);
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(527, 516);
            this.ControlBox = false;
            this.Controls.Add(this.HomeLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.DeviceStatus.ResumeLayout(false);
            this.DeviceStatus.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.HomeLayoutPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.SessionGroupBox.ResumeLayout(false);
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
        private System.Windows.Forms.Label HomeHeader;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button StopGestureControlButton;
        private System.Windows.Forms.Button StartGestureControlButton;
        private System.Windows.Forms.GroupBox SessionGroupBox;
        private System.Windows.Forms.TextBox SessionExplanation;
    }
}
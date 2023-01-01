
namespace Launcher.Forms
{
    partial class HelpView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpView));
            this.HelpLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackToMenuButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.HelpHeader = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GestureExplanationGroupBox = new System.Windows.Forms.GroupBox();
            this.FistTextBox = new System.Windows.Forms.TextBox();
            this.HandSwipeLabel = new System.Windows.Forms.Label();
            this.CircleTextBox = new System.Windows.Forms.TextBox();
            this.CircleLabel = new System.Windows.Forms.Label();
            this.ScreenTapTextBox = new System.Windows.Forms.TextBox();
            this.ScreenTapLabel = new System.Windows.Forms.Label();
            this.HandSwipeTextBox = new System.Windows.Forms.TextBox();
            this.FistLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LeapMotionExplanationGroupBox = new System.Windows.Forms.GroupBox();
            this.LeapMotionExplanationTextBox = new System.Windows.Forms.TextBox();
            this.DownloadLeapMotionSdk = new System.Windows.Forms.Button();
            this.HelpLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.GestureExplanationGroupBox.SuspendLayout();
            this.panel3.SuspendLayout();
            this.LeapMotionExplanationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HelpLayoutPanel
            // 
            this.HelpLayoutPanel.Controls.Add(this.panel1);
            this.HelpLayoutPanel.Controls.Add(this.panel4);
            this.HelpLayoutPanel.Controls.Add(this.panel2);
            this.HelpLayoutPanel.Controls.Add(this.panel3);
            this.HelpLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HelpLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.HelpLayoutPanel.Name = "HelpLayoutPanel";
            this.HelpLayoutPanel.Size = new System.Drawing.Size(527, 516);
            this.HelpLayoutPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BackToMenuButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 48);
            this.panel1.TabIndex = 1;
            // 
            // BackToMenuButton
            // 
            this.BackToMenuButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToMenuButton.Location = new System.Drawing.Point(13, 9);
            this.BackToMenuButton.Name = "BackToMenuButton";
            this.BackToMenuButton.Size = new System.Drawing.Size(205, 32);
            this.BackToMenuButton.TabIndex = 0;
            this.BackToMenuButton.Text = "Back To Menu";
            this.BackToMenuButton.UseVisualStyleBackColor = true;
            this.BackToMenuButton.Click += new System.EventHandler(this.BackToMenuButton_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.HelpHeader);
            this.panel4.Location = new System.Drawing.Point(3, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(524, 52);
            this.panel4.TabIndex = 2;
            // 
            // HelpHeader
            // 
            this.HelpHeader.AccessibleName = "testetset";
            this.HelpHeader.AutoSize = true;
            this.HelpHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.HelpHeader.Location = new System.Drawing.Point(23, 19);
            this.HelpHeader.Name = "HelpHeader";
            this.HelpHeader.Size = new System.Drawing.Size(45, 21);
            this.HelpHeader.TabIndex = 0;
            this.HelpHeader.Text = "Help";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GestureExplanationGroupBox);
            this.panel2.Location = new System.Drawing.Point(3, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(524, 250);
            this.panel2.TabIndex = 3;
            // 
            // GestureExplanationGroupBox
            // 
            this.GestureExplanationGroupBox.Controls.Add(this.FistTextBox);
            this.GestureExplanationGroupBox.Controls.Add(this.HandSwipeLabel);
            this.GestureExplanationGroupBox.Controls.Add(this.CircleTextBox);
            this.GestureExplanationGroupBox.Controls.Add(this.CircleLabel);
            this.GestureExplanationGroupBox.Controls.Add(this.ScreenTapTextBox);
            this.GestureExplanationGroupBox.Controls.Add(this.ScreenTapLabel);
            this.GestureExplanationGroupBox.Controls.Add(this.HandSwipeTextBox);
            this.GestureExplanationGroupBox.Controls.Add(this.FistLabel);
            this.GestureExplanationGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.GestureExplanationGroupBox.Location = new System.Drawing.Point(13, 4);
            this.GestureExplanationGroupBox.Name = "GestureExplanationGroupBox";
            this.GestureExplanationGroupBox.Size = new System.Drawing.Size(499, 237);
            this.GestureExplanationGroupBox.TabIndex = 0;
            this.GestureExplanationGroupBox.TabStop = false;
            this.GestureExplanationGroupBox.Text = "How to form the gestures";
            // 
            // FistTextBox
            // 
            this.FistTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FistTextBox.Location = new System.Drawing.Point(108, 194);
            this.FistTextBox.Multiline = true;
            this.FistTextBox.Name = "FistTextBox";
            this.FistTextBox.ReadOnly = true;
            this.FistTextBox.Size = new System.Drawing.Size(364, 34);
            this.FistTextBox.TabIndex = 7;
            this.FistTextBox.Text = "Bend all fingers toward the palms of your hand to form a closing fist.";
            // 
            // HandSwipeLabel
            // 
            this.HandSwipeLabel.AutoSize = true;
            this.HandSwipeLabel.Location = new System.Drawing.Point(7, 200);
            this.HandSwipeLabel.Name = "HandSwipeLabel";
            this.HandSwipeLabel.Size = new System.Drawing.Size(39, 21);
            this.HandSwipeLabel.TabIndex = 6;
            this.HandSwipeLabel.Text = "Fist:";
            // 
            // CircleTextBox
            // 
            this.CircleTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CircleTextBox.Location = new System.Drawing.Point(108, 151);
            this.CircleTextBox.Multiline = true;
            this.CircleTextBox.Name = "CircleTextBox";
            this.CircleTextBox.ReadOnly = true;
            this.CircleTextBox.Size = new System.Drawing.Size(364, 34);
            this.CircleTextBox.TabIndex = 5;
            this.CircleTextBox.Text = "Extend your index finger and move your finger away from your body in a short moti" +
    "on, as if poking something";
            // 
            // CircleLabel
            // 
            this.CircleLabel.AutoSize = true;
            this.CircleLabel.Location = new System.Drawing.Point(7, 157);
            this.CircleLabel.Name = "CircleLabel";
            this.CircleLabel.Size = new System.Drawing.Size(89, 21);
            this.CircleLabel.TabIndex = 4;
            this.CircleLabel.Text = "ScreenTap:";
            // 
            // ScreenTapTextBox
            // 
            this.ScreenTapTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenTapTextBox.Location = new System.Drawing.Point(108, 111);
            this.ScreenTapTextBox.Multiline = true;
            this.ScreenTapTextBox.Name = "ScreenTapTextBox";
            this.ScreenTapTextBox.ReadOnly = true;
            this.ScreenTapTextBox.Size = new System.Drawing.Size(364, 34);
            this.ScreenTapTextBox.TabIndex = 3;
            this.ScreenTapTextBox.Text = "Extend your index finger and circle with the fingertip clockwise or counterclockw" +
    "ise as if drawing a circle with the fingertip";
            // 
            // ScreenTapLabel
            // 
            this.ScreenTapLabel.AutoSize = true;
            this.ScreenTapLabel.Location = new System.Drawing.Point(7, 113);
            this.ScreenTapLabel.Name = "ScreenTapLabel";
            this.ScreenTapLabel.Size = new System.Drawing.Size(55, 21);
            this.ScreenTapLabel.TabIndex = 2;
            this.ScreenTapLabel.Text = "Circle:";
            // 
            // HandSwipeTextBox
            // 
            this.HandSwipeTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HandSwipeTextBox.Location = new System.Drawing.Point(108, 54);
            this.HandSwipeTextBox.Multiline = true;
            this.HandSwipeTextBox.Name = "HandSwipeTextBox";
            this.HandSwipeTextBox.ReadOnly = true;
            this.HandSwipeTextBox.Size = new System.Drawing.Size(364, 51);
            this.HandSwipeTextBox.TabIndex = 1;
            this.HandSwipeTextBox.Text = resources.GetString("HandSwipeTextBox.Text");
            // 
            // FistLabel
            // 
            this.FistLabel.AutoSize = true;
            this.FistLabel.Location = new System.Drawing.Point(7, 54);
            this.FistLabel.Name = "FistLabel";
            this.FistLabel.Size = new System.Drawing.Size(95, 21);
            this.FistLabel.TabIndex = 0;
            this.FistLabel.Text = "Handswipe:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LeapMotionExplanationGroupBox);
            this.panel3.Location = new System.Drawing.Point(3, 371);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(524, 145);
            this.panel3.TabIndex = 4;
            // 
            // LeapMotionExplanationGroupBox
            // 
            this.LeapMotionExplanationGroupBox.Controls.Add(this.LeapMotionExplanationTextBox);
            this.LeapMotionExplanationGroupBox.Controls.Add(this.DownloadLeapMotionSdk);
            this.LeapMotionExplanationGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LeapMotionExplanationGroupBox.Location = new System.Drawing.Point(13, 5);
            this.LeapMotionExplanationGroupBox.Name = "LeapMotionExplanationGroupBox";
            this.LeapMotionExplanationGroupBox.Size = new System.Drawing.Size(499, 115);
            this.LeapMotionExplanationGroupBox.TabIndex = 0;
            this.LeapMotionExplanationGroupBox.TabStop = false;
            this.LeapMotionExplanationGroupBox.Text = "About the Leap Motion Controller";
            // 
            // LeapMotionExplanationTextBox
            // 
            this.LeapMotionExplanationTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeapMotionExplanationTextBox.Location = new System.Drawing.Point(11, 31);
            this.LeapMotionExplanationTextBox.Multiline = true;
            this.LeapMotionExplanationTextBox.Name = "LeapMotionExplanationTextBox";
            this.LeapMotionExplanationTextBox.ReadOnly = true;
            this.LeapMotionExplanationTextBox.Size = new System.Drawing.Size(461, 31);
            this.LeapMotionExplanationTextBox.TabIndex = 8;
            this.LeapMotionExplanationTextBox.Text = "Explanation of the controller, how to set up and connect";
            // 
            // DownloadLeapMotionSdk
            // 
            this.DownloadLeapMotionSdk.Location = new System.Drawing.Point(11, 71);
            this.DownloadLeapMotionSdk.Name = "DownloadLeapMotionSdk";
            this.DownloadLeapMotionSdk.Size = new System.Drawing.Size(133, 36);
            this.DownloadLeapMotionSdk.TabIndex = 9;
            this.DownloadLeapMotionSdk.Text = "Download V2";
            this.DownloadLeapMotionSdk.UseVisualStyleBackColor = true;
            this.DownloadLeapMotionSdk.Click += new System.EventHandler(this.DownloadLeapMotionSdkBtn_Click);
            // 
            // HelpView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(527, 516);
            this.Controls.Add(this.HelpLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HelpView";
            this.Text = "Help";
            this.HelpLayoutPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.GestureExplanationGroupBox.ResumeLayout(false);
            this.GestureExplanationGroupBox.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.LeapMotionExplanationGroupBox.ResumeLayout(false);
            this.LeapMotionExplanationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel HelpLayoutPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BackToMenuButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox GestureExplanationGroupBox;
        private System.Windows.Forms.Label FistLabel;
        private System.Windows.Forms.TextBox HandSwipeTextBox;
        private System.Windows.Forms.TextBox CircleTextBox;
        private System.Windows.Forms.Label CircleLabel;
        private System.Windows.Forms.TextBox ScreenTapTextBox;
        private System.Windows.Forms.Label ScreenTapLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox LeapMotionExplanationGroupBox;
        private System.Windows.Forms.Button DownloadLeapMotionSdk;
        private System.Windows.Forms.TextBox FistTextBox;
        private System.Windows.Forms.Label HandSwipeLabel;
        private System.Windows.Forms.TextBox LeapMotionExplanationTextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label HelpHeader;
    }
}
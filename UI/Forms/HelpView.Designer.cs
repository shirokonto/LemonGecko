
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
            this.HelpHeader = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LeapMotionExplanationGroupBox = new System.Windows.Forms.GroupBox();
            this.LeapMotionExplanationTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GestureExplanationGroupBox = new System.Windows.Forms.GroupBox();
            this.HandSwipeTextBox = new System.Windows.Forms.TextBox();
            this.CircleLabel = new System.Windows.Forms.Label();
            this.FistTextBox = new System.Windows.Forms.TextBox();
            this.HandSwipeLabel = new System.Windows.Forms.Label();
            this.CircleTextBox = new System.Windows.Forms.TextBox();
            this.ScreenTapTextBox = new System.Windows.Forms.TextBox();
            this.ScreenTapLabel = new System.Windows.Forms.Label();
            this.FistLabel = new System.Windows.Forms.Label();
            this.HelpLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.LeapMotionExplanationGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.GestureExplanationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HelpLayoutPanel
            // 
            this.HelpLayoutPanel.Controls.Add(this.panel1);
            this.HelpLayoutPanel.Controls.Add(this.panel3);
            this.HelpLayoutPanel.Controls.Add(this.panel2);
            this.HelpLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HelpLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.HelpLayoutPanel.Name = "HelpLayoutPanel";
            this.HelpLayoutPanel.Size = new System.Drawing.Size(527, 516);
            this.HelpLayoutPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HelpHeader);
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
            // HelpHeader
            // 
            this.HelpHeader.AccessibleName = "testetset";
            this.HelpHeader.AutoSize = true;
            this.HelpHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.HelpHeader.Location = new System.Drawing.Point(224, 15);
            this.HelpHeader.Name = "HelpHeader";
            this.HelpHeader.Size = new System.Drawing.Size(45, 21);
            this.HelpHeader.TabIndex = 0;
            this.HelpHeader.Text = "Help";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LeapMotionExplanationGroupBox);
            this.panel3.Location = new System.Drawing.Point(3, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(524, 153);
            this.panel3.TabIndex = 3;
            // 
            // LeapMotionExplanationGroupBox
            // 
            this.LeapMotionExplanationGroupBox.Controls.Add(this.LeapMotionExplanationTextBox);
            this.LeapMotionExplanationGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LeapMotionExplanationGroupBox.Location = new System.Drawing.Point(13, 5);
            this.LeapMotionExplanationGroupBox.Name = "LeapMotionExplanationGroupBox";
            this.LeapMotionExplanationGroupBox.Size = new System.Drawing.Size(499, 143);
            this.LeapMotionExplanationGroupBox.TabIndex = 0;
            this.LeapMotionExplanationGroupBox.TabStop = false;
            this.LeapMotionExplanationGroupBox.Text = "About Lemon Gecko";
            // 
            // LeapMotionExplanationTextBox
            // 
            this.LeapMotionExplanationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LeapMotionExplanationTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeapMotionExplanationTextBox.Location = new System.Drawing.Point(11, 24);
            this.LeapMotionExplanationTextBox.Multiline = true;
            this.LeapMotionExplanationTextBox.Name = "LeapMotionExplanationTextBox";
            this.LeapMotionExplanationTextBox.ReadOnly = true;
            this.LeapMotionExplanationTextBox.Size = new System.Drawing.Size(461, 113);
            this.LeapMotionExplanationTextBox.TabIndex = 1;
            this.LeapMotionExplanationTextBox.Text = resources.GetString("LeapMotionExplanationTextBox.Text");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GestureExplanationGroupBox);
            this.panel2.Location = new System.Drawing.Point(3, 216);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(524, 288);
            this.panel2.TabIndex = 4;
            // 
            // GestureExplanationGroupBox
            // 
            this.GestureExplanationGroupBox.Controls.Add(this.HandSwipeTextBox);
            this.GestureExplanationGroupBox.Controls.Add(this.CircleLabel);
            this.GestureExplanationGroupBox.Controls.Add(this.FistTextBox);
            this.GestureExplanationGroupBox.Controls.Add(this.HandSwipeLabel);
            this.GestureExplanationGroupBox.Controls.Add(this.CircleTextBox);
            this.GestureExplanationGroupBox.Controls.Add(this.ScreenTapTextBox);
            this.GestureExplanationGroupBox.Controls.Add(this.ScreenTapLabel);
            this.GestureExplanationGroupBox.Controls.Add(this.FistLabel);
            this.GestureExplanationGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.GestureExplanationGroupBox.Location = new System.Drawing.Point(13, 4);
            this.GestureExplanationGroupBox.Name = "GestureExplanationGroupBox";
            this.GestureExplanationGroupBox.Size = new System.Drawing.Size(499, 266);
            this.GestureExplanationGroupBox.TabIndex = 0;
            this.GestureExplanationGroupBox.TabStop = false;
            this.GestureExplanationGroupBox.Text = "How to form the gestures";
            // 
            // HandSwipeTextBox
            // 
            this.HandSwipeTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HandSwipeTextBox.Location = new System.Drawing.Point(108, 153);
            this.HandSwipeTextBox.Multiline = true;
            this.HandSwipeTextBox.Name = "HandSwipeTextBox";
            this.HandSwipeTextBox.ReadOnly = true;
            this.HandSwipeTextBox.Size = new System.Drawing.Size(364, 52);
            this.HandSwipeTextBox.TabIndex = 5;
            this.HandSwipeTextBox.Text = "Hold your hand flat and move it in one direction. When moving to the right or lef" +
    "t, the palm should face vertically outwards. When moving up and down, the palm s" +
    "hould face down.";
            // 
            // CircleLabel
            // 
            this.CircleLabel.AutoSize = true;
            this.CircleLabel.Location = new System.Drawing.Point(7, 27);
            this.CircleLabel.Name = "CircleLabel";
            this.CircleLabel.Size = new System.Drawing.Size(89, 21);
            this.CircleLabel.TabIndex = 0;
            this.CircleLabel.Text = "ScreenTap:";
            // 
            // FistTextBox
            // 
            this.FistTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FistTextBox.Location = new System.Drawing.Point(108, 215);
            this.FistTextBox.Multiline = true;
            this.FistTextBox.Name = "FistTextBox";
            this.FistTextBox.ReadOnly = true;
            this.FistTextBox.Size = new System.Drawing.Size(364, 40);
            this.FistTextBox.TabIndex = 7;
            this.FistTextBox.Text = "Bend all fingers toward the palms of your hand to form a closing fist.";
            // 
            // HandSwipeLabel
            // 
            this.HandSwipeLabel.AutoSize = true;
            this.HandSwipeLabel.Location = new System.Drawing.Point(7, 221);
            this.HandSwipeLabel.Name = "HandSwipeLabel";
            this.HandSwipeLabel.Size = new System.Drawing.Size(39, 21);
            this.HandSwipeLabel.TabIndex = 6;
            this.HandSwipeLabel.Text = "Fist:";
            // 
            // CircleTextBox
            // 
            this.CircleTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CircleTextBox.Location = new System.Drawing.Point(108, 27);
            this.CircleTextBox.Multiline = true;
            this.CircleTextBox.Name = "CircleTextBox";
            this.CircleTextBox.ReadOnly = true;
            this.CircleTextBox.Size = new System.Drawing.Size(364, 52);
            this.CircleTextBox.TabIndex = 1;
            this.CircleTextBox.Text = "Form a fist with the palm facing down and extend the index finger. Move the finge" +
    "r away from your body in a short motion, as if poking something.";
            // 
            // ScreenTapTextBox
            // 
            this.ScreenTapTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenTapTextBox.Location = new System.Drawing.Point(108, 90);
            this.ScreenTapTextBox.Multiline = true;
            this.ScreenTapTextBox.Name = "ScreenTapTextBox";
            this.ScreenTapTextBox.ReadOnly = true;
            this.ScreenTapTextBox.Size = new System.Drawing.Size(364, 54);
            this.ScreenTapTextBox.TabIndex = 3;
            this.ScreenTapTextBox.Text = "Form a fist with the palm facing down and extend the index finger. Circle your fi" +
    "nger clockwise or counterclockwise, as if drawing a circle with your fingertip.";
            // 
            // ScreenTapLabel
            // 
            this.ScreenTapLabel.AutoSize = true;
            this.ScreenTapLabel.Location = new System.Drawing.Point(7, 92);
            this.ScreenTapLabel.Name = "ScreenTapLabel";
            this.ScreenTapLabel.Size = new System.Drawing.Size(55, 21);
            this.ScreenTapLabel.TabIndex = 2;
            this.ScreenTapLabel.Text = "Circle:";
            // 
            // FistLabel
            // 
            this.FistLabel.AutoSize = true;
            this.FistLabel.Location = new System.Drawing.Point(7, 159);
            this.FistLabel.Name = "FistLabel";
            this.FistLabel.Size = new System.Drawing.Size(95, 21);
            this.FistLabel.TabIndex = 4;
            this.FistLabel.Text = "Handswipe:";
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
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.LeapMotionExplanationGroupBox.ResumeLayout(false);
            this.LeapMotionExplanationGroupBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.GestureExplanationGroupBox.ResumeLayout(false);
            this.GestureExplanationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel HelpLayoutPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BackToMenuButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox GestureExplanationGroupBox;
        private System.Windows.Forms.Label FistLabel;
        private System.Windows.Forms.TextBox CircleTextBox;
        private System.Windows.Forms.TextBox ScreenTapTextBox;
        private System.Windows.Forms.Label ScreenTapLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox LeapMotionExplanationGroupBox;
        private System.Windows.Forms.TextBox FistTextBox;
        private System.Windows.Forms.Label HandSwipeLabel;
        private System.Windows.Forms.TextBox LeapMotionExplanationTextBox;
        private System.Windows.Forms.Label HelpHeader;
        private System.Windows.Forms.TextBox HandSwipeTextBox;
        private System.Windows.Forms.Label CircleLabel;
    }
}
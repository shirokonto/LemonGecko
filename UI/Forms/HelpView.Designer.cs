
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
            this.HelpHeader = new System.Windows.Forms.Label();
            this.BackToMenuButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LemonGeckoExplanationGroupBox = new System.Windows.Forms.GroupBox();
            this.AboutLemonGeckoTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GestureExplanationGroupBox = new System.Windows.Forms.GroupBox();
            this.HandSwipeTextBox = new System.Windows.Forms.TextBox();
            this.ScreenTapLabel = new System.Windows.Forms.Label();
            this.PunchTextBox = new System.Windows.Forms.TextBox();
            this.PunchLabel = new System.Windows.Forms.Label();
            this.ScreenTapTextBox = new System.Windows.Forms.TextBox();
            this.CircleTextBox = new System.Windows.Forms.TextBox();
            this.CircleLabel = new System.Windows.Forms.Label();
            this.HandSwipeLabel = new System.Windows.Forms.Label();
            this.HelpLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.LemonGeckoExplanationGroupBox.SuspendLayout();
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
            // BackToMenuButton
            // 
            this.BackToMenuButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToMenuButton.Location = new System.Drawing.Point(23, 9);
            this.BackToMenuButton.Name = "BackToMenuButton";
            this.BackToMenuButton.Size = new System.Drawing.Size(149, 32);
            this.BackToMenuButton.TabIndex = 0;
            this.BackToMenuButton.Text = "Back To Menu";
            this.BackToMenuButton.UseVisualStyleBackColor = true;
            this.BackToMenuButton.Click += new System.EventHandler(this.BackToMenuButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LemonGeckoExplanationGroupBox);
            this.panel3.Location = new System.Drawing.Point(3, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(524, 153);
            this.panel3.TabIndex = 3;
            // 
            // LemonGeckoExplanationGroupBox
            // 
            this.LemonGeckoExplanationGroupBox.Controls.Add(this.AboutLemonGeckoTextBox);
            this.LemonGeckoExplanationGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LemonGeckoExplanationGroupBox.Location = new System.Drawing.Point(13, 5);
            this.LemonGeckoExplanationGroupBox.Name = "LemonGeckoExplanationGroupBox";
            this.LemonGeckoExplanationGroupBox.Size = new System.Drawing.Size(499, 143);
            this.LemonGeckoExplanationGroupBox.TabIndex = 0;
            this.LemonGeckoExplanationGroupBox.TabStop = false;
            this.LemonGeckoExplanationGroupBox.Text = "About Lemon Gecko";
            // 
            // AboutLemonGeckoTextBox
            // 
            this.AboutLemonGeckoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AboutLemonGeckoTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutLemonGeckoTextBox.Location = new System.Drawing.Point(11, 24);
            this.AboutLemonGeckoTextBox.Multiline = true;
            this.AboutLemonGeckoTextBox.Name = "AboutLemonGeckoTextBox";
            this.AboutLemonGeckoTextBox.ReadOnly = true;
            this.AboutLemonGeckoTextBox.Size = new System.Drawing.Size(461, 113);
            this.AboutLemonGeckoTextBox.TabIndex = 1;
            this.AboutLemonGeckoTextBox.Text = resources.GetString("AboutLemonGeckoTextBox.Text");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GestureExplanationGroupBox);
            this.panel2.Location = new System.Drawing.Point(3, 216);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(524, 300);
            this.panel2.TabIndex = 4;
            // 
            // GestureExplanationGroupBox
            // 
            this.GestureExplanationGroupBox.Controls.Add(this.HandSwipeTextBox);
            this.GestureExplanationGroupBox.Controls.Add(this.ScreenTapLabel);
            this.GestureExplanationGroupBox.Controls.Add(this.PunchTextBox);
            this.GestureExplanationGroupBox.Controls.Add(this.PunchLabel);
            this.GestureExplanationGroupBox.Controls.Add(this.ScreenTapTextBox);
            this.GestureExplanationGroupBox.Controls.Add(this.CircleTextBox);
            this.GestureExplanationGroupBox.Controls.Add(this.CircleLabel);
            this.GestureExplanationGroupBox.Controls.Add(this.HandSwipeLabel);
            this.GestureExplanationGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.GestureExplanationGroupBox.Location = new System.Drawing.Point(13, 4);
            this.GestureExplanationGroupBox.Name = "GestureExplanationGroupBox";
            this.GestureExplanationGroupBox.Size = new System.Drawing.Size(499, 284);
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
            // ScreenTapLabel
            // 
            this.ScreenTapLabel.AutoSize = true;
            this.ScreenTapLabel.Location = new System.Drawing.Point(7, 27);
            this.ScreenTapLabel.Name = "ScreenTapLabel";
            this.ScreenTapLabel.Size = new System.Drawing.Size(89, 21);
            this.ScreenTapLabel.TabIndex = 0;
            this.ScreenTapLabel.Text = "ScreenTap:";
            // 
            // PunchTextBox
            // 
            this.PunchTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PunchTextBox.Location = new System.Drawing.Point(108, 215);
            this.PunchTextBox.Multiline = true;
            this.PunchTextBox.Name = "PunchTextBox";
            this.PunchTextBox.ReadOnly = true;
            this.PunchTextBox.Size = new System.Drawing.Size(364, 51);
            this.PunchTextBox.TabIndex = 7;
            this.PunchTextBox.Text = "Bend all fingers toward the palms of your hand to form a closing fist.  Move the " +
    "hand vertically away from your body in a short punch motion.";
            // 
            // PunchLabel
            // 
            this.PunchLabel.AutoSize = true;
            this.PunchLabel.Location = new System.Drawing.Point(7, 221);
            this.PunchLabel.Name = "PunchLabel";
            this.PunchLabel.Size = new System.Drawing.Size(58, 21);
            this.PunchLabel.TabIndex = 6;
            this.PunchLabel.Text = "Punch:";
            // 
            // ScreenTapTextBox
            // 
            this.ScreenTapTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenTapTextBox.Location = new System.Drawing.Point(108, 27);
            this.ScreenTapTextBox.Multiline = true;
            this.ScreenTapTextBox.Name = "ScreenTapTextBox";
            this.ScreenTapTextBox.ReadOnly = true;
            this.ScreenTapTextBox.Size = new System.Drawing.Size(364, 52);
            this.ScreenTapTextBox.TabIndex = 1;
            this.ScreenTapTextBox.Text = "Form a fist with the palm facing down and extend the index finger. Move the finge" +
    "r away from your body in a short motion, as if poking something.";
            // 
            // CircleTextBox
            // 
            this.CircleTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CircleTextBox.Location = new System.Drawing.Point(108, 90);
            this.CircleTextBox.Multiline = true;
            this.CircleTextBox.Name = "CircleTextBox";
            this.CircleTextBox.ReadOnly = true;
            this.CircleTextBox.Size = new System.Drawing.Size(364, 54);
            this.CircleTextBox.TabIndex = 3;
            this.CircleTextBox.Text = "Form a fist with the palm facing down and extend the index finger. Circle your fi" +
    "nger clockwise or counterclockwise, as if drawing a circle with your fingertip.";
            // 
            // CircleLabel
            // 
            this.CircleLabel.AutoSize = true;
            this.CircleLabel.Location = new System.Drawing.Point(7, 92);
            this.CircleLabel.Name = "CircleLabel";
            this.CircleLabel.Size = new System.Drawing.Size(55, 21);
            this.CircleLabel.TabIndex = 2;
            this.CircleLabel.Text = "Circle:";
            // 
            // HandSwipeLabel
            // 
            this.HandSwipeLabel.AutoSize = true;
            this.HandSwipeLabel.Location = new System.Drawing.Point(7, 159);
            this.HandSwipeLabel.Name = "HandSwipeLabel";
            this.HandSwipeLabel.Size = new System.Drawing.Size(95, 21);
            this.HandSwipeLabel.TabIndex = 4;
            this.HandSwipeLabel.Text = "Handswipe:";
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
            this.LemonGeckoExplanationGroupBox.ResumeLayout(false);
            this.LemonGeckoExplanationGroupBox.PerformLayout();
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
        private System.Windows.Forms.Label HandSwipeLabel;
        private System.Windows.Forms.TextBox ScreenTapTextBox;
        private System.Windows.Forms.TextBox CircleTextBox;
        private System.Windows.Forms.Label CircleLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox LemonGeckoExplanationGroupBox;
        private System.Windows.Forms.TextBox PunchTextBox;
        private System.Windows.Forms.Label PunchLabel;
        private System.Windows.Forms.TextBox AboutLemonGeckoTextBox;
        private System.Windows.Forms.Label HelpHeader;
        private System.Windows.Forms.TextBox HandSwipeTextBox;
        private System.Windows.Forms.Label ScreenTapLabel;
    }
}
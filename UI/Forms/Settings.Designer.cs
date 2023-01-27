
namespace Launcher.Forms
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.SettingsLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BackToMenuButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SessionExplanation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.PunchTextBox2 = new System.Windows.Forms.TextBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.PunchTextBox = new System.Windows.Forms.TextBox();
            this.CircleCounterClockwiseTextBox2 = new System.Windows.Forms.TextBox();
            this.CircleCounterClockwiseTextBox = new System.Windows.Forms.TextBox();
            this.CircleClockwiseTextBox2 = new System.Windows.Forms.TextBox();
            this.CircleClockwiseTextBox = new System.Windows.Forms.TextBox();
            this.SwipeDownTextBox2 = new System.Windows.Forms.TextBox();
            this.SwipeDownTextBox = new System.Windows.Forms.TextBox();
            this.SwipeUpTextBox2 = new System.Windows.Forms.TextBox();
            this.SwipeUpTextBox = new System.Windows.Forms.TextBox();
            this.SwipeLeftTextBox2 = new System.Windows.Forms.TextBox();
            this.SwipeLeft2Label = new System.Windows.Forms.Label();
            this.SwipeLeftTextBox = new System.Windows.Forms.TextBox();
            this.SwipeRight2Label = new System.Windows.Forms.Label();
            this.SwipeRightTextBox2 = new System.Windows.Forms.TextBox();
            this.SwipeRightTextBox = new System.Windows.Forms.TextBox();
            this.ScreenTap2Label = new System.Windows.Forms.Label();
            this.ScreenTapTextBox2 = new System.Windows.Forms.TextBox();
            this.ScreenTapTextBox = new System.Windows.Forms.TextBox();
            this.PunchLabel = new System.Windows.Forms.Label();
            this.CircleCounterClockwiseLabel = new System.Windows.Forms.Label();
            this.CircleClockwiseLabel = new System.Windows.Forms.Label();
            this.SwipeDownLabel = new System.Windows.Forms.Label();
            this.SwipeUpLabel = new System.Windows.Forms.Label();
            this.SwipeLeftLabel = new System.Windows.Forms.Label();
            this.SwipeRightLabel = new System.Windows.Forms.Label();
            this.ScreenTapLabel = new System.Windows.Forms.Label();
            this.ScreenReaderComboBox = new System.Windows.Forms.ComboBox();
            this.SelectedScreenReader = new System.Windows.Forms.Label();
            this.SettingsLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsLayoutPanel
            // 
            this.SettingsLayoutPanel.Controls.Add(this.panel1);
            this.SettingsLayoutPanel.Controls.Add(this.panel3);
            this.SettingsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.SettingsLayoutPanel.Name = "SettingsLayoutPanel";
            this.SettingsLayoutPanel.Size = new System.Drawing.Size(527, 516);
            this.SettingsLayoutPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BackToMenuButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 48);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(222, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
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
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(3, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(524, 447);
            this.panel3.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SessionExplanation);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Controls.Add(this.PunchTextBox2);
            this.groupBox1.Controls.Add(this.CancelBtn);
            this.groupBox1.Controls.Add(this.PunchTextBox);
            this.groupBox1.Controls.Add(this.CircleCounterClockwiseTextBox2);
            this.groupBox1.Controls.Add(this.CircleCounterClockwiseTextBox);
            this.groupBox1.Controls.Add(this.CircleClockwiseTextBox2);
            this.groupBox1.Controls.Add(this.CircleClockwiseTextBox);
            this.groupBox1.Controls.Add(this.SwipeDownTextBox2);
            this.groupBox1.Controls.Add(this.SwipeDownTextBox);
            this.groupBox1.Controls.Add(this.SwipeUpTextBox2);
            this.groupBox1.Controls.Add(this.SwipeUpTextBox);
            this.groupBox1.Controls.Add(this.SwipeLeftTextBox2);
            this.groupBox1.Controls.Add(this.SwipeLeft2Label);
            this.groupBox1.Controls.Add(this.SwipeLeftTextBox);
            this.groupBox1.Controls.Add(this.SwipeRight2Label);
            this.groupBox1.Controls.Add(this.SwipeRightTextBox2);
            this.groupBox1.Controls.Add(this.SwipeRightTextBox);
            this.groupBox1.Controls.Add(this.ScreenTap2Label);
            this.groupBox1.Controls.Add(this.ScreenTapTextBox2);
            this.groupBox1.Controls.Add(this.ScreenTapTextBox);
            this.groupBox1.Controls.Add(this.PunchLabel);
            this.groupBox1.Controls.Add(this.CircleCounterClockwiseLabel);
            this.groupBox1.Controls.Add(this.CircleClockwiseLabel);
            this.groupBox1.Controls.Add(this.SwipeDownLabel);
            this.groupBox1.Controls.Add(this.SwipeUpLabel);
            this.groupBox1.Controls.Add(this.SwipeLeftLabel);
            this.groupBox1.Controls.Add(this.SwipeRightLabel);
            this.groupBox1.Controls.Add(this.ScreenTapLabel);
            this.groupBox1.Controls.Add(this.ScreenReaderComboBox);
            this.groupBox1.Controls.Add(this.SelectedScreenReader);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(13, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 429);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Key Mapping For Gestures";
            // 
            // SessionExplanation
            // 
            this.SessionExplanation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SessionExplanation.Cursor = System.Windows.Forms.Cursors.Default;
            this.SessionExplanation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SessionExplanation.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SessionExplanation.Location = new System.Drawing.Point(19, 38);
            this.SessionExplanation.Multiline = true;
            this.SessionExplanation.Name = "SessionExplanation";
            this.SessionExplanation.ReadOnly = true;
            this.SessionExplanation.Size = new System.Drawing.Size(457, 66);
            this.SessionExplanation.TabIndex = 5;
            this.SessionExplanation.Text = resources.GetString("SessionExplanation.Text");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(267, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "+";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(267, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "+";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(267, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "+";
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(391, 272);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(85, 31);
            this.SaveButton.TabIndex = 41;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PunchTextBox2
            // 
            this.PunchTextBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.PunchTextBox2.Location = new System.Drawing.Point(287, 383);
            this.PunchTextBox2.Name = "PunchTextBox2";
            this.PunchTextBox2.ReadOnly = true;
            this.PunchTextBox2.Size = new System.Drawing.Size(73, 25);
            this.PunchTextBox2.TabIndex = 39;
            this.PunchTextBox2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.PunchTextBox2_PreviewKeyDown);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.Location = new System.Drawing.Point(391, 221);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(85, 31);
            this.CancelBtn.TabIndex = 40;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PunchTextBox
            // 
            this.PunchTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.PunchTextBox.Location = new System.Drawing.Point(183, 383);
            this.PunchTextBox.Name = "PunchTextBox";
            this.PunchTextBox.ReadOnly = true;
            this.PunchTextBox.Size = new System.Drawing.Size(73, 25);
            this.PunchTextBox.TabIndex = 37;
            this.PunchTextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.PunchTextBox_PreviewKeyDown);
            // 
            // CircleCounterClockwiseTextBox2
            // 
            this.CircleCounterClockwiseTextBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.CircleCounterClockwiseTextBox2.Location = new System.Drawing.Point(287, 352);
            this.CircleCounterClockwiseTextBox2.Name = "CircleCounterClockwiseTextBox2";
            this.CircleCounterClockwiseTextBox2.ReadOnly = true;
            this.CircleCounterClockwiseTextBox2.Size = new System.Drawing.Size(73, 25);
            this.CircleCounterClockwiseTextBox2.TabIndex = 35;
            this.CircleCounterClockwiseTextBox2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.CircleCounterClockwiseTextBox2_PreviewKeyDown);
            // 
            // CircleCounterClockwiseTextBox
            // 
            this.CircleCounterClockwiseTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.CircleCounterClockwiseTextBox.Location = new System.Drawing.Point(183, 352);
            this.CircleCounterClockwiseTextBox.Name = "CircleCounterClockwiseTextBox";
            this.CircleCounterClockwiseTextBox.ReadOnly = true;
            this.CircleCounterClockwiseTextBox.Size = new System.Drawing.Size(73, 25);
            this.CircleCounterClockwiseTextBox.TabIndex = 33;
            this.CircleCounterClockwiseTextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.CircleCounterClockwiseTextBox_PreviewKeyDown);
            // 
            // CircleClockwiseTextBox2
            // 
            this.CircleClockwiseTextBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.CircleClockwiseTextBox2.Location = new System.Drawing.Point(287, 321);
            this.CircleClockwiseTextBox2.Name = "CircleClockwiseTextBox2";
            this.CircleClockwiseTextBox2.ReadOnly = true;
            this.CircleClockwiseTextBox2.Size = new System.Drawing.Size(73, 25);
            this.CircleClockwiseTextBox2.TabIndex = 31;
            this.CircleClockwiseTextBox2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.CircleClockwiseTextBox2_PreviewKeyDown);
            // 
            // CircleClockwiseTextBox
            // 
            this.CircleClockwiseTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.CircleClockwiseTextBox.Location = new System.Drawing.Point(183, 321);
            this.CircleClockwiseTextBox.Name = "CircleClockwiseTextBox";
            this.CircleClockwiseTextBox.ReadOnly = true;
            this.CircleClockwiseTextBox.Size = new System.Drawing.Size(73, 25);
            this.CircleClockwiseTextBox.TabIndex = 29;
            this.CircleClockwiseTextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.CircleClockwiseTextBox_PreviewKeyDown);
            // 
            // SwipeDownTextBox2
            // 
            this.SwipeDownTextBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.SwipeDownTextBox2.Location = new System.Drawing.Point(287, 290);
            this.SwipeDownTextBox2.Name = "SwipeDownTextBox2";
            this.SwipeDownTextBox2.ReadOnly = true;
            this.SwipeDownTextBox2.Size = new System.Drawing.Size(73, 25);
            this.SwipeDownTextBox2.TabIndex = 27;
            this.SwipeDownTextBox2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.SwipeDownTextBox2_PreviewKeyDown);
            // 
            // SwipeDownTextBox
            // 
            this.SwipeDownTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.SwipeDownTextBox.Location = new System.Drawing.Point(183, 290);
            this.SwipeDownTextBox.Name = "SwipeDownTextBox";
            this.SwipeDownTextBox.ReadOnly = true;
            this.SwipeDownTextBox.Size = new System.Drawing.Size(73, 25);
            this.SwipeDownTextBox.TabIndex = 25;
            this.SwipeDownTextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.SwipeDownTextBox_PreviewKeyDown);
            // 
            // SwipeUpTextBox2
            // 
            this.SwipeUpTextBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.SwipeUpTextBox2.Location = new System.Drawing.Point(287, 262);
            this.SwipeUpTextBox2.Name = "SwipeUpTextBox2";
            this.SwipeUpTextBox2.ReadOnly = true;
            this.SwipeUpTextBox2.Size = new System.Drawing.Size(73, 25);
            this.SwipeUpTextBox2.TabIndex = 23;
            this.SwipeUpTextBox2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.SwipeUpTextBox2_PreviewKeyDown);
            // 
            // SwipeUpTextBox
            // 
            this.SwipeUpTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.SwipeUpTextBox.Location = new System.Drawing.Point(183, 259);
            this.SwipeUpTextBox.Name = "SwipeUpTextBox";
            this.SwipeUpTextBox.ReadOnly = true;
            this.SwipeUpTextBox.Size = new System.Drawing.Size(73, 25);
            this.SwipeUpTextBox.TabIndex = 21;
            this.SwipeUpTextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.SwipeUpTextBox_PreviewKeyDown);
            // 
            // SwipeLeftTextBox2
            // 
            this.SwipeLeftTextBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.SwipeLeftTextBox2.Location = new System.Drawing.Point(287, 228);
            this.SwipeLeftTextBox2.Name = "SwipeLeftTextBox2";
            this.SwipeLeftTextBox2.ReadOnly = true;
            this.SwipeLeftTextBox2.Size = new System.Drawing.Size(73, 25);
            this.SwipeLeftTextBox2.TabIndex = 19;
            this.SwipeLeftTextBox2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.SwipeLeftTextBox2_PreviewKeyDown);
            // 
            // SwipeLeft2Label
            // 
            this.SwipeLeft2Label.AutoSize = true;
            this.SwipeLeft2Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwipeLeft2Label.Location = new System.Drawing.Point(267, 231);
            this.SwipeLeft2Label.Name = "SwipeLeft2Label";
            this.SwipeLeft2Label.Size = new System.Drawing.Size(17, 17);
            this.SwipeLeft2Label.TabIndex = 18;
            this.SwipeLeft2Label.Text = "+";
            // 
            // SwipeLeftTextBox
            // 
            this.SwipeLeftTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.SwipeLeftTextBox.Location = new System.Drawing.Point(183, 228);
            this.SwipeLeftTextBox.Name = "SwipeLeftTextBox";
            this.SwipeLeftTextBox.ReadOnly = true;
            this.SwipeLeftTextBox.Size = new System.Drawing.Size(73, 25);
            this.SwipeLeftTextBox.TabIndex = 17;
            this.SwipeLeftTextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.SwipeLeftTextBox_PreviewKeyDown);
            // 
            // SwipeRight2Label
            // 
            this.SwipeRight2Label.AutoSize = true;
            this.SwipeRight2Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwipeRight2Label.Location = new System.Drawing.Point(267, 200);
            this.SwipeRight2Label.Name = "SwipeRight2Label";
            this.SwipeRight2Label.Size = new System.Drawing.Size(17, 17);
            this.SwipeRight2Label.TabIndex = 14;
            this.SwipeRight2Label.Text = "+";
            // 
            // SwipeRightTextBox2
            // 
            this.SwipeRightTextBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.SwipeRightTextBox2.Location = new System.Drawing.Point(287, 197);
            this.SwipeRightTextBox2.Name = "SwipeRightTextBox2";
            this.SwipeRightTextBox2.ReadOnly = true;
            this.SwipeRightTextBox2.Size = new System.Drawing.Size(73, 25);
            this.SwipeRightTextBox2.TabIndex = 15;
            this.SwipeRightTextBox2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.SwipeRightTextBox2_PreviewKeyDown);
            // 
            // SwipeRightTextBox
            // 
            this.SwipeRightTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.SwipeRightTextBox.Location = new System.Drawing.Point(183, 197);
            this.SwipeRightTextBox.Name = "SwipeRightTextBox";
            this.SwipeRightTextBox.ReadOnly = true;
            this.SwipeRightTextBox.Size = new System.Drawing.Size(73, 25);
            this.SwipeRightTextBox.TabIndex = 13;
            this.SwipeRightTextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.SwipeRightTextBox_PreviewKeyDown);
            // 
            // ScreenTap2Label
            // 
            this.ScreenTap2Label.AutoSize = true;
            this.ScreenTap2Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenTap2Label.Location = new System.Drawing.Point(267, 171);
            this.ScreenTap2Label.Name = "ScreenTap2Label";
            this.ScreenTap2Label.Size = new System.Drawing.Size(17, 17);
            this.ScreenTap2Label.TabIndex = 10;
            this.ScreenTap2Label.Text = "+";
            // 
            // ScreenTapTextBox2
            // 
            this.ScreenTapTextBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ScreenTapTextBox2.Location = new System.Drawing.Point(287, 166);
            this.ScreenTapTextBox2.Name = "ScreenTapTextBox2";
            this.ScreenTapTextBox2.ReadOnly = true;
            this.ScreenTapTextBox2.Size = new System.Drawing.Size(73, 25);
            this.ScreenTapTextBox2.TabIndex = 11;
            this.ScreenTapTextBox2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ScreenTapTextBox2_PreviewKeyDown);
            // 
            // ScreenTapTextBox
            // 
            this.ScreenTapTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenTapTextBox.Location = new System.Drawing.Point(183, 166);
            this.ScreenTapTextBox.Name = "ScreenTapTextBox";
            this.ScreenTapTextBox.ReadOnly = true;
            this.ScreenTapTextBox.Size = new System.Drawing.Size(73, 25);
            this.ScreenTapTextBox.TabIndex = 9;
            this.ScreenTapTextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ScreenTapTextBox_PreviewKeyDown);
            // 
            // PunchLabel
            // 
            this.PunchLabel.AutoSize = true;
            this.PunchLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PunchLabel.Location = new System.Drawing.Point(21, 386);
            this.PunchLabel.Name = "PunchLabel";
            this.PunchLabel.Size = new System.Drawing.Size(50, 17);
            this.PunchLabel.TabIndex = 36;
            this.PunchLabel.Text = "Punch:";
            // 
            // CircleCounterClockwiseLabel
            // 
            this.CircleCounterClockwiseLabel.AutoSize = true;
            this.CircleCounterClockwiseLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CircleCounterClockwiseLabel.Location = new System.Drawing.Point(21, 355);
            this.CircleCounterClockwiseLabel.Name = "CircleCounterClockwiseLabel";
            this.CircleCounterClockwiseLabel.Size = new System.Drawing.Size(157, 17);
            this.CircleCounterClockwiseLabel.TabIndex = 32;
            this.CircleCounterClockwiseLabel.Text = "Circle Counterclockwise:";
            // 
            // CircleClockwiseLabel
            // 
            this.CircleClockwiseLabel.AutoSize = true;
            this.CircleClockwiseLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CircleClockwiseLabel.Location = new System.Drawing.Point(21, 324);
            this.CircleClockwiseLabel.Name = "CircleClockwiseLabel";
            this.CircleClockwiseLabel.Size = new System.Drawing.Size(110, 17);
            this.CircleClockwiseLabel.TabIndex = 28;
            this.CircleClockwiseLabel.Text = "Circle Clockwise:";
            // 
            // SwipeDownLabel
            // 
            this.SwipeDownLabel.AutoSize = true;
            this.SwipeDownLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwipeDownLabel.Location = new System.Drawing.Point(21, 293);
            this.SwipeDownLabel.Name = "SwipeDownLabel";
            this.SwipeDownLabel.Size = new System.Drawing.Size(88, 17);
            this.SwipeDownLabel.TabIndex = 24;
            this.SwipeDownLabel.Text = "Swipe Down:";
            // 
            // SwipeUpLabel
            // 
            this.SwipeUpLabel.AutoSize = true;
            this.SwipeUpLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwipeUpLabel.Location = new System.Drawing.Point(21, 262);
            this.SwipeUpLabel.Name = "SwipeUpLabel";
            this.SwipeUpLabel.Size = new System.Drawing.Size(69, 17);
            this.SwipeUpLabel.TabIndex = 20;
            this.SwipeUpLabel.Text = "Swipe Up:";
            // 
            // SwipeLeftLabel
            // 
            this.SwipeLeftLabel.AutoSize = true;
            this.SwipeLeftLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwipeLeftLabel.Location = new System.Drawing.Point(21, 231);
            this.SwipeLeftLabel.Name = "SwipeLeftLabel";
            this.SwipeLeftLabel.Size = new System.Drawing.Size(76, 17);
            this.SwipeLeftLabel.TabIndex = 16;
            this.SwipeLeftLabel.Text = "Swipe Left:";
            // 
            // SwipeRightLabel
            // 
            this.SwipeRightLabel.AutoSize = true;
            this.SwipeRightLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwipeRightLabel.Location = new System.Drawing.Point(21, 200);
            this.SwipeRightLabel.Name = "SwipeRightLabel";
            this.SwipeRightLabel.Size = new System.Drawing.Size(85, 17);
            this.SwipeRightLabel.TabIndex = 12;
            this.SwipeRightLabel.Text = "Swipe Right:";
            // 
            // ScreenTapLabel
            // 
            this.ScreenTapLabel.AutoSize = true;
            this.ScreenTapLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenTapLabel.Location = new System.Drawing.Point(21, 169);
            this.ScreenTapLabel.Name = "ScreenTapLabel";
            this.ScreenTapLabel.Size = new System.Drawing.Size(78, 17);
            this.ScreenTapLabel.TabIndex = 8;
            this.ScreenTapLabel.Text = "Screen Tap:";
            // 
            // ScreenReaderComboBox
            // 
            this.ScreenReaderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScreenReaderComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenReaderComboBox.FormattingEnabled = true;
            this.ScreenReaderComboBox.Location = new System.Drawing.Point(237, 117);
            this.ScreenReaderComboBox.Name = "ScreenReaderComboBox";
            this.ScreenReaderComboBox.Size = new System.Drawing.Size(121, 29);
            this.ScreenReaderComboBox.TabIndex = 7;
            this.ScreenReaderComboBox.SelectedIndexChanged += new System.EventHandler(this.ScreenReaderComboBox_SelectedIndexChanged);
            // 
            // SelectedScreenReader
            // 
            this.SelectedScreenReader.AutoSize = true;
            this.SelectedScreenReader.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedScreenReader.Location = new System.Drawing.Point(21, 120);
            this.SelectedScreenReader.Name = "SelectedScreenReader";
            this.SelectedScreenReader.Size = new System.Drawing.Size(189, 21);
            this.SelectedScreenReader.TabIndex = 6;
            this.SelectedScreenReader.Text = "Selected Screen Reader:";
            // 
            // Settings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(527, 516);
            this.Controls.Add(this.SettingsLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.SettingsLayoutPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel SettingsLayoutPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BackToMenuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ScreenReaderComboBox;
        private System.Windows.Forms.Label SelectedScreenReader;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label PunchLabel;
        private System.Windows.Forms.Label CircleCounterClockwiseLabel;
        private System.Windows.Forms.Label CircleClockwiseLabel;
        private System.Windows.Forms.Label SwipeDownLabel;
        private System.Windows.Forms.Label SwipeUpLabel;
        private System.Windows.Forms.Label SwipeLeftLabel;
        private System.Windows.Forms.Label SwipeRightLabel;
        private System.Windows.Forms.Label ScreenTapLabel;
        private System.Windows.Forms.TextBox ScreenTapTextBox;
        private System.Windows.Forms.Label ScreenTap2Label;
        private System.Windows.Forms.TextBox ScreenTapTextBox2;
        private System.Windows.Forms.Label SwipeRight2Label;
        private System.Windows.Forms.TextBox SwipeRightTextBox2;
        private System.Windows.Forms.TextBox SwipeRightTextBox;
        private System.Windows.Forms.TextBox SwipeLeftTextBox2;
        private System.Windows.Forms.Label SwipeLeft2Label;
        private System.Windows.Forms.TextBox SwipeLeftTextBox;
        private System.Windows.Forms.TextBox SwipeUpTextBox2;
        private System.Windows.Forms.TextBox SwipeUpTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PunchTextBox2;
        private System.Windows.Forms.TextBox PunchTextBox;
        private System.Windows.Forms.TextBox CircleCounterClockwiseTextBox2;
        private System.Windows.Forms.TextBox CircleCounterClockwiseTextBox;
        private System.Windows.Forms.TextBox CircleClockwiseTextBox2;
        private System.Windows.Forms.TextBox CircleClockwiseTextBox;
        private System.Windows.Forms.TextBox SwipeDownTextBox2;
        private System.Windows.Forms.TextBox SwipeDownTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SessionExplanation;
    }
}
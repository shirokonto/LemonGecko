
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
            this.SettingsLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackToNavButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ScreenReaderComboBox = new System.Windows.Forms.ComboBox();
            this.SelectedScreenReader = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.KeyMappingDataGridView = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LanguageComboBox = new System.Windows.Forms.ComboBox();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.SettingsLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyMappingDataGridView)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsLayoutPanel
            // 
            this.SettingsLayoutPanel.Controls.Add(this.panel1);
            this.SettingsLayoutPanel.Controls.Add(this.panel2);
            this.SettingsLayoutPanel.Controls.Add(this.panel3);
            this.SettingsLayoutPanel.Controls.Add(this.panel4);
            this.SettingsLayoutPanel.Controls.Add(this.panel5);
            this.SettingsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.SettingsLayoutPanel.Name = "SettingsLayoutPanel";
            this.SettingsLayoutPanel.Size = new System.Drawing.Size(527, 516);
            this.SettingsLayoutPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BackToNavButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 48);
            this.panel1.TabIndex = 1;
            // 
            // BackToNavButton
            // 
            this.BackToNavButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToNavButton.Location = new System.Drawing.Point(13, 9);
            this.BackToNavButton.Name = "BackToNavButton";
            this.BackToNavButton.Size = new System.Drawing.Size(205, 32);
            this.BackToNavButton.TabIndex = 0;
            this.BackToNavButton.Text = "Back To Navigation";
            this.BackToNavButton.UseVisualStyleBackColor = true;
            this.BackToNavButton.Click += new System.EventHandler(this.BackToNavButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(524, 52);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(3, 115);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(524, 109);
            this.panel3.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ScreenReaderComboBox);
            this.groupBox1.Controls.Add(this.SelectedScreenReader);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(13, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Key Mapping For Gestures";
            // 
            // ScreenReaderComboBox
            // 
            this.ScreenReaderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScreenReaderComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenReaderComboBox.FormattingEnabled = true;
            this.ScreenReaderComboBox.Location = new System.Drawing.Point(231, 31);
            this.ScreenReaderComboBox.Name = "ScreenReaderComboBox";
            this.ScreenReaderComboBox.Size = new System.Drawing.Size(121, 29);
            this.ScreenReaderComboBox.TabIndex = 7;
            this.ScreenReaderComboBox.SelectedIndexChanged += new System.EventHandler(this.ScreenReaderComboBox_SelectedIndexChanged);
            // 
            // SelectedScreenReader
            // 
            this.SelectedScreenReader.AutoSize = true;
            this.SelectedScreenReader.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedScreenReader.Location = new System.Drawing.Point(15, 34);
            this.SelectedScreenReader.Name = "SelectedScreenReader";
            this.SelectedScreenReader.Size = new System.Drawing.Size(189, 21);
            this.SelectedScreenReader.TabIndex = 6;
            this.SelectedScreenReader.Text = "Selected Screen Reader:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.SaveButton);
            this.panel4.Controls.Add(this.CancelBtn);
            this.panel4.Controls.Add(this.KeyMappingDataGridView);
            this.panel4.Location = new System.Drawing.Point(3, 230);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(524, 164);
            this.panel4.TabIndex = 4;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(142, 116);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(85, 31);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.Location = new System.Drawing.Point(32, 116);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(81, 31);
            this.CancelBtn.TabIndex = 9;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // KeyMappingDataGridView
            // 
            this.KeyMappingDataGridView.AllowUserToAddRows = false;
            this.KeyMappingDataGridView.AllowUserToDeleteRows = false;
            this.KeyMappingDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.KeyMappingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KeyMappingDataGridView.Location = new System.Drawing.Point(29, 20);
            this.KeyMappingDataGridView.Name = "KeyMappingDataGridView";
            this.KeyMappingDataGridView.RowTemplate.Height = 24;
            this.KeyMappingDataGridView.Size = new System.Drawing.Size(459, 78);
            this.KeyMappingDataGridView.TabIndex = 8;
            this.KeyMappingDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.KeyMappingDataGridView_EditingControlShowing);
            this.KeyMappingDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyMappingDataGridView_KeyDown);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.LanguageComboBox);
            this.panel5.Controls.Add(this.LanguageLabel);
            this.panel5.Location = new System.Drawing.Point(3, 400);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(524, 116);
            this.panel5.TabIndex = 5;
            // 
            // LanguageComboBox
            // 
            this.LanguageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanguageComboBox.FormattingEnabled = true;
            this.LanguageComboBox.Location = new System.Drawing.Point(137, 29);
            this.LanguageComboBox.Name = "LanguageComboBox";
            this.LanguageComboBox.Size = new System.Drawing.Size(121, 29);
            this.LanguageComboBox.TabIndex = 9;
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanguageLabel.Location = new System.Drawing.Point(28, 32);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(85, 21);
            this.LanguageLabel.TabIndex = 8;
            this.LanguageLabel.Text = "Language:";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 516);
            this.Controls.Add(this.SettingsLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.SettingsLayoutPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KeyMappingDataGridView)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel SettingsLayoutPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BackToNavButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView KeyMappingDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ScreenReaderComboBox;
        private System.Windows.Forms.Label SelectedScreenReader;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ComboBox LanguageComboBox;
        private System.Windows.Forms.Label LanguageLabel;
    }
}
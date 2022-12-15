
namespace Launcher.Forms
{
    partial class Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.Sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.IconPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HomePanel = new System.Windows.Forms.Panel();
            this.HomeButton = new System.Windows.Forms.Button();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.HelpPanel = new System.Windows.Forms.Panel();
            this.HelpBtn = new System.Windows.Forms.Button();
            this.AboutPanel = new System.Windows.Forms.Panel();
            this.AboutButton = new System.Windows.Forms.Button();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.Sidebar.SuspendLayout();
            this.IconPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.HomePanel.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.HelpPanel.SuspendLayout();
            this.AboutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.Sidebar.Controls.Add(this.IconPanel);
            this.Sidebar.Controls.Add(this.HomePanel);
            this.Sidebar.Controls.Add(this.SettingsPanel);
            this.Sidebar.Controls.Add(this.HelpPanel);
            this.Sidebar.Controls.Add(this.AboutPanel);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(0, 0);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(173, 516);
            this.Sidebar.TabIndex = 0;
            // 
            // IconPanel
            // 
            this.IconPanel.Controls.Add(this.pictureBox1);
            this.IconPanel.Location = new System.Drawing.Point(3, 3);
            this.IconPanel.Name = "IconPanel";
            this.IconPanel.Size = new System.Drawing.Size(167, 106);
            this.IconPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // HomePanel
            // 
            this.HomePanel.Controls.Add(this.HomeButton);
            this.HomePanel.Location = new System.Drawing.Point(3, 115);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(167, 45);
            this.HomePanel.TabIndex = 1;
            // 
            // HomeButton
            // 
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Location = new System.Drawing.Point(0, 0);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.HomeButton.Size = new System.Drawing.Size(167, 45);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Text = "Home";
            this.HomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Controls.Add(this.SettingsButton);
            this.SettingsPanel.Location = new System.Drawing.Point(3, 166);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(167, 45);
            this.SettingsPanel.TabIndex = 2;
            // 
            // SettingsButton
            // 
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.ForeColor = System.Drawing.Color.White;
            this.SettingsButton.Location = new System.Drawing.Point(0, 0);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.SettingsButton.Size = new System.Drawing.Size(167, 45);
            this.SettingsButton.TabIndex = 0;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // HelpPanel
            // 
            this.HelpPanel.Controls.Add(this.HelpBtn);
            this.HelpPanel.Location = new System.Drawing.Point(3, 217);
            this.HelpPanel.Name = "HelpPanel";
            this.HelpPanel.Size = new System.Drawing.Size(167, 45);
            this.HelpPanel.TabIndex = 3;
            // 
            // HelpBtn
            // 
            this.HelpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpBtn.ForeColor = System.Drawing.Color.White;
            this.HelpBtn.Location = new System.Drawing.Point(0, 0);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.HelpBtn.Size = new System.Drawing.Size(167, 45);
            this.HelpBtn.TabIndex = 0;
            this.HelpBtn.Text = "Help";
            this.HelpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HelpBtn.UseVisualStyleBackColor = true;
            this.HelpBtn.Click += new System.EventHandler(this.HelpBtn_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(173, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(527, 516);
            this.ContentPanel.TabIndex = 5;
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 516);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.Sidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Launcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lemon Gecko";
            this.Sidebar.ResumeLayout(false);
            this.IconPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.HomePanel.ResumeLayout(false);
            this.SettingsPanel.ResumeLayout(false);
            this.HelpPanel.ResumeLayout(false);
            this.AboutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Sidebar;
        private System.Windows.Forms.Panel IconPanel;
        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Panel HelpPanel;
        private System.Windows.Forms.Button HelpBtn;
        private System.Windows.Forms.Panel AboutPanel;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
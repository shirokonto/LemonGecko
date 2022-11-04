
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
            this.HelpLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BackToNavButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HelpLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HelpLayoutPanel
            // 
            this.HelpLayoutPanel.Controls.Add(this.panel1);
            this.HelpLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HelpLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.HelpLayoutPanel.Name = "HelpLayoutPanel";
            this.HelpLayoutPanel.Size = new System.Drawing.Size(527, 516);
            this.HelpLayoutPanel.TabIndex = 0;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.BackToNavButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 48);
            this.panel1.TabIndex = 2;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 516);
            this.Controls.Add(this.HelpLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Help";
            this.Text = "Help";
            this.HelpLayoutPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel HelpLayoutPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BackToNavButton;
    }
}
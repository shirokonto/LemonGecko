
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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.startGestureControlButton = new System.Windows.Forms.Button();
            this.stopGestureControlButton = new System.Windows.Forms.Button();
            this.gestureDetectionLabel = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.gestureDetectionConsole = new System.Windows.Forms.TextBox();
            this.gestureControlLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
            // 
            // startGestureControlButton
            // 
            this.startGestureControlButton.Location = new System.Drawing.Point(25, 109);
            this.startGestureControlButton.Name = "startGestureControlButton";
            this.startGestureControlButton.Size = new System.Drawing.Size(167, 23);
            this.startGestureControlButton.TabIndex = 0;
            this.startGestureControlButton.Text = "Start";
            this.startGestureControlButton.UseVisualStyleBackColor = true;
            this.startGestureControlButton.Click += new System.EventHandler(this.StartGestureControlButton_Click);
            // 
            // stopGestureControlButton
            // 
            this.stopGestureControlButton.Enabled = false;
            this.stopGestureControlButton.Location = new System.Drawing.Point(25, 189);
            this.stopGestureControlButton.Name = "stopGestureControlButton";
            this.stopGestureControlButton.Size = new System.Drawing.Size(167, 23);
            this.stopGestureControlButton.TabIndex = 1;
            this.stopGestureControlButton.Text = "Stop";
            this.stopGestureControlButton.UseVisualStyleBackColor = true;
            this.stopGestureControlButton.Click += new System.EventHandler(this.StopGestureControlButton_Click);
            // 
            // gestureDetectionLabel
            // 
            this.gestureDetectionLabel.AutoSize = true;
            this.gestureDetectionLabel.Location = new System.Drawing.Point(263, 26);
            this.gestureDetectionLabel.Name = "gestureDetectionLabel";
            this.gestureDetectionLabel.Size = new System.Drawing.Size(120, 16);
            this.gestureDetectionLabel.TabIndex = 2;
            this.gestureDetectionLabel.Text = "Detected Gestures";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // gestureDetectionConsole
            // 
            this.gestureDetectionConsole.Location = new System.Drawing.Point(266, 45);
            this.gestureDetectionConsole.Multiline = true;
            this.gestureDetectionConsole.Name = "gestureDetectionConsole";
            this.gestureDetectionConsole.Size = new System.Drawing.Size(253, 383);
            this.gestureDetectionConsole.TabIndex = 3;
            // 
            // gestureControlLabel
            // 
            this.gestureControlLabel.AutoSize = true;
            this.gestureControlLabel.Location = new System.Drawing.Point(25, 45);
            this.gestureControlLabel.Name = "gestureControlLabel";
            this.gestureControlLabel.Size = new System.Drawing.Size(100, 16);
            this.gestureControlLabel.TabIndex = 4;
            this.gestureControlLabel.Text = "Gesture Control";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 450);
            this.Controls.Add(this.gestureControlLabel);
            this.Controls.Add(this.gestureDetectionConsole);
            this.Controls.Add(this.gestureDetectionLabel);
            this.Controls.Add(this.stopGestureControlButton);
            this.Controls.Add(this.startGestureControlButton);
            this.Name = "MenuForm";
            this.Text = "Screen Reader Gesture Controller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Button startGestureControlButton;
        private System.Windows.Forms.Button stopGestureControlButton;
        private System.Windows.Forms.Label gestureDetectionLabel;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox gestureDetectionConsole;
        private System.Windows.Forms.Label gestureControlLabel;
    }
}


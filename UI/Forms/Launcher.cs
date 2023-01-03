using System;
using System.Windows.Forms;

//Design: https://www.youtube.com/watch?v=ZoZWMcUv9Lw
//mdicontainer: https://stackoverflow.com/questions/34266329/how-to-make-c-sharp-tab-switch-between-form#34267313

namespace Launcher.Forms
{
    public partial class Launcher : Form
    {
        private Home home;
        private Settings settings;
        private HelpView helpView;
        private System.Drawing.Color white = System.Drawing.Color.White;
        private System.Drawing.Color blueGray = System.Drawing.Color.FromArgb(35, 40, 45);

        public Launcher()
        {            
            InitializeComponent();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            SetFocusAndCloseOtherForms(HomeButton);
            if ((home == null) || (home.IsDisposed))
                home = new Home() { Dock = DockStyle.Right };
            home.MdiParent=this;
            this.ContentPanel.Controls.Add(home);
            home.Show();
            home.Focus();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SetFocusAndCloseOtherForms(SettingsButton);
            if ((settings == null) || (settings.IsDisposed))
                settings = new Settings() { Dock = DockStyle.Fill };

            settings.MdiParent = this;
            this.ContentPanel.Controls.Add(settings);
            settings.Show();
            settings.Focus();
        }   

        private void SetFocusAndCloseOtherForms(Button btn)
        {
            ResetButtonColor(btn, blueGray, white);
            var activeControls = this.ContentPanel.Controls;
            if (activeControls.Count > 0)
            {
                for (int i = 0; i <= activeControls.Count; i++)
                {
                    if(activeControls[i] is Form)
                    {
                        ((Form)activeControls[i]).Close();
                        return;
                    }                    
                    this.ContentPanel.Controls.Remove(activeControls[i]);
                }
            }
        }

        private void HelpBtn_Click(object sender, EventArgs e)
        {            
            SetFocusAndCloseOtherForms(HelpBtn);
            if ((helpView == null) || (helpView.IsDisposed))
                helpView = new HelpView() { Dock = DockStyle.Fill };

            helpView.MdiParent = this;
            this.ContentPanel.Controls.Add(helpView);
            helpView.Show();
            helpView.Focus();
        }

        private void ContentPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            switch (e.Control.Name)
            {
                case "Home":
                    ResetButtonColor(HomeButton, white, blueGray);
                    break;
                case "Settings":
                    ResetButtonColor(SettingsButton, white, blueGray);
                    break;
                case "HelpView":
                    ResetButtonColor(HelpBtn, white, blueGray);
                    break;
            }
        }

        private void ResetButtonColor(Button btn, System.Drawing.Color foreColor, System.Drawing.Color backColor)
        {
            btn.ForeColor = foreColor;
            btn.BackColor = backColor;
        }
    }
}

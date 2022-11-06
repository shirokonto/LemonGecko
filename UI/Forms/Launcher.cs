﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private About about;

        public Launcher()
        {            
            InitializeComponent();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            CloseOtherChildrenForms();
            if ((home == null) || (home.IsDisposed))
                home = new Home() { Dock = DockStyle.Fill };

            home.MdiParent=this;
            this.ContentPanel.Controls.Add(home);
            home.Show();
            home.Focus();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            CloseOtherChildrenForms();
            if ((settings == null) || (settings.IsDisposed))
                settings = new Settings() { Dock = DockStyle.Fill };

            settings.MdiParent = this;
            this.ContentPanel.Controls.Add(settings);
            settings.Show();
            settings.Focus();
        }

        private void CloseOtherChildrenForms()
        {
            var activeControls = this.ContentPanel.Controls;
            if (activeControls.Count > 0)
            {
                for (int i = 0; i <= activeControls.Count; i++)
                {
                    this.ContentPanel.Controls.Remove(activeControls[i]);
                }
            }
        }

        private void HelpBtn_Click(object sender, EventArgs e)
        {            
            CloseOtherChildrenForms();
            if ((helpView == null) || (helpView.IsDisposed))
                helpView = new HelpView() { Dock = DockStyle.Fill };

            helpView.MdiParent = this;
            this.ContentPanel.Controls.Add(helpView);
            helpView.Show();
            helpView.Focus();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            CloseOtherChildrenForms();
            if ((about == null) || (about.IsDisposed))
                about = new About() { Dock = DockStyle.Fill };

            about.MdiParent = this;
            this.ContentPanel.Controls.Add(about);
            about.Show();
            about.Focus();
        }
    }
}
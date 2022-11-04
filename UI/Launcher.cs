using System;
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

namespace Launcher
{
    public partial class Launcher : Form
    {
        private Home home;
        private Settings settings;

        public Launcher()
        {            
            InitializeComponent();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            HideForms();
            //Home home = new Home() { Dock = DockStyle.Fill, TopLevel = false, TopMost=true };
            if ((home == null) || (home.IsDisposed))
                home = new Home() { Dock = DockStyle.Fill };

            home.MdiParent=this;
            this.ContentPanel.Controls.Add(home);
            home.Show();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            HideForms();
            if ((settings == null) || (settings.IsDisposed))
                settings = new Settings() { Dock = DockStyle.Fill };

            settings.MdiParent = this;
            this.ContentPanel.Controls.Add(settings);
            settings.Show();
        }

        private void HideForms()
        {
            this.MdiChildren.Count();
            int formsCounter = this.MdiChildren.Count<Form>();
            if(formsCounter > 0)
            {
                for (int i = 0; i < formsCounter; i++)
                {
                    this.MdiChildren[i].Hide();
                }
            }
        }
    }
}

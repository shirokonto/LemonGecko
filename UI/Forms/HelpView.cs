using System;
using System.Windows.Forms;

namespace Launcher.Forms
{
    public partial class HelpView : Form
    {
        public HelpView()
        {
            InitializeComponent();
        }

        private void BackToMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

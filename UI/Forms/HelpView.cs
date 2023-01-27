using System;
using System.Windows.Forms;

namespace Launcher.Forms
{
    /// <summary>
    /// The partial class <c>HelpView</c> represents the displayed Help view and the underlying logic in the User Interface. 
    /// </summary>
    public partial class HelpView : Form
    {
        /// <summary>
        /// Constructs a new <c>HelpView</c> Object and initializing the needed user interface components for the view.
        /// </summary>
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

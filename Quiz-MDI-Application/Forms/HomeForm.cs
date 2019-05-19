using System;
using System.Windows.Forms;

namespace Quiz_MDI_Application.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

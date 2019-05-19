using System;
using System.Windows.Forms;
using Quiz_MDI_Application.Data;

namespace Quiz_MDI_Application.Forms
{
    public partial class HomeForm : Form
    {
        public HomeForm()
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

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Database.Logout();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

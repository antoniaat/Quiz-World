using Quiz_MDI_Application.Data;
using System;
using System.Windows.Forms;

namespace Quiz_MDI_Application.Forms
{
    public partial class AdminHomeForm : Form
    {
        public AdminHomeForm()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Database.Logout();
        }
    }
}

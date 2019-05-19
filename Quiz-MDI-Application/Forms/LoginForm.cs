using System.Windows.Forms;
using Quiz_MDI_Application.Data;
using Quiz_MDI_Application.Models;

namespace Quiz_MDI_Application.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void LoginButton_Click(object sender, System.EventArgs e)
        {
            string username = this.usernameTextBox.Text;
            string password = this.passwordTextBox.Text;

            User user = Database.Login(username, password);

            if (user != null && user.Role == UserRole.User)
            {
                this.Visible = false;
                HomeForm homeForm = new HomeForm();
                homeForm.ShowDialog();
            }
            else
            {
                // TODO: Admin Form
            }
        }
    }
}

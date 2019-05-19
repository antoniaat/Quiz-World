using System.Windows.Forms;
using Quiz_MDI_Application.Data;
using Quiz_MDI_Application.Models;

namespace Quiz_MDI_Application.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void LoginLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void RegisterButton_Click(object sender, System.EventArgs e)
        {
            string username = this.usernameTextBox.Text;
            string password = this.passwordTextBox.Text;
            string repeatPassword = this.repeatPasswordTextBox.Text;

            if (password == repeatPassword)
            {
                Database.Users.CreateUser(new User
                {
                    Username = username,
                    Password = password,
                    Role = UserRole.Admin
                });

                this.Visible = false;
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
            }
        }
    }
}

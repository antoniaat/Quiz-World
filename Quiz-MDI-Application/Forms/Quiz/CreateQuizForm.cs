using Quiz_MDI_Application.Data;
using Quiz_MDI_Application.Models;
using System;

using System.Windows.Forms;

namespace Quiz_MDI_Application.Forms
{
    public partial class CreateQuizForm : Form
    {
        public CreateQuizForm()
        {
            InitializeComponent();
        }

        private void QuizNameTextBox(object sender, EventArgs e)
        {

        }

        private void CreateQuizButton_Click(object sender, EventArgs e)
        {
            string name = quizNameTextBox.Text;
            int hours = int.Parse(hoursTextBox.Text);
            int minutes = int.Parse(minutesTextBox.Text);
            int seconds = int.Parse(secondsTextBox.Text);

            if (name != null || name != String.Empty)
            {
                Database.Quizzes.CreateQuiz(new Quiz
                {
                    Name = name,
                    Hours = hours,
                    Minutes = minutes,
                    Seconds = seconds
                });

                this.Visible = false;
                AdminHomeForm homeForm = new AdminHomeForm();
                homeForm.ShowDialog();
            }
        }
    }
}

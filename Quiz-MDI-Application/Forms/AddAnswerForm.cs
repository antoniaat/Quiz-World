using Quiz_MDI_Application.Data;
using Quiz_MDI_Application.Models;
using System.Windows.Forms;

namespace Quiz_MDI_Application.Forms
{
    public partial class AddAnswerForm : Form
    {
        private Models.Question question;

        public AddAnswerForm(Question question)
        {
            this.question = question;
            InitializeComponent();
        }

        private void AddAnswerButton_Click(object sender, System.EventArgs e)
        {
            var text = answerTextBox.Text;
            var isCorrect = correctRadioButton.Checked;

            Database.Answers.CreateAnswer(new Answer
            {
                Text = text,
                IsCorrect = isCorrect,
                Question = this.question
            });

            QuizDetails quizDetails = new QuizDetails();
            quizDetails.Show();
            this.Visible = false;
            this.Close();
        }
    }
}

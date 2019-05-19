using Quiz_MDI_Application.Data;
using Quiz_MDI_Application.Forms.Common;
using Quiz_MDI_Application.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Quiz_MDI_Application.Forms
{
    public partial class AdminHomeForm : Form
    {
        public AdminHomeForm()
        {
            InitializeComponent();
        }

        private void AdminHomeForm_Load(object sender, EventArgs e)
        {
            ICollection<Quiz> quizzes = Database.Quizzes.ReadQuizzes(false);

            int currentLabelPositionX = 60;
            int currentLabelPositionY = 60;

            int currentButtonPositionX = 750;
            int currentButtonPositionY = 60;

            int labelSizeX = 650;
            int labelSizeY = 50;

            int buttonSizeX = 260;
            int buttonSizeY = 50;

            foreach (var quiz in quizzes)
            {
                Button quizDetailsButton = new Button();

                quizDetailsButton.Text = quiz.Name + " - " + quiz.Hours + "h. " + quiz.Minutes + "m. " + quiz.Seconds + "s. ";
                quizDetailsButton.Font = new Font("Calibri", 20.0f);
                quizDetailsButton.Size = new Size(labelSizeX, labelSizeY);
                quizDetailsButton.Location = new Point(currentLabelPositionX, currentLabelPositionY);
                quizDetailsButton.Click += new EventHandler(QuizDetailsButton_Click);

                Button addQuestion = new Button();

                addQuestion.Name = "AddQuestionsButton";
                addQuestion.Text = "Add Question";
                addQuestion.Font = new Font("Calibri", 20.0f);
                addQuestion.Size = new Size(buttonSizeX, buttonSizeY);
                addQuestion.Location = new Point(currentButtonPositionX, currentButtonPositionY);

                addQuestion.Click += (obj, args) => AddQuestionToQuiz(obj, args, quiz);

                this.Controls.Add(quizDetailsButton);
                this.Controls.Add(addQuestion);

                currentLabelPositionY += 60;
                currentButtonPositionY += 60;
            }
        }

        private void QuizDetailsButton_Click(object sender, EventArgs e)
        {
            QuizDetails questionDetailsForm = new QuizDetails();
            questionDetailsForm.ShowDialog();
            this.Visible = false;
        }

        private void AddQuestionToQuiz(object sender, EventArgs e, Quiz quiz)
        {
            string value = "New Question";

            if (InputBox.InputBoxContainer("New Question", "", ref value) == DialogResult.OK)
            {
                Database.Questions.CreateQuestion(new Question
                {
                    Text = value,
                    Quiz = quiz
                });
            }

            this.Visible = false;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Database.Logout();
        }

        private void CreateQuizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CreateQuizForm quizForm = new CreateQuizForm();
            quizForm.ShowDialog();
        }

        private void AllQuizesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            HomeForm allQuizesForm = new HomeForm();
            allQuizesForm.ShowDialog();
        }
    }
}

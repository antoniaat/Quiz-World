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
                Button quizInfo = new Button();

                quizInfo.Text = quiz.Name + " - " + quiz.Hours + "h. " + quiz.Minutes + "m. " + quiz.Seconds + "s. ";
                quizInfo.Font = new Font("Calibri", 20.0f);
                quizInfo.Size = new Size(labelSizeX, labelSizeY);
                quizInfo.Location = new Point(currentLabelPositionX, currentLabelPositionY);

                Button quizButton = new Button();

                quizButton.Name = "AddQuestionsButton";
                quizButton.Click += new EventHandler(AddQuestionsButton_Click);
                quizButton.Text = "Add Questions";
                quizButton.Font = new Font("Calibri", 20.0f);
                quizButton.Size = new Size(buttonSizeX, buttonSizeY);
                quizButton.Location = new Point(currentButtonPositionX, currentButtonPositionY);
                //quizButton.Click += ""

                this.Controls.Add(quizInfo);
                this.Controls.Add(quizButton);

                currentLabelPositionY += 60;
                currentButtonPositionY += 60;
            }
        }

        private void AddQuestionsButton_Click(object sender, System.EventArgs e)
        {
            string value = "New Question";
            if (InputBox.InputBoxContainer("New Question", "", ref value) == DialogResult.OK)
            {
                //myDocument.Name = value;
            }


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

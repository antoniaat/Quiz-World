using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Quiz_MDI_Application.Data;
using Quiz_MDI_Application.Models;

namespace Quiz_MDI_Application.Forms
{
    public partial class HomeForm : Form
    {
        private ICollection<Quiz> quizzes;

        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            this.quizzes = Database.Quizzes.ReadQuizzes();
            this.UpdateQuizzes(this.quizzes);
        }

        private void ClearQuizzes()
        {
            List<Control> controlsToBeRemoved = new List<Control>();

            foreach (Control control in this.Controls)
            {
                if (control.Tag != null && 
                    (control.Tag.ToString() == "quizLabel" 
                                            || control.Tag.ToString() == "quizButton"))
                {
                    controlsToBeRemoved.Add(control);
                }
            }

            foreach (Control control in controlsToBeRemoved)
            {
                this.Controls.Remove(control);
            }
        }

        private void UpdateQuizzes(ICollection<Quiz> quizzes)
        {
            this.ClearQuizzes();

            int currentLabelPositionX = 60;
            int currentLabelPositionY = 150;

            int currentButtonPositionX = 850;
            int currentButtonPositionY = 150;

            int labelSizeX = 750;
            int labelSizeY = 50;

            int buttonSizeX = 160;
            int buttonSizeY = 50;

            foreach (var quiz in quizzes)
            {
                Label quizLabel = new Label();

                quizLabel.Tag = "quizLabel";
                quizLabel.Text = quiz.Name + " - " + quiz.Hours + "h. " + quiz.Minutes + "m. " + quiz.Seconds + "s. ";
                quizLabel.Font = new Font("Calibri", 20.0f);
                quizLabel.Size = new Size(labelSizeX, labelSizeY);
                quizLabel.Location = new Point(currentLabelPositionX, currentLabelPositionY);

                Button quizButton = new Button();

                quizButton.Tag = "quizButton";
                quizButton.Text = "Take Quiz";
                quizButton.Font = new Font("Calibri", 20.0f);
                quizButton.Size = new Size(buttonSizeX, buttonSizeY);
                quizButton.Location = new Point(currentButtonPositionX, currentButtonPositionY);
                quizButton.Click += (obj, args) => StartQuiz(obj, args, quiz);

                this.Controls.Add(quizLabel);
                this.Controls.Add(quizButton);

                currentLabelPositionY += 60;
                currentButtonPositionY += 60;
            }
        }

        private void StartQuiz(object sender, EventArgs e, Quiz quiz)
        {
            QuestionForm questionForm = new QuestionForm(quiz.Questions);
            questionForm.Show();
            this.Visible = false;
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

        private void SearchTextBox1_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = this.searchTextBox1.Text;

            if (string.IsNullOrEmpty(searchQuery))
            {
                this.UpdateQuizzes(this.quizzes);
            }
            else
            {
                this.UpdateQuizzes(this.quizzes
                    .Where(quiz => quiz.Name.ToLower().Contains(searchQuery.ToLower()))
                    .ToList());
            }
        }
    }
}

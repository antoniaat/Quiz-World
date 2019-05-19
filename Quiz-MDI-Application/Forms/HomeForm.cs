using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Quiz_MDI_Application.Data;
using Quiz_MDI_Application.Models;

namespace Quiz_MDI_Application.Forms
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            ICollection<Quiz> quizzes = Database.Quizzes.ReadQuizzes(false);

            int currentLabelPositionX = 60;
            int currentLabelPositionY = 60;

            int currentButtonPositionX = 850;
            int currentButtonPositionY = 60;

            int labelSizeX = 750;
            int labelSizeY = 50;

            int buttonSizeX = 160;
            int buttonSizeY = 50;

            foreach (var quiz in quizzes)
            {
                Label quizLabel = new Label();

                quizLabel.Text = quiz.Name + " - " + quiz.Hours + "h. " + quiz.Minutes + "m. " + quiz.Seconds + "s. ";
                quizLabel.Font = new Font("Calibri", 20.0f);
                quizLabel.Size = new Size(labelSizeX, labelSizeY);
                quizLabel.Location = new Point(currentLabelPositionX, currentLabelPositionY);

                Button quizButton = new Button();

                quizButton.Text = "Take Quiz";
                quizButton.Font = new Font("Calibri", 20.0f);
                quizButton.Size = new Size(buttonSizeX, buttonSizeY);
                quizButton.Location = new Point(currentButtonPositionX, currentButtonPositionY);
                //quizButton.Click += ""

                this.Controls.Add(quizLabel);
                this.Controls.Add(quizButton);

                currentLabelPositionY += 60;
                currentButtonPositionY += 60;
            }
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

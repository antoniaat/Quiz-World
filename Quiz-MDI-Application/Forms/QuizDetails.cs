using Quiz_MDI_Application.Data;
using Quiz_MDI_Application.Forms.Common;
using Quiz_MDI_Application.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Quiz_MDI_Application.Forms
{
    public partial class QuizDetails : Form
    {
        public QuizDetails()
        {
            InitializeComponent();
        }

        private void QuestionDetails_Load(object sender, EventArgs e)
        {
            ICollection<Question> questions = Database.Questions.ReadQuestions(true);

            int currentLabelPositionX = 60;
            int currentLabelPositionY = 60;

            int currentButtonPositionX = 600;
            int currentButtonPositionY = 60;

            int labelSizeX = 500;
            int labelSizeY = 50;

            int buttonSizeX = 240;
            int buttonSizeY = 50;

            foreach (var question in questions)
            {
                Label questionDetailsButton = new Label();

                questionDetailsButton.Text = question.Text;
                questionDetailsButton.Font = new Font("Calibri", 20.0f);
                questionDetailsButton.ForeColor = Color.Black;
                questionDetailsButton.BackColor = Color.Transparent;
                questionDetailsButton.Size = new Size(labelSizeX, labelSizeY);
                questionDetailsButton.Location = new Point(currentLabelPositionX, currentLabelPositionY);
                questionDetailsButton.Click += new EventHandler(QuestionDetailsButton_Click);

                Button addAnswerButton = new Button();

                addAnswerButton.Name = "addAnswerButton";
                addAnswerButton.Text = "Add Answer";
                addAnswerButton.Font = new Font("Calibri", 20.0f);
                addAnswerButton.ForeColor = Color.Black;
                questionDetailsButton.BackColor = Color.Transparent;
                addAnswerButton.Size = new Size(buttonSizeX, buttonSizeY);
                addAnswerButton.Location = new Point(currentButtonPositionX, currentButtonPositionY);

                addAnswerButton.Click += (obj, args) => AddAnswerToQuestion(obj, args, question);

                this.Controls.Add(questionDetailsButton);
                this.Controls.Add(addAnswerButton);

                currentLabelPositionY += 60;
                currentButtonPositionY += 60;
            }
        }

        private void AddAnswerToQuestion(object sender, EventArgs e, Question question)
        {
            AddAnswerForm form = new AddAnswerForm();
            form.Show();
            this.Dispose();
        }

        private void QuestionDetailsButton_Click(object sender, EventArgs e)
        {

        }
    }
}

using Quiz_MDI_Application.Data;
using Quiz_MDI_Application.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Quiz_MDI_Application.Forms
{
    public partial class QuestionForm : Form
    {
        private List<Question> questions;

        private int currentQuestionIndex;

        public QuestionForm(List<Question> questions, int currentQuestionIndex = 0)
        {
            this.questions = questions;
            this.currentQuestionIndex = currentQuestionIndex;
            InitializeComponent();
        }

        private void QuestionForm_Load(object sender, System.EventArgs e)
        {
            Question question = this.questions[this.currentQuestionIndex];

            int currentLabelPositionX = 60;
            int currentLabelPositionY = 60;

            int currentButtonPositionX = 750;
            int currentButtonPositionY = 60;

            int labelSizeX = 650;
            int labelSizeY = 50;

            int buttonSizeX = 260;
            int buttonSizeY = 50;

            Label questionDetailsLabel = new Label();

            questionDetailsLabel.Text = question.Text;
            questionDetailsLabel.Font = new Font("Calibri", 20.0f);
            questionDetailsLabel.Size = new Size(labelSizeX, labelSizeY);
            questionDetailsLabel.Location = new Point(currentLabelPositionX, currentLabelPositionY);
            
            foreach (var answer in question.Answers)
            {
                // Add answer labels - Radio buttons
                var currentAnswerRadioButton = new RadioButton();
                currentAnswerRadioButton.AutoSize = true;

                currentAnswerRadioButton.BackColor = Color.Transparent;
                currentAnswerRadioButton.Font = new Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                currentAnswerRadioButton.Location = new Point(60, 209);
                currentAnswerRadioButton.Name = "currentAnswerRadioButton";
                currentAnswerRadioButton.Size = new Size(129, 33);
                currentAnswerRadioButton.TabIndex = 1;
                currentAnswerRadioButton.TabStop = true;
                currentAnswerRadioButton.UseVisualStyleBackColor = false;

                currentAnswerRadioButton.Text = answer.Text;
                this.Controls.Add(currentAnswerRadioButton);
            }

            Button nextQuestion = new Button();

            nextQuestion.Name = "NextQuestion";
            nextQuestion.Text = "Next Question";
            nextQuestion.Font = new Font("Calibri", 20.0f);
            nextQuestion.Size = new Size(buttonSizeX, buttonSizeY);
            nextQuestion.Location = new Point(currentButtonPositionX, currentButtonPositionY);

            nextQuestion.Click += new EventHandler(SwitchToNextQuestion);

            this.Controls.Add(questionDetailsLabel);
            this.Controls.Add(nextQuestion);

            currentLabelPositionY += 60;
            currentButtonPositionY += 60;
        }

        private void SwitchToNextQuestion(object sender, EventArgs e)
        {
            // TODO: Update Quiz Result

            QuestionForm questionForm = new QuestionForm(this.questions, this.currentQuestionIndex + 1);
            questionForm.Show();
            this.Visible = false;
        }
    }
}

using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Quiz_MDI_Application.Models;

namespace Quiz_MDI_Application.Data.Access
{
    public class AnswerDataAccess : DataAccess
    {
        private readonly QuestionDataAccess questionDataAccess;

        public AnswerDataAccess() : base()
        {
            this.questionDataAccess = new QuestionDataAccess(null);
        }

        public void CreateAnswer(Answer answer)
        {
            this.ExecuteInsertQuery("Answers", (command) =>
            {
                command.Parameters.Add(new SqlParameter("Id", this.NextId++));
                command.Parameters.Add(new SqlParameter("Text", answer.Text));
                command.Parameters.Add(new SqlParameter("IsCorrect", answer.IsCorrect ? 1 : 0));
                command.Parameters.Add(new SqlParameter("QuestionId", answer.Question.Id));
            }, "Id", "Text", "IsCorrect", "QuestionId");
        }

        public ICollection<Answer> ReadAnswers(bool resolve = true)
        {
            return this.ExecuteSelectQuery("Answers", (reader) =>
            {
                int id = reader.GetInt32(0);
                string text = reader.GetString(1);
                bool isCorrect = reader.GetBoolean(2);
                int questionId = reader.GetInt32(3);

                Answer answer = new Answer
                {
                    Id = id,
                    Text = text,
                    IsCorrect = isCorrect
                };

                if (resolve)
                {
                    answer.Question = this.ResolveQuestion(questionId);
                }

                return answer;
            });
        }

        private Question ResolveQuestion(int questionId)
        {
            return this.questionDataAccess.ReadQuestions(false)
                .First(question => question.Id == questionId);
        }

        protected override void CreateTable()
        {
            List<string> parameters = new List<string>();
            parameters.Add("Id INT");
            parameters.Add("Text VARCHAR(255)");
            parameters.Add("IsCorrect BIT");
            parameters.Add("QuestionId INT");
            parameters.Add("CONSTRAINT PK_ANSWERS PRIMARY KEY (Id)");
            parameters.Add("CONSTRAINT FK_ANSWERS_QUESTIONS FOREIGN KEY (QuestionId) REFERENCES Questions(Id)");

            this.ExecuteCreateTableQuery("Answers", parameters);
        }

        protected override int InitializeNextId()
        {
            ICollection<Answer> answers = this.ReadAnswers(false);

            return answers.Any() ? answers.Max(answer => answer.Id)  + 1: 1;
        }
    }
}

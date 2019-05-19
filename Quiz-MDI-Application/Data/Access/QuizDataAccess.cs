using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Quiz_MDI_Application.Models;

namespace Quiz_MDI_Application.Data.Access
{
    public class QuizDataAccess : DataAccess
    {
        private readonly QuestionDataAccess questionDataAccess;

        public QuizDataAccess(QuestionDataAccess questionDataAccess) : base()
        {
            this.questionDataAccess = questionDataAccess;
        }

        public void CreateQuiz(Quiz quiz)
        {
            this.ExecuteInsertQuery("Quizzes", (command) =>
            {
                command.Parameters.Add(new SqlParameter("Id", this.NextId++));
                command.Parameters.Add(new SqlParameter("Name", quiz.Name));
                command.Parameters.Add(new SqlParameter("Hours", quiz.Hours));
                command.Parameters.Add(new SqlParameter("Minutes", quiz.Minutes));
                command.Parameters.Add(new SqlParameter("Seconds", quiz.Seconds));
            }, "Id", "Name", "Hours", "Minutes", "Seconds");
        }

        public ICollection<Quiz> ReadQuizzes(bool resolve = true)
        {
            return this.ExecuteSelectQuery("Quizzes", (reader) =>
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                int hours = reader.GetInt32(2);
                int minutes = reader.GetInt32(3);
                int seconds = reader.GetInt32(4);

                Quiz quiz = new Quiz
                {
                    Id = id,
                    Name = name,
                    Hours = hours,
                    Minutes = minutes,
                    Seconds = seconds
                };

                if (resolve)
                {
                    quiz.Questions = this.ResolveQuestions(id);
                }

                return quiz;
            });
        }

        private List<Question> ResolveQuestions(int id)
        {
            return this.questionDataAccess.ReadQuestions()
                .Where(question => question.Quiz.Id == id).ToList();
        }

        protected override void CreateTable()
        {
            List<string> parameters = new List<string>();

            parameters.Add("Id INT");
            parameters.Add("Name VARCHAR(255)");
            parameters.Add("Hours INT");
            parameters.Add("Minutes INT");
            parameters.Add("Seconds INT");
            parameters.Add("CONSTRAINT PK_QUIZZES PRIMARY KEY (Id)");

            this.ExecuteCreateTableQuery("Quizzes", parameters);
        }

        protected override int InitializeNextId()
        {
            ICollection<Quiz> quizzes = this.ReadQuizzes(false);

            return quizzes.Any() ? quizzes.Max(quiz => quiz.Id) : 1;
        }
    }
}

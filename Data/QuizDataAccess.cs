using Quiz_MDI_Application.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Quiz_MDI_Application.Data
{
    public class QuizDataAccess : DataAccess
    {
        private QuestionDataAccess questionDataAccess;

        public QuizDataAccess()
        {
            this.questionDataAccess = new QuestionDataAccess();
        }

        private ICollection<Question> ResolveQuestions(int id)
        {
            return this.questionDataAccess.ReadQuestions()
                .Where(question => question.Quiz.Id == id)
                .ToList();
        }

        public void CreateQuiz(Quiz Quiz)
        {
            this.ExecuteInsertQuery("INSERT INTO Quiz VALUES(@params@)", (command) =>
            {
                command.Parameters.Add(new SqlParameter("Id", Quiz.Id));
                command.Parameters.Add(new SqlParameter("Name", Quiz.Name));
                command.Parameters.Add(new SqlParameter("Hours", Quiz.Hours));
                command.Parameters.Add(new SqlParameter("Minutes", Quiz.Minutes));
                command.Parameters.Add(new SqlParameter("Seconds", Quiz.Seconds));
                command.Parameters.Add(new SqlParameter("Questions", Quiz.Questions.ToString()));
            }, "Id", "Name", "Hours", "Minutes", "Seconds", "Questions");
        }

        public ICollection<Quiz> ReadQuizes()
        {
            return this.ExecuteSelectQuery("SELECT * FROM Quizes", (reader) =>
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                int hours = reader.GetInt32(2);
                int minutes = reader.GetInt32(3);
                int seconds = reader.GetInt32(4);


                return new Quiz
                {
                    Id = id,
                    Name = name,
                    Hours = hours,
                    Minutes = minutes,
                    Seconds = seconds,
                    Hours = hours
                    //questions = questions
                };
            });
        }
    }
}

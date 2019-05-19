using Quiz_MDI_Application.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Quiz_MDI_Application.Data
{
    public class QuizRezultDataAccess : DataAccess
    {
        public void CreateQuizResults(QuizResult quizResult)
        {
            this.ExecuteInsertQuery("INSERT INTO Users VALUES(@params@)", (command) =>
            {
                command.Parameters.Add(new SqlParameter("Id", quizResult.Id));
                command.Parameters.Add(new SqlParameter("Points", quizResult.Points));
                command.Parameters.Add(new SqlParameter("Quiz", quizResult.Quiz));
                command.Parameters.Add(new SqlParameter("User", quizResult.User.ToString()));
            }, "Id", "Points", "Quiz", "User");
        }

        public ICollection<QuizResult> ReadUsers()
        {
            return this.ExecuteSelectQuery("SELECT * FROM QuizResults", (reader) =>
            {
                int id = reader.GetInt32(0);
                int points = reader.GetInt32(1);
                //Quiz quiz = reader.GetString(2);
                //string role = reader.GetString(3);

                return new QuizResult
                {
                    Id = id,
                    Points = points,
                    //Quiz = quiz,
                    //User = (UserRole)System.Enum.Parse(typeof(UserRole), role)
                };
            });
        }
    }
}

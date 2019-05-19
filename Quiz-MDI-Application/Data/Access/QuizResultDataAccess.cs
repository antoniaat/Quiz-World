using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Quiz_MDI_Application.Models;

namespace Quiz_MDI_Application.Data.Access
{
    public class QuizResultDataAccess : DataAccess
    {
        private readonly QuizDataAccess quizDataAccess;

        private readonly UserDataAccess userDataAccess;

        public QuizResultDataAccess() : base()
        {
            this.quizDataAccess = new QuizDataAccess(null);
            this.userDataAccess = new UserDataAccess();
        }

        public void CreateQuizResult(QuizResult quizResult)
        {
            this.ExecuteInsertQuery("QuizResults", (command) =>
            {
                command.Parameters.Add(new SqlParameter("Id", this.NextId++));
                command.Parameters.Add(new SqlParameter("Points", quizResult.Points));
                command.Parameters.Add(new SqlParameter("QuizId", quizResult.Quiz.Id));
                command.Parameters.Add(new SqlParameter("UserId", quizResult.User.Id));
            }, "Id", "Points", "QuizId", "UserId");
        }

        public ICollection<QuizResult> ReadQuizResults(bool resolve = true)
        {
            return this.ExecuteSelectQuery("QuizResults", (reader) =>
            {
                int id = reader.GetInt32(0);
                int points = reader.GetInt32(1);
                int quizId = reader.GetInt32(2);
                int userId = reader.GetInt32(3);

                QuizResult quizResult = new QuizResult
                {
                    Id = id,
                    Points = points,
                };

                if (resolve)
                {
                    quizResult.Quiz = this.ResolveQuiz(quizId);
                    quizResult.User = this.ResolveUser(userId);
                }

                return quizResult;
            });
        }

        private Quiz ResolveQuiz(int quizId)
        {
            return this.quizDataAccess.ReadQuizzes(false)
                .First(quiz => quiz.Id == quizId);
        }

        private User ResolveUser(int userId)
        {
            return this.userDataAccess.ReadUsers()
                .First(user => user.Id == userId);
        }

        protected override void CreateTable()
        {
            List<string> parameters = new List<string>();

            parameters.Add("Id INT");
            parameters.Add("Points INT");
            parameters.Add("QuizId INT");
            parameters.Add("UserId INT");
            parameters.Add("CONSTRAINT PK_QUIZ_RESULTS PRIMARY KEY (Id)");
            parameters.Add("CONSTRAINT FK_QUIZ_RESULTS_QUIZZES FOREIGN KEY (QuizId) REFERENCES Quizzes(Id)");
            parameters.Add("CONSTRAINT FK_QUIZ_RESULTS_USERS FOREIGN KEY (UserId) REFERENCES Users(Id)");

            this.ExecuteCreateTableQuery("QuizResults", parameters);
        }

        protected override int InitializeNextId()
        {
            ICollection<QuizResult> quizResults = this.ReadQuizResults(false);

            return quizResults.Any() ? quizResults.Max(user => user.Id) : 1;
        }
    }
}

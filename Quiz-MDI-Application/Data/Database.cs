using System.Linq;
using Quiz_MDI_Application.Data.Access;
using Quiz_MDI_Application.Models;

namespace Quiz_MDI_Application.Data
{
    public class Database
    {
        public const string ConnectionString =
            "Server=DESKTOP-8LNSVN2\\MSSQLSERVER01;Database=QuizMDI;Integrated Security=False;Trusted_Connection=True;";

        public static User currentlyLoggedInUser;

        public static void Initialize()
        {
            new UserDataAccess();
            new QuizDataAccess(null);
            new QuestionDataAccess(null);
            new AnswerDataAccess();
            new QuizResultDataAccess();

            Users = new UserDataAccess();
            Answers = new AnswerDataAccess();
            Questions = new QuestionDataAccess(Answers);
            Quizzes = new QuizDataAccess(Questions);
            QuizResults = new QuizResultDataAccess();
        }

        public static UserDataAccess Users { get; private set; }

        public static QuizDataAccess Quizzes { get; private set; }

        public static QuestionDataAccess Questions { get; private set; }

        public static AnswerDataAccess Answers { get; private set; }

        public static QuizResultDataAccess QuizResults { get; private set; }

        public static User Login(string username, string password)
        {
            currentlyLoggedInUser = Users.ReadUsers().FirstOrDefault(user => user.Username == username && user.Password == password);
            return currentlyLoggedInUser;
        }

        public static void Logout()
        {
            if (currentlyLoggedInUser != null)
            {
                currentlyLoggedInUser = null;
            }
        }
    }
}

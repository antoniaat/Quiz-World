using Quiz_MDI_Application.Data.Access;

namespace Quiz_MDI_Application.Data
{
    public class Database
    {
        public const string ConnectionString =
            "Server=.\\SQLEXPRESS;Database=QuizMDI;Integrated Security=False;Trusted_Connection=True;";

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
    }
}

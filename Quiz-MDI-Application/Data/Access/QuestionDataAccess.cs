using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Quiz_MDI_Application.Models;

namespace Quiz_MDI_Application.Data.Access
{
    public class QuestionDataAccess : DataAccess
    {
        private readonly AnswerDataAccess answerDataAccess;

        private readonly QuizDataAccess quizDataAccess;

        public QuestionDataAccess(AnswerDataAccess answerDataAccess) : base()
        {
            this.answerDataAccess = answerDataAccess;
            this.quizDataAccess = new QuizDataAccess(null);
        }

        public void CreateQuestion(Question question)
        {
            this.ExecuteInsertQuery("Questions", (command) =>
            {
                command.Parameters.Add(new SqlParameter("Id", this.NextId++));
                command.Parameters.Add(new SqlParameter("Text", question.Text));
                command.Parameters.Add(new SqlParameter("QuizId", question.Quiz.Id));
            }, "Id", "Text", "QuizId");
        }

        public ICollection<Question> ReadQuestions(bool resolve = true)
        {
            return this.ExecuteSelectQuery("Questions", (reader) =>
            {
                int id = reader.GetInt32(0);
                string text = reader.GetString(1);
                int quizId = reader.GetInt32(2);

                Question question = new Question()
                {
                    Id = id,
                    Text = text
                };

                if (resolve)
                {
                    question.Answers = this.ResolveAnswers(id);
                    question.Quiz = this.ResolveQuiz(quizId);
                }

                return question;
            });
        }

        private List<Answer> ResolveAnswers(int id)
        {
            return this.answerDataAccess.ReadAnswers()
                .Where(answer => answer.Question.Id == id).ToList();
        }

        private Quiz ResolveQuiz(int quizId)
        {
            return this.quizDataAccess.ReadQuizzes(false)
                .First(quiz => quiz.Id == quizId);
        }

        protected override void CreateTable()
        {
            List<string> parameters = new List<string>();

            parameters.Add("Id INT");
            parameters.Add("Text VARCHAR(255)");
            parameters.Add("QuizId INT");
            parameters.Add("CONSTRAINT PK_QUESTIONS PRIMARY KEY (Id)");
            parameters.Add("CONSTRAINT FK_QUESTIONS_QUIZZES FOREIGN KEY (QuizId) REFERENCES Quizzes(Id)");

            this.ExecuteCreateTableQuery("Questions", parameters);
        }

        protected override int InitializeNextId()
        {
            ICollection<Question> questions = this.ReadQuestions(false);

            return questions.Any() ? questions.Max(question => question.Id) : 1;
        }
    }
}

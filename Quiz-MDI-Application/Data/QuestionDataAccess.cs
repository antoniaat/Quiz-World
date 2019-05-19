using Quiz_MDI_Application.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Quiz_MDI_Application.Data
{
    public class QuestionDataAccess : DataAccess
    {
        public void CreateQuestion(Question question)
        {
            this.ExecuteInsertQuery("INSERT INTO Questions VALUES(@params@)", (command) =>
            {
                command.Parameters.Add(new SqlParameter("Id", question.Id));
                command.Parameters.Add(new SqlParameter("Text", question.Text));
                command.Parameters.Add(new SqlParameter("Answers", question.Answers));
                command.Parameters.Add(new SqlParameter("Quiz", question.Quiz.ToString()));
            }, "Id", "Text", "Answers", "Quiz");
        }

        public ICollection<Question> ReadQuestions()
        {
            return this.ExecuteSelectQuery("SELECT * FROM Questions", (reader) =>
            {
                var id = reader.GetInt32(0);
                var text = reader.GetString(1);
                var answers = reader.GetString(2); // TODO: 
                var quiz = reader.GetString(3); //TODO:

                return new Question
                {
                    Id = id,
                    Text = text,
                    //Answers = answers,  // TODO: 
                    //Quiz = (Quiz)quiz; // TODO: 
            };
        });
        }
}
}

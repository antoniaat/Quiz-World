using System.Collections.Generic;

namespace Quiz_MDI_Application.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public List<Answer> Answers { get; set; }
        public Quiz Quiz { get; set; }

        public Question()
        {
            this.Answers = new List<Answer>();
        }
    }
}

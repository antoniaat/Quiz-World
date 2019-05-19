using System.Collections.Generic;

namespace Quiz_MDI_Application.Models
{
    public class Quiz
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public List<Question> Questions { get; set; }

        public Quiz()
        {
            this.Questions = new List<Question>();
        }
    }
}

using System;

namespace Quiz_MDI_Application.Models
{
    public class Answer
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public bool IsCorrect { get; set; }

        public Question Question { get; set; }
    }
}

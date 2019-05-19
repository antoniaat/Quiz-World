using System;

namespace Quiz_MDI_Application.Models
{
    public class Answer
    {
        public String Text { get; set; }
        public int Id { get; set; }
        public Question Question { get; set; }
    }
}

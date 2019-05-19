namespace Quiz_MDI_Application.Models
{
    public class QuizResult
    {
        public int Id { get; set; }
        public int Points { get; set; }
        public Quiz Quiz { get; set; }
        public User User { get; set; }
    }
}

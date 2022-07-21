namespace QuizApp.Data
{
    public class UserQuiz:BaseEntity
    {
        public int QuizID { get; set; }
        public string UserID { get; set; }

        public int Score { get; set; }
        public DateTime? DateAttempted { get; set; } = null;

        public Quiz Quiz { get; set; }
    }
}

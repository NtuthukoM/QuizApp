namespace QuizApp.Data
{
    public class QuizQuestion:BaseEntity
    {
        public int QuizID { get; set; }
        public int QuestionID { get; set; }
        public Question Question { get; set; }
        public Quiz Quiz { get; set; }
    }
}

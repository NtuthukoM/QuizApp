namespace QuizApp.Data
{
    public class UserQuizQuestionAnswer:BaseEntity
    {
        public int QuizQuestionID { get; set; }
        public int AnswerOptionID { get; set; }
        public bool Correct { get; set; }
        public string UserID { get; set; }
        public AnswerOption AnswerOption { get; set; }
        public QuizQuestion QuizQuestion { get; set; }
    }
}

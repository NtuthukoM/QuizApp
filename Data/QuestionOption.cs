namespace QuizApp.Data
{
    /// <summary>
    /// Question option - 'CorrectOption' needs to be set
    /// to increase user's score
    /// </summary>
    public class QuestionOption:BaseEntity
    {
        public int QuestionID { get; set; }
        public int AnswerOptionID { get; set; }
        public bool CorrectOption { get; set; }
        public AnswerOption AnswerOption { get; set; }
        public Question Question { get; set; }
    }
}

namespace QuizApp.Data
{
    public class Quiz:BaseEntity
    {
        public string QuizTitle { get; set; }
        public bool Published { get; set; }
    }
}

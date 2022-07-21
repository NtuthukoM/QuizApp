namespace QuizApp.Data
{
    public class BaseEntity
    {
        public int ID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public bool Deleted { get; set; }
        public string UpdatedByUserId { get; set; }
    }
}

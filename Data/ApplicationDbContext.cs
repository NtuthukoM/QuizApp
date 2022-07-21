using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace QuizApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<UserQuiz> UserQuizzes { get; set; }
        public DbSet<QuizQuestion> QuizQuestions { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<QuestionOption> QuestionOptions { get; set; }
        public DbSet<AnswerOption> AnswerOptions { get; set; }
        public DbSet<UserQuizQuestionAnswer> UserQuizQuestionAnswers { get; set; }
    }
}
using Microsoft.EntityFrameworkCore;
using onlinequizsystem.entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace onlinequizsystem.Data
{
    public class QuizContext:DbContext
    {

        public DbSet<Student> students { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Quiz> quizzes { get; set; }
        public DbSet <Question> questions { get; set; }
        public DbSet<StudentQuiz> studentQuizzes { get; set; }
        public DbSet <QuizSetting> quizSettings { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
    "Server=DESKTOP-EIFLNP4;Database=onlinequizsystem;Integrated Security=True;TrustServerCertificate=True;"
);


        }
     protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

           base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<StudentQuiz>()
                .HasKey(ss => new { ss.StudentId, ss.QuizId });

            modelBuilder.Entity<StudentQuiz>()
                .Property(ss => ss.Score)
                .HasPrecision(5, 2);
                
           modelBuilder.Entity<Question>()
              .HasOne(c => c.Category)
              .WithMany(p => p.Questions)
                .HasForeignKey(q => q.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);
       }
    }
}

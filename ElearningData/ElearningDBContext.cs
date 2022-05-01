using ElearningModels.Models;
using ElearningModels.Models.Questions;

using Microsoft.EntityFrameworkCore;

namespace ElearningData
{
    public class ElearningDBContext : DbContext
    {
        private string _connectionString = $"server=localhost; port=3306; database=eLearningdb; user=root; password=1234; Charset=utf8mb4;";

        public DbSet<CourseModel> Courses { get; set; }

        public DbSet<ExamModel> Exams { get; set; }

        public DbSet<SubjectModel> Subjects { get; set; }

        public DbSet<FreeFormQModel> FreeFormQs { get; set; }

        public DbSet<MatchQModel> MatchQs { get; set; }

        public DbSet<MultipleChoiceQModel> MultipleChoiceQs { get; set; }

        public DbSet<TrueFalseQModel> TrueFalseQs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(_connectionString);
        }

        public void SetConnectionString(string server, string port, string database, string username, string password)
        {
            _connectionString = $"server={server}; port={port}; database={database}; user={username}; password={password}; Charset=utf8mb4;";
            //_connectionString = $"server=localhost; port=3306; database=eLearningdb; user=babis200; password={password}; Charset=utf8mb4;";
        }

        //TODO - add OnConfiguring for cascase delete

        protected override void OnModelCreating(ModelBuilder builder)
        {
           builder.Entity<CourseModel>()
                 .HasMany(p => p.Subjects)
                 .WithOne()
                 .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<CourseModel>()
                 .HasMany(p => p.Exams)
                 .WithOne()
                 .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<MatchQModel>()
                .Property(e => e.Choices)
                .HasConversion(
                    v => string.Join(',', v),
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList());

            builder.Entity<MatchQModel>()
                .Property(e => e.Answers)
                .HasConversion(
                    v => string.Join(',', v),
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList());

            builder.Entity<MultipleChoiceQModel>()
                .Property(e => e.Choices)
                .HasConversion(
                    v => string.Join(',', v),
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList());

            builder.Entity<CourseModel>()
                .Property(e => e.Teachers)
                .HasConversion(
                    v => string.Join(',', v),
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList());

            builder.Entity<ExamModel>()
                .Property(e => e.Grades)
                .HasConversion(
                    v => string.Join(',', v.ToString()),
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());

            builder.Entity<SubjectModel>()
               .Property(e => e.Resources)
               .HasConversion(
                   v => string.Join(',', v),
                   v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList());

        }
    }
}

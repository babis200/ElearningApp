
using ElearningModels.Models;
using ElearningModels.Models.Questions;
using ElearningModels.Models.Users;

using Microsoft.EntityFrameworkCore;

namespace ElearningData
{
    public class ElearningDBContext : DbContext
    {
        private string _connectionString;

        public DbSet<CourseModel> Courses { get; set; }

        public DbSet<ExamModel> Exams { get; set; }

        public DbSet<SubjectModel> Subjects { get; set; }

        public DbSet<FreeFormQModel> FreeFormQs { get; set; }

        public DbSet<MatchQModel> MatchQs { get; set; }

        public DbSet<MultipleChoiceQModel> MultipleChoiceQs { get; set; }

        public DbSet<TrueFalseQModel> TrueFalseQs { get; set; }

        public DbSet<AdminModel> Admins { get; set; }

        public DbSet<TeacherModel> Teachers { get; set; }

        public DbSet<StudentModel> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(_connectionString);
        }

        public void SetConnectionString(string server, string port, string database, string username, string password)
        {
            _connectionString = $"server={server}; port={port}; database={database}; user={username}; password={password}; Charset=utf8mb4;";
            //_connectionString = $"server=localhost; port=3306; database=eLearningdb; user=babis200; password={password}; Charset=utf8mb4;";
        }
    }
}

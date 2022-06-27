using ElearningModels;
using ElearningModels.Questions;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ElearningData
{
    public class ElearningDBContext : DbContext
    {
        private string _MySQLconnectionString = $"server=localhost; port=3306; database=eLearningdb; user=root; password=1234; Charset=utf8mb4;";

        private string _SQLiteConnectionString = @"Data Source=.\eLearning.db;";

        public DbSet<CourseModel> Courses { get; set; }

        public DbSet<ExamModel> Exams { get; set; }

        public DbSet<SubjectModel> Subjects { get; set; }

        public DbSet<FreeFormQModel> FreeFormQs { get; set; }

        public DbSet<MatchQModel> MatchQs { get; set; }

        public DbSet<MultipleChoiceQModel> MultipleChoiceQs { get; set; }

        public DbSet<TrueFalseQModel> TrueFalseQs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseMySQL(_MySQLconnectionString);

            optionsBuilder.UseSqlite(_SQLiteConnectionString);
        }

       /* public void SetConnectionString(string server, string port, string database, string username, string password)
        {
            //TODO - intergrate SQLite

            //_MySQLconnectionString = $"server={server}; port={port}; database={database}; user={username}; password={password}; Charset=utf8mb4;";
            _SQLiteConnectionString = $"server={server}; port={port}; database={database}; user={username}; password={password}; Charset=utf8mb4;";
            //_connectionString = $"server=localhost; port=3306; database=eLearningdb; user=babis200; password={password}; Charset=utf8mb4;";
        }*/

        //TODO - add OnConfiguring for cascase delete

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //TODO - make sure this doesnt break anything
            var stringValueComparer = new ValueComparer<List<string>>(
                (c1, c2) => c1.SequenceEqual(c2),
                c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                c => c.ToList());
            var intValueComparer = new ValueComparer<List<int>>(
                (c1, c2) => c1.SequenceEqual(c2),
                c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                c => c.ToList());

            builder.Entity<CourseModel>()
                 .HasMany(p => p.Subjects)
                 .WithOne()
                 .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<MatchQModel>()
                .Property(e => e.Choices)
                .HasConversion(
                    v => string.Join(',', v),
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList())
                .Metadata
                .SetValueComparer(stringValueComparer);

            builder.Entity<MatchQModel>()
                .Property(e => e.Answers)
                .HasConversion(
                    v => string.Join(',', v),
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList())
                .Metadata
                .SetValueComparer(stringValueComparer);

            builder.Entity<MultipleChoiceQModel>()
                .Property(e => e.Choices)
                .HasConversion(
                    v => string.Join(',', v),
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList())
                .Metadata
                .SetValueComparer(stringValueComparer);

            builder.Entity<CourseModel>()
                .Property(e => e.Teachers)
                .HasConversion(
                    v => string.Join(',', v),
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList())
                .Metadata
                .SetValueComparer(stringValueComparer);

            builder.Entity<ExamModel>()
                .Property(e => e.Grades)
                .HasConversion(
                    v => string.Join(',', v.ToString()),
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList())
                    .Metadata
                    .SetValueComparer(intValueComparer);

            builder.Entity<SubjectModel>()
               .Property(e => e.Resources)
               .HasConversion(
                   v => string.Join(',', v),
                   v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList())
                .Metadata
                .SetValueComparer(stringValueComparer);

        }
    }
}

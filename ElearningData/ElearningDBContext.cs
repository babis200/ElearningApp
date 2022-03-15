using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ElearningModels.Models;
using ElearningModels.Models.Questions;

using Microsoft.EntityFrameworkCore;

namespace ElearningData
{
    internal class ElearningDBContext
    {
        private string _connectionString;

        public DbSet<CourseModel> Courses { get; set; }

        public DbSet<ExamModel> Exams { get; set; }
        
        public DbSet<SubjectModel> Subjects { get; set; }
        
        public DbSet<FreeFormQModel> FreeFormQs { get; set; }
        public DbSet<MatchQModel> MatchQs { get; set; }
        public DbSet<MultipleChoiceQModel> MultipleChoiceQs { get; set; }
        public DbSet<TrueFalseQModel> TrueFalseQs { get; set; }

    }
}

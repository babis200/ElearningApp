using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ElearningModels.Interfaces;

namespace ElearningModels.Models
{
    public class ExamModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        //public SubjectModel Subjects { get; set; }

        //Meant to store grades of students and show how difficult this exam is
        public List<int> Grades { get; set; }

        public List<IQuestion> Questions { get; set; }

    }
}

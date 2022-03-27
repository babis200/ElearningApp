
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using ElearningModels.Interfaces;

namespace ElearningModels.Models
{
    public class ExamModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        public string Name { get; set; }

        //public SubjectModel Subjects { get; set; }

        //Meant to store grades of students and show how difficult this exam is
        public List<int> Grades { get; set; }

        public List<IQuestion> Questions { get; set; }

    }
}

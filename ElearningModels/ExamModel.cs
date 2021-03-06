
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ElearningModels
{
    public class ExamModel
    {
        [Key]

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int MinGrade { get; set; }

        public int MaxGrade { get; set; }

        //public SubjectModel Subjects { get; set; }

        //Meant to store grades of students and show how difficult this exam is
        public List<int> Grades { get; set; }

        public List<Question> Questions { get; set; }

        public ExamModel()
        {
            Id = Guid.NewGuid();
        }

    }
}

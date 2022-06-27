using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElearningModels
{
    public class CourseModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Υποχρεωτικό πεδίο")]
        public string Name { get; set; }

        public List<string> Teachers { get; set; }

        [NotMapped]
        public string TeachersString 
        { 
            get 
            { 
                return String.Join(',', Teachers.ToArray()); 
            }
        }

        public string Description { get; set; }

        public List<SubjectModel> Subjects { get; set; }

        public ExamModel Exam { get; set; }

    }
}

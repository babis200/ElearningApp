using System.ComponentModel.DataAnnotations;

namespace ElearningModels.Models
{
    public class SubjectModel
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public List<string> Resources { get; set; }

        public List<ExamModel> Exams { get; set; }
    }
}

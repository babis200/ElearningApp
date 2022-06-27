using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElearningModels
{
    public class SubjectModel
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<string> Resources { get; set; }

        public ExamModel Exam { get; set; }
    }
}

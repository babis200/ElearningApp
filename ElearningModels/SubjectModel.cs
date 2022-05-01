using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElearningModels
{
    public class SubjectModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        public string Name { get; set; }

        public List<string> Resources { get; set; }

        public List<ExamModel> Exams { get; set; }
    }
}

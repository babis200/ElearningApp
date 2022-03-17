
using ElearningModels.Interfaces;

namespace ElearningModels.Models.Questions
{
    public class TrueFalseQModel : IQuestion
    {
        public int Id { get; set; }

        public string Question { get; set; }

        public bool Answer { get; set; }
    }
}

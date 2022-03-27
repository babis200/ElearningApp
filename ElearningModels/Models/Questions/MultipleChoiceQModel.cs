
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using ElearningModels.Interfaces;

namespace ElearningModels.Models.Questions
{
    public class MultipleChoiceQModel : IQuestion
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Question { get; set; }

        public List<string> Choices { get; set; }

        //There is ONLY one corect answer 
        public int Answer { get; set; }

    }
}

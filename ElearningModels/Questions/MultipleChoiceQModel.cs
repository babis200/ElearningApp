
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace ElearningModels.Questions
{
    public class MultipleChoiceQModel
    {
        [Key]
        public Guid Id { get; set; }

        public string Question { get; set; }

        public List<string> Choices { get; set; }

        //There is ONLY one corect answer 
        public int Answer { get; set; }

    }
}

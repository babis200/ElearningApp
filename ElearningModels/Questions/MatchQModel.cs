using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace ElearningModels.Questions
{
    public class MatchQModel
    {
        [Key]
        public Guid Id { get; set; }

        public string Question { get; set; }

        //First answer binds with first choice...

        public List<string> Choices { get; set; }

        public List<string> Answers { get; set; }
    }
}


using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using ElearningModels.Interfaces;

namespace ElearningModels.Models.Questions
{
    public class MatchQModel : IQuestion
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Question { get; set; }

        //First answer binds with first choice...

        public List<string> Choices { get; set; }

        public List<string> Answers { get; set; }
    }
}

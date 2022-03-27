
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using ElearningModels.Interfaces;

namespace ElearningModels.Models.Questions
{
    public class FreeFormQModel : IQuestion
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Question { get; set; }

        public string Answer { get; set; }

    }
}


using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using ElearningModels.Interfaces;

namespace ElearningModels.Models.Questions
{
    public class TrueFalseQModel : IQuestion
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage ="Υποχρεωτικό πεδίο")]
        public string Question { get; set; }

        [Required(ErrorMessage = "Υποχρεωτικό πεδίο")]

        public bool Answer { get; set; }
    }
}

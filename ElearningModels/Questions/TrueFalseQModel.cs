
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace ElearningModels.Questions
{
    public class TrueFalseQModel  
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage ="Υποχρεωτικό πεδίο")]
        public string Question { get; set; }

        [Required(ErrorMessage = "Υποχρεωτικό πεδίο")]
        public bool Answer { get; set; }
    }
}

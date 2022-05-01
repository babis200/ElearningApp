
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace ElearningModels.Questions
{
    public class TrueFalseQModel  
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Υποχρεωτικό πεδίο")]
        public string Question { get; set; }

        [Required(ErrorMessage = "Υποχρεωτικό πεδίο")]
        public bool Answer { get; set; }
    }
}

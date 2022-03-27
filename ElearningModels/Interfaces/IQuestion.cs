using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ElearningModels.Interfaces
{
    public interface IQuestion
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Υποχρεωτικό πεδίο")]
        public string Question { get; set; }
    }
}

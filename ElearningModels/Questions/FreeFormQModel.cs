
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace ElearningModels.Questions
{
    public class FreeFormQModel
    {

        [Key]
        public Guid Id { get; set; }

        public string Question { get; set; }

        public string Answer { get; set; }

    }
}

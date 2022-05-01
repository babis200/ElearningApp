
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace ElearningModels.Questions
{
    public class FreeFormQModel
    {

        [Key]
        public int Id { get; set; }

        public string Question { get; set; }

        public string Answer { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace ElearningModels.Interfaces
{
    public interface IUser
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Υποχρεωτικό πεδίο")]
        public string Username { get; set; }

        [RegularExpression(@".{3,}", ErrorMessage = "Ελάχιστο μέγεθος τρεις χαρακτήρες")]
        public string Password { get; set; }

        public string Icon { get; set; }

        public enum Role
        {
            Guest,
            Student,
            Teacher,
            Admin
        }
    }
}

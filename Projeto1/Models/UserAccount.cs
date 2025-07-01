using System.ComponentModel.DataAnnotations;

namespace Projeto1.Models
{
    public class UserAccount
    {
        [Key]
        public string UserName { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

        [Required]
        [RegularExpression("Utilizador|Administrador")]
        public string Role { get; set; } = "Utilizador";
    }
}
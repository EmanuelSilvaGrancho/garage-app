using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto1.Models
{
    public class Modelo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Nome { get; set; }

        [Required]
        public int MarcaId { get; set; }

        public byte[]? Imagem { get; set; }

        [Required]
        public int Potencia { get; set; }

        [Required]
        public int Binario { get; set; }

        [Required]
        public string? Motor { get; set; }

        [Required]
        public string? Tracao { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }

        public Marca? Marca { get; set; }
    }
}

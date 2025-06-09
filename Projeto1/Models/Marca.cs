using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Projeto1.Models
{
    public class Marca
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Nome { get; set; }

        [Required]
        public string? PaisOrigem { get; set; }
    
        public int? Fundacao { get; set; }  

        public string? Sede { get; set; }

        public byte[]? Imagem { get; set; }

        // Lista de modelos relacionados a esta marca
        public ICollection<Modelo>? Modelos { get; set; }
    }
}

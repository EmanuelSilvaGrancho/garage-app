namespace Projeto1.Models
{
    public class Modelo
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int MarcaId { get; set; }
        public byte[]? Imagem { get; set; }

        public Marca? Marca { get; set; }  // Para relacionamento opcional
    }
}
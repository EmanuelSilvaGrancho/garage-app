namespace Projeto1.Models
{
    public class Marca
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public byte[]? LogoUrl { get; set; }  // Pode ser null
    }
}
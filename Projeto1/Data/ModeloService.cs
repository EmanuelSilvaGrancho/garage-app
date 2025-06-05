using Microsoft.EntityFrameworkCore;
using Projeto1.Models;

namespace Projeto1.Data
{
    public class ModeloService
    {
        private readonly AppDbContext _context;

        public ModeloService(AppDbContext context)
        {
            _context = context;
        }

        // Retorna todos os modelos de uma marca específica
        public async Task<List<Modelo>> GetModelosByMarcaIdAsync(int marcaId)
        {
            return await _context.Modelos
                .Where(m => m.MarcaId == marcaId)
                .ToListAsync();
        }

        // Retorna os detalhes de um modelo por ID, incluindo a marca
        public async Task<Modelo?> GetModeloByIdAsync(int id)
        {
            return await _context.Modelos
                .Include(m => m.Marca)
                .FirstOrDefaultAsync(m => m.Id == id);
        }
    }
}

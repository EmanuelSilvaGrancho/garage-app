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

        public async Task<List<Modelo>> GetModelosByMarcaIdAsync(int marcaId)
        {
            return await _context.Modelos
                .Where(m => m.MarcaId == marcaId)
                .ToListAsync();
        }
        public async Task<List<Modelo>> GetTodosModelosAsync()
        {
            return await _context.Modelos
                .Include(m => m.Marca)
                .ToListAsync();
        }
    }
}

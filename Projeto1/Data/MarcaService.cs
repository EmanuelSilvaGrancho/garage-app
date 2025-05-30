using Microsoft.EntityFrameworkCore;
using Projeto1.Models;

namespace Projeto1.Data
{
    public class MarcaService
    {
        private readonly AppDbContext _context;

        public MarcaService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Marca>> GetMarcasAsync()
        {
            return await _context.Marcas.ToListAsync();
        }

        public async Task<Marca?> GetMarcaByIdAsync(int id)
        {
            return await _context.Marcas.FirstOrDefaultAsync(m => m.Id == id);
        }
    }
}

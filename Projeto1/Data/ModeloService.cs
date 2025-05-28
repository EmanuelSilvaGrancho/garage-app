using Microsoft.EntityFrameworkCore;
using Projeto1.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}

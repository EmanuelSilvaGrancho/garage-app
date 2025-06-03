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

        // Obter todas as marcas
        public async Task<List<Marca>> GetMarcasAsync()
        {
            return await _context.Marcas.ToListAsync();
        }

        // Obter uma marca por ID
        public async Task<Marca?> GetMarcaByIdAsync(int id)
        {
            return await _context.Marcas.FirstOrDefaultAsync(m => m.Id == id);
        }

        // Adicionar uma nova marca
        public async Task AdicionarMarcaAsync(Marca marca)
        {
            _context.Marcas.Add(marca);
            await _context.SaveChangesAsync();
        }

        // Apagar uma marca por ID
        public async Task ApagarMarcaAsync(int id)
        {
            var marca = await _context.Marcas.FindAsync(id);
            if (marca != null)
            {
                _context.Marcas.Remove(marca);
                await _context.SaveChangesAsync();
            }
        }
    }
}

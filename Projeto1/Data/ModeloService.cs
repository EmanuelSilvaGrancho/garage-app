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

        // Listar todos os modelos com marca incluída
        public async Task<List<Modelo>> GetModelosAsync()
        {
            return await _context.Modelos.Include(m => m.Marca).ToListAsync();
        }

        // Listar modelos de uma marca específica
        public async Task<List<Modelo>> GetModelosByMarcaIdAsync(int marcaId)
        {
            return await _context.Modelos
                .Where(m => m.MarcaId == marcaId)
                .Include(m => m.Marca)
                .ToListAsync();
        }

        // Obter modelo por ID
        public async Task<Modelo?> GetModeloByIdAsync(int id)
        {
            return await _context.Modelos
                .Include(m => m.Marca)
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        // Adicionar um novo modelo
        public async Task AdicionarModeloAsync(Modelo modelo)
        {
            _context.Modelos.Add(modelo);
            await _context.SaveChangesAsync();
        }

        // Atualizar um modelo existente
        public async Task AtualizarModeloAsync(Modelo modelo)
        {
            _context.Entry(modelo).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        // Apagar um modelo
        public async Task ApagarModeloAsync(int id)
        {
            var modelo = await _context.Modelos.FindAsync(id);
            if (modelo != null)
            {
                _context.Modelos.Remove(modelo);
                await _context.SaveChangesAsync();
            }
        }
    }
}

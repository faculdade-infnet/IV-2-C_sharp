using AT.Data;
using AT.Models;
using Microsoft.EntityFrameworkCore;

namespace AT.Services
{
    public class PacoteTuristicoService : IPacoteTuristicoService
    {
        private readonly AgenciaContext _context;

        public PacoteTuristicoService(AgenciaContext context)
        {
            _context = context;
        }

        // Retorna a lista de Cidades
        public async Task<List<PacoteTuristico>> GetAllAsync()
        {
            return await _context.PacotesTuristicos
                .Include(c => c.Titulo)
                .Include(c => c.Preco)
                .Include(c => c.CapacidadeMaxima)
                .Include(c => c.DataInicio)
                .ToListAsync();
        }

        // Carrega todas as propriedades em Pacote Turistico
        public async Task<PacoteTuristico?> GetByNameAsync(string name)
        {
            return await _context.PacotesTuristicos
                .Include(c => c.Titulo)
                .Include(c => c.Preco)
                .Include(c => c.CapacidadeMaxima)
                .Include(c => c.DataInicio)
                .FirstOrDefaultAsync(c => EF.Functions.Collate(c.Titulo, "NOCASE") == name);
        }
    }
}

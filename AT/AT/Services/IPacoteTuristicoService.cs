using AT.Models;

namespace AT.Services
{
    public interface IPacoteTuristicoService
    {
        Task<List<PacoteTuristico>> GetAllAsync();
        Task<PacoteTuristico?> GetByNameAsync(string nome);
    }
}

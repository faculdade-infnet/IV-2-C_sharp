using CityBreaks.Web.Models;

namespace CityBreaks.Web06.Services
{
    public interface ICityService
    {
        Task<List<City>> GetAllAsync();
    }
}

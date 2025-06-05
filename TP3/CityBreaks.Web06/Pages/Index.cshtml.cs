using CityBreaks.Web.Models;
using CityBreaks.Web06.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CityBreaks.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ICityService _cityService;

        public IndexModel(ILogger<IndexModel> logger, ICityService cityService)
        {            
            _cityService = cityService;
        }

        public List<City> Cities { get; set; } = new();

        public async Task OnGetAsync()
        {
            Cities = await _cityService.GetAllAsync();
        }
    }
}

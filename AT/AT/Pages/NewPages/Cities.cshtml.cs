using AT.Models;
using AT.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AT.Pages.NewPages
{
    public class CitiesModel : PageModel
    {
        private readonly IPacoteTuristicoService _cityService;

        public CitiesModel(IPacoteTuristicoService cityService)
        {
            _cityService = cityService;
        }

        public List<Cliente> Cities { get; set; } = new();

        public async Task OnGetAsync()
        {
            //Cities = await _cityService.GetAllAsync();
        }
    }
}

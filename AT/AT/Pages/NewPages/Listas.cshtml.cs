using AT.Models;
using AT.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AT.Pages.NewPages
{
    public class CitiesModel : PageModel
    {
        private readonly IService _pacoteTuristicoService;

        public CitiesModel(IService pacoteTuristicoService)
        {
            _pacoteTuristicoService = pacoteTuristicoService;
        }

        public List<PacoteTuristico> PacotesTuristicos { get; set; } = new();

        public async Task OnGetAsync()
        {
            PacotesTuristicos = await _pacoteTuristicoService.GetAllAsync();
        }
    }
}

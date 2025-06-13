using AT.Models;
using AT.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AT.Pages.NewPages
{
    public class DetailsModel : PageModel
    {
        private readonly IPacoteTuristicoService _pacoteTuristicoService;

        public DetailsModel(IPacoteTuristicoService cityService)
        {
            _pacoteTuristicoService = cityService;
        }

        public PacoteTuristico? PacoteTuristico { get; set; }

        public async Task<IActionResult> OnGetAsync(string nome)
        {
            PacoteTuristico = await _pacoteTuristicoService.GetByNameAsync(nome);

            if (PacoteTuristico == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}

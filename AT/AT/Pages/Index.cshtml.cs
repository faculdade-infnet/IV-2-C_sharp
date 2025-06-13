using AT.Data;
using AT.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AT.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IPacoteTuristicoService _cityService;
        private readonly AgenciaContext _context;

        public IndexModel(ILogger<IndexModel> logger, AgenciaContext context)
        {
            var pacotes = context.PacotesTuristicos.ToList();
            foreach (var p in pacotes)
            {
                Console.WriteLine($"{p.Titulo} - {p.DataInicio}");
            }
        }
    }
}

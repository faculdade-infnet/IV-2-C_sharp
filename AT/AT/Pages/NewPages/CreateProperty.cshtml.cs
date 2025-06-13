using AT.Data;
using AT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AT.Pages.NewPages
{
    public class CreatePropertyModel : PageModel
    {
        private readonly AgenciaContext _context;

        public CreatePropertyModel(AgenciaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cliente Cliente { get; set; } = new Cliente();
        public Destino Destino { get; set; } = new Destino();
        public SelectList CitiesSelectList { get; set; } = default!;

        public async Task OnGetAsync()
        {
            //var cities = await _context.Cities.OrderBy(c => c.Name).ToListAsync();
            //CitiesSelectList = new SelectList(cities, "Id", "Name");
        }

        public async Task<IActionResult> OnPostClienteAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            // Adiciona os itens ao contexto em memória
            await _context.Clientes.AddAsync(Cliente);
            // Salva as alterações no banco de dados
            await _context.SaveChangesAsync();

            return RedirectToPage("/CreateProperty");
        }

        public async Task<IActionResult> OnPostDestinoAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            await _context.Destinos.AddAsync(Destino);
            await _context.SaveChangesAsync();

            return RedirectToPage("/CreateProperty");
        }
    }
}

using CityBreaks.Web.Data;
using CityBreaks.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CityBreaks.Web08.Pages
{
    public class CreatePropertyModel : PageModel
    {
        private readonly CityBreaksContext _context;

        public CreatePropertyModel(CityBreaksContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Property Property { get; set; } = new Property();
        public SelectList CitiesSelectList { get; set; } = default!;

        public async Task OnGetAsync()
        {
            var cities = await _context.Cities.OrderBy(c => c.Name).ToListAsync();
            CitiesSelectList = new SelectList(cities, "Id", "Name");
        }

        public async Task<IActionResult> OnPostAsync()
        {
            //// Exibir valores para debug
            //Console.WriteLine($"Name: {Property.Name}");
            //Console.WriteLine($"PricePerNight: {Property.PricePerNight}");
            //Console.WriteLine($"CityId: {Property.CityId}");
            //Console.WriteLine($"City: {Property.City}");

            if (!ModelState.IsValid)
            {
                foreach (var item in ModelState)
                {
                    var key = item.Key; // nome do campo (ex: "Property.Name")
                    var errors = item.Value.Errors;
                    foreach (var error in errors)
                    {
                        Console.WriteLine($"Erro no campo {key}: {error.ErrorMessage}");
                    }
                }
                // Recarregar a lista caso o formulário seja inválido
                var cities = await _context.Cities.OrderBy(c => c.Name).ToListAsync();
                CitiesSelectList = new SelectList(cities, "Id", "Name");
                return Page();
            }

            // Adicioan os itens ao contexto em memória
            await _context.Properties.AddAsync(Property);
            // Salva as alterações no banco de dados
            await _context.SaveChangesAsync();

            return RedirectToPage("/CreateProperty");
        }
    }
}

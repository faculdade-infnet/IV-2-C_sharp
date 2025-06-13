using AT.Data;
using AT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AT.Pages.NewPages
{
    public class CreateClienteModel : PageModel
    {
        private readonly AgenciaContext _context;
        public int? Id { get; set; } // Retorno do cadeastro

        public CreateClienteModel(AgenciaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cliente Cliente { get; set; } = new Cliente();        

        public async Task<IActionResult> OnPostClienteAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            // Adiciona os itens ao contexto em memória
            await _context.Clientes.AddAsync(Cliente);
            // Salva as alterações no banco de dados
            await _context.SaveChangesAsync();

            Id = Cliente.Id;
            Cliente = new Cliente();            

            return Page();
        }
    }
}

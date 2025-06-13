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

            // Salva o endere�o do cliente
            if (Cliente.Endereco != null)
            {
                await _context.Enderecos.AddAsync(Cliente.Endereco);
                await _context.SaveChangesAsync();

                // Vincula o endere�o ao cliente
                Cliente.EnderecoId = Cliente.Endereco.Id;
            }

            // Adiciona os itens ao contexto em mem�ria         
            await _context.Clientes.AddAsync(Cliente);
            // Salva as altera��es no banco de dados
            await _context.SaveChangesAsync();

            Id = Cliente.Id;
            // Limpa o formul�rio para novo cadastro
            Cliente = new Cliente();            

            return Page();
        }
    }
}

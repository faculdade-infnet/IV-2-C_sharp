using Exercicio_08_RazorPage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicio_08_RazorPage.Pages.Exercicio_12
{
    public class EventosModel : PageModel
    {
        public static List<Evento> EventosCadastrados { get; set; } = new();

        [BindProperty]
        public Evento NovoEvento { get; set; } = new Evento();

        // Delegate Action<Evento>
        public static Action<Evento>? OnEventoCriado;

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            EventosCadastrados.Add(NovoEvento);
            OnEventoCriado?.Invoke(NovoEvento); // Dispara delegate (evento)

            TempData["Mensagem"] = "Evento cadastrado com sucesso!";
            return RedirectToPage();
        }

        public void OnGet()
        {
            // Simula o "registro do listener" no console
            if (OnEventoCriado == null)
            {
                OnEventoCriado += evento =>
                {
                    Console.WriteLine($"[Evento criado] => '{evento.Titulo}' em {evento.Local} no dia {evento.Data:dd/MM/yyyy}");
                };
            }
        }
    }
}

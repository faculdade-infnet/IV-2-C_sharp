using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace Exercicio_08_RazorPage.Pages.ProductCatalog
{
    public class AddProductModel : PageModel
    {
        [BindProperty]
        public string Nome { get; set; } = string.Empty;

        [BindProperty]
        public double? Preco { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
        }
    }
}

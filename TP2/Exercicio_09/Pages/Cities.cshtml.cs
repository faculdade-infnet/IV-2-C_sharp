using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicio_09.Pages
{
    public class CitiesModel : PageModel
    {
        public List<string> Cities { get; set; } = new List<string>
        {
            "Rio Grande do Sul", "Rio de Janeiro", "S�o Paulo", "Bras�lia"
        };

        public void OnGet()
        {
        }
    }
}

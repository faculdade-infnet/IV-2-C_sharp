using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicio_01.Pages.CityManager
{
    public class CreateCityModel : PageModel
    {
        [BindProperty]
        public string CityName { get; set; }

        public void OnPost()
        {
        }
    }
}

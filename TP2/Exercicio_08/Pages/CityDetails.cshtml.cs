using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicio_08.Pages
{
    public class CityDetailsModel : PageModel
    {
        public string CityName { get; set; } = string.Empty;
        // https://localhost:7154/CityDetails/Minas%20Gerais

        public void OnGet()
        {
            CityName = RouteData.Values["cityName"].ToString() ?? "Cidade não especificada";
        }
    }
}

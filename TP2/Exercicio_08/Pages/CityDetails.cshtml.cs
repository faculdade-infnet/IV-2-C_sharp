using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicio_08.Pages
{
    public class CityDetailsModel : PageModel
    {
        public string CityName { get; set; } = "Minas Gerais";
        // https://localhost:7154/CityDetails/Minas%20Gerais

        public void OnGet(string cityName)
        {
            CityName = RouteData.Values["cityName"].ToString();
        }
    }
}

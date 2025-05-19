using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicio_02.Pages.CityManager
{
    public class CreateCityModel : PageModel
    {
        public string InternalCityName { get; set; }

        public void OnPost(string cityName)
        {
            InternalCityName = cityName;
        }
    }
}

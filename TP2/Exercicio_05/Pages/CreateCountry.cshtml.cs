using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics.Metrics;

namespace Exercicio_05.Pages
{
    public class CreateCountryModel : PageModel
    {        
        [BindProperty]
        public InputModel Input { get; set; }

        public Country? Country { get; set; }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                Country = new Country
                {
                    CountryCode = Input.CountryCode,
                    CountryName = Input.CountryName
                };
            }
        }
    }

    public class InputModel
    {
        public string CountryCode { get; set; } = string.Empty;
        public string CountryName { get; set; } = string.Empty;
    }

    public class Country
    {
        public string CountryCode { get; set; } = string.Empty;
        public string CountryName { get; set; } = string.Empty;
    }
}

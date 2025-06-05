using CityBreaks.Web.Models;
using CityBreaks.Web06.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CityBreaks.Web08.Pages
{
    public class CityDetailsModel : PageModel
    {
        private readonly ICityService _cityService;

        public CityDetailsModel(ICityService cityService)
        {
            _cityService = cityService;
        }

        public City? City { get; set; }

        public async Task<IActionResult> OnGetAsync(string name)
        {
            City = await _cityService.GetByNameAsync(name);
            
            if (City == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}

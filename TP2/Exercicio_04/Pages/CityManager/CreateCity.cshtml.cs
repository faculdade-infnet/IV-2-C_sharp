using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Exercicio_02.Pages.CityManager
{
    public class CreateCityModel : PageModel
    {
        [BindProperty]

        [Required(ErrorMessage = "O nome da cidade � obrigat�rio.")]
        [MinLength(3, ErrorMessage = "O nome da cidade deve ter no m�nimo 3 caracteres.")]
        public string CityName { get; set; }

        public void OnPost()
        {

        }
    }
}

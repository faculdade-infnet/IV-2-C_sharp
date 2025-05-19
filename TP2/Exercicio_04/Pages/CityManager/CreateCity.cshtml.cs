using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Exercicio_02.Pages.CityManager
{
    public class CreateCityModel : PageModel
    {
        [BindProperty]

        [Required(ErrorMessage = "O nome da cidade é obrigatório.")]
        [MinLength(3, ErrorMessage = "O nome da cidade deve ter no mínimo 3 caracteres.")]
        public string CityName { get; set; }

        public void OnPost()
        {

        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace Exercicio_05.Pages
{
    public class CreateCountryModel : PageModel
    {
        [BindProperty]
        public List<InputModel> Inputs { get; set; } = new List<InputModel>();

        public List<Country> Countries { get; set; } = new List<Country>();

        public void OnGet()
        {
            // Inicializa com 5 linhas vazias para exibir no formulário
            if (Inputs.Count == 0)
            {
                for (int i = 0; i < 5; i++)
                    Inputs.Add(new InputModel());
            }
        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                Countries = new List<Country>();
                foreach (var input in Inputs)
                {
                    Countries.Add(new Country
                    {
                        CountryCode = input.CountryCode,
                        CountryName = input.CountryName
                    });
                }
            }
        }
    }

    public class InputModel
    {
        [Required(ErrorMessage = "O Código do país é obrigatório.")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "O Código do País deve ter exatamente 2 caracteres.")]
        public string CountryCode { get; set; } = string.Empty;
        [Required(ErrorMessage = "O Nome do país é obrigatório.")]
        public string CountryName { get; set; } = string.Empty;
    }

    public class Country
    {
        public string CountryCode { get; set; } = string.Empty;
        public string CountryName { get; set; } = string.Empty;
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace RazorSample.Pages.Local
{
    public class ValidacaoTagsModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "Lorgadouro � obrigat�rio!")]
        public string Logradouro { get; set; } = string.Empty;

        [BindProperty]
        [StringLength(20, ErrorMessage = "Bairro deve conter no m�ximo, 20 caracteres")]
        public string? Bairro { get; set; } = string.Empty;

        [BindProperty]
        [Required(ErrorMessage = "Cidade � obrigat�rio!")]
        public string Cidade { get; set; } = string.Empty;

        [BindProperty]
        public string? Mensagem { get; set; } = string.Empty;

        public void OnGet()
        {
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace RazorSample.Pages.Local
{
    public class ValidacaoModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "Lorgadouro é obrigatório!")]
        public string Logradouro { get; set; } = string.Empty;
        
        [BindProperty]
        [StringLength(20, ErrorMessage = "Bairro deve conter no máximo, 20 caracteres")]
        public string? Bairro { get; set; } = string.Empty;

        [BindProperty]
        [Required(ErrorMessage = "Cidade é obrigatório!")]
        public string Cidade { get; set; } = string.Empty;

        [BindProperty]
        public string? Mensagem { get; set; } = string.Empty;

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                // Redireciona para alguma página
            }

            return Page();
        }
    }
}

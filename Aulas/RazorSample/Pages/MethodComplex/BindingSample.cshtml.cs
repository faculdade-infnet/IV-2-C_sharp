using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorSample.Pages.MethodComplex
{
    public class BindingSampleModel : PageModel
    {
        [BindProperty]
        public Login? Login { get; set; }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            Login!.Nome = Login.Nome.ToUpper();
        }
    }

    public class Login
    {
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}

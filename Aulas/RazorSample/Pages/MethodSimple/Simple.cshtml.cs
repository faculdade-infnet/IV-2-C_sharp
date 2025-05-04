using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorSample.Pages.MethodSimple
{
    public class SimpleModel : PageModel
    {
        [BindProperty]
        public string Nome { get; set; } = string.Empty;

        [BindProperty]
        public string Email { get; set; } = string.Empty;
        
        public void OnGet()
        {
        }
    }
}

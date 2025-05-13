using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorSample.Pages.Local
{
    [IgnoreAntiforgeryToken(Order = 1001)]
    public class LocalizacaoModel : PageModel
    {
        public string Mensagem { get; set; } = string.Empty;

        public void OnPost()
        {
            if (!string.IsNullOrEmpty(Request.Form["cidade"]))            
                Mensagem = $"Campo cidade lido no POST: {Request.Form["cidade"]}";            
        }

        public void OnGet()
        {
            if (!string.IsNullOrEmpty(Request.Query["cidade"]))            
                Mensagem = $"Campo cidade lido no GET: {Request.Query["cidade"]}";            
        }
    }
}

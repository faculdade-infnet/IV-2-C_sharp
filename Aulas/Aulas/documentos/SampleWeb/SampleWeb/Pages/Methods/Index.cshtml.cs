using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SampleWeb.Pages.Methods
{
    public class IndexModel : PageModel
    {
        public string Mensagem { get; set; } = string.Empty;
        public void OnGet()
        {
            Mensagem = "Get acionado!";
        }
        public void OnPost()
        {
            Mensagem = "Post acionado!";
        }
        public void OnGetUpperMessage()
        {
            Mensagem = "Get acionado em maiúsculas!".ToUpper();
        }
        public void OnPostDelete()
        {
            Mensagem = "Delete acionado!";
        }
        public void OnPostEdit(int id)
        {
            Mensagem = "Edit acionado!";
        }
        public void OnPostView(int id)
        {
            Mensagem = "View acionado!";
        }
        public void OnGetCase(bool allUpper)
        {
            if (allUpper)
            {
                Mensagem = $"Parâmetro allUpper como {allUpper}".ToUpper();
            }
            else
            {
                Mensagem = $"Parâmetro allUpper como {allUpper}";
            }
        }
    }
}

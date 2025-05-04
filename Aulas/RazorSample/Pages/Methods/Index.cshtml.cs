using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection.Metadata;

namespace RazorSample.Pages.Methods
{
    public class IndexModel : PageModel
    {
        public string Mensagem { get; set; } = string.Empty;

        //Métodos tipo Handle Method
        public void OnGet()
        {
            Mensagem = "Get acionado!";
        }
        public void OnPost()
        {
            Mensagem = "Post acionado!";
        }


        //Métodos tipo Named Method
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

        // Parâmetros em Method Handlers
        public void OnGetCase(bool allUpper, int quantidade)
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

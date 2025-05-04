using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection.Metadata;

namespace RazorSample.Pages.Methods
{
    public class IndexModel : PageModel
    {
        public string Mensagem { get; set; } = string.Empty;

        //M�todos tipo Handle Method
        public void OnGet()
        {
            Mensagem = "Get acionado!";
        }
        public void OnPost()
        {
            Mensagem = "Post acionado!";
        }


        //M�todos tipo Named Method
        public void OnGetUpperMessage()
        {
            Mensagem = "Get acionado em mai�sculas!".ToUpper();
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

        // Par�metros em Method Handlers
        public void OnGetCase(bool allUpper, int quantidade)
        {
            if (allUpper)
            {
                Mensagem = $"Par�metro allUpper como {allUpper}".ToUpper();
            }
            else
            {
                Mensagem = $"Par�metro allUpper como {allUpper}";
            }
        }

    }
}

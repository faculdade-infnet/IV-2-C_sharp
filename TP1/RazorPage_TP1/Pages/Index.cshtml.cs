using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicio_08_RazorPage.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<Produtos> produtos = new List<Produtos>();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["Title"] = "Lista de Produtos";

            produtos.Add(new Produtos { Nome = "Arroz Branco 5Kg [Tio João]", Preco = 47.15 });
            produtos.Add(new Produtos { Nome = "Feijão 1Kg [Urbano] ", Preco = 10.03 });
            produtos.Add(new Produtos { Nome = "Refrigerante Laranja [Sukita]", Preco = 7.89 });
        }
    }

    public class Produtos
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
    }
}

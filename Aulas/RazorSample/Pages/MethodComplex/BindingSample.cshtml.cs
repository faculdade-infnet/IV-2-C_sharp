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

            Func<double, double, double> Calcular = Adicionar;
            double resultadoSoma = Calcular(9, 9);
            Console.WriteLine(resultadoSoma);

            Func<double, double, double> CalcularAnonimo = delegate (double n1, double n2)
            {
                return n1 + n2;
            };

            double resultadoSoma2 = CalcularAnonimo(1, 9);
            Console.WriteLine(resultadoSoma2);

        }

        private static double Adicionar(double n1, double n2)
        {
            return n1 + n2;
        }
    }

    public class Login
    {
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}

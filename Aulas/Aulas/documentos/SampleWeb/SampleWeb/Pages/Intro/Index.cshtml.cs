using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;

namespace SampleWeb.Pages.Intro
{

    public class IntroModel : PageModel
    {
        public List<Aula> aulas = Enumerable.Empty<Aula>().ToList();
        public void OnGet()
        {
            ViewData["Title"] = "Code Behind em Razor Pages";

            aulas.Add(new() { Dia = DateTime.Now.AddDays(-7), Materia = "Linq" });
            aulas.Add(new() { Dia = DateTime.Now, Materia = "Razor" });
        }
    }

    public class Aula
    {
        public DateTime Dia { get; set; }

        public string Materia { get; set; } = string.Empty;
    }
}

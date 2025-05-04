using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;

namespace RazorSample.Pages.Intro
{

    public class IntroModel : PageModel
    {
        public List<Aula> aulas = Enumerable.Empty<Aula>().ToList();
        public void OnGet()
        {
            ViewData["Title"] = "Code Behind em Razor Pages";

            //aulas.Add(new() { Dia = DateTime.Now.AddDays(-7), Materia = "Linq" });
            aulas.Add(new() { Dia = new DateTime(2025, 4, 16), Materia = "Aula 01 - Linq" });
            aulas.Add(new() { Dia = new DateTime(2025, 4, 25), Materia = "Aula 02 - Razor" });
            aulas.Add(new() { Dia = new DateTime(2025, 4, 30), Materia = "Aula 03 - Razor (Page Model)" });
        }
    }

    public class Aula
    {
        public DateTime Dia { get; set; }

        public string Materia { get; set; } = string.Empty;
    }
}

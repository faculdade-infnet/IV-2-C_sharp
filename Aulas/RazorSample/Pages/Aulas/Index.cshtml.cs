using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;

namespace RazorSample.Pages.Aulas
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
            aulas.Add(new() { Dia = new DateTime(2025, 4, 30), Materia = "Aula 03 - Razor (Page Model)", UrlPagina = "/MethodComplex/BindingSample" });
            aulas.Add(new() { Dia = new DateTime(2025, 5, 02), Materia = "Aula 04 - Delagates, Code Blocks, Transições, Control Block", UrlPagina="/Aulas/Aula04" });
            aulas.Add(new() { Dia = new DateTime(2025, 5, 07), Materia = "Aula 05 - " });
            aulas.Add(new() { Dia = new DateTime(2025, 5, 09), Materia = "Aula 06 - " });
            aulas.Add(new() { Dia = new DateTime(2025, 5, 14), Materia = "Aula 07 - " });
            aulas.Add(new() { Dia = new DateTime(2025, 5, 16), Materia = "Aula 08 - " });
            aulas.Add(new() { Dia = new DateTime(2025, 5, 21), Materia = "Aula 09 - " });
            aulas.Add(new() { Dia = new DateTime(2025, 5, 23), Materia = "Aula 10 - " });
            aulas.Add(new() { Dia = new DateTime(2025, 5, 28), Materia = "Aula 11 - " });
            aulas.Add(new() { Dia = new DateTime(2025, 5, 30), Materia = "Aula 12 - " });
            aulas.Add(new() { Dia = new DateTime(2025, 6, 04), Materia = "Aula 13 - " });
            aulas.Add(new() { Dia = new DateTime(2025, 6, 06), Materia = "Aula 14 - " });
            aulas.Add(new() { Dia = new DateTime(2025, 6, 11), Materia = "Aula 15 - " });
            aulas.Add(new() { Dia = new DateTime(2025, 6, 13), Materia = "Aula 16 - " });
            aulas.Add(new() { Dia = new DateTime(2025, 6, 18), Materia = "Aula 17 - " });
            aulas.Add(new() { Dia = new DateTime(2025, 6, 25), Materia = "Aula 18 - " });
            aulas.Add(new() { Dia = new DateTime(2025, 6, 27), Materia = "Aula 19 - " });
        }
    }

    public class Aula
    {
        public DateTime Dia { get; set; }

        public string Materia { get; set; } = string.Empty;
        public string? UrlPagina { get; set; }
    }
}

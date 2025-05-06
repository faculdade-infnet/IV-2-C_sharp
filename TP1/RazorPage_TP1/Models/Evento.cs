namespace Exercicio_08_RazorPage.Models
{
    public class Evento
    {
        public string Titulo { get; set; } = string.Empty;
        public DateTime Data { get; set; } = DateTime.Now;
        public string Local { get; set; } = string.Empty;
    }
}

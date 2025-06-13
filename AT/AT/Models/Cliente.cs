using System.ComponentModel.DataAnnotations;

namespace AT.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string Nome { get; set; } = string.Empty;
        [Required(ErrorMessage = "O email é obrigatório.")]
        public string Email { get; set; } = string.Empty;

        //[Required]
        //public _Endereco Endereco { get; set; } = new _Endereco();

        // Lista de reservas associadas ao cliente
        public List<Reserva> Reservas { get; set; } = new();
    }
}

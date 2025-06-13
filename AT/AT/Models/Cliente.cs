namespace AT.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        // Lista de reservas associadas ao cliente
        public List<Reserva> Reservas { get; set; } = new();
    }
}

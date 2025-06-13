using System.ComponentModel.DataAnnotations;

namespace AT.Models
{
    public class _Endereco
    {
        [Required(ErrorMessage = "O logradouro é obrigatório.")]
        [MinLength(5, ErrorMessage = "O logradouro deve ter no mínimo 5 caracteres.")]
        public string Logradouro { get; set; } = string.Empty;

        [Required(ErrorMessage = "A cidade é obrigatória.")]
        [StringLength(50, ErrorMessage = "A cidade deve ter no máximo 50 caracteres.")]
        public string Cidade { get; set; } = string.Empty;
    }
}

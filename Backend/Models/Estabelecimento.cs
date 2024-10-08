using System.ComponentModel.DataAnnotations;
using SaborResenha.Enums;

namespace SaborResenha.Models
{
    public class Estabelecimento
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public required string Nome { get; set; }

        [Required]
        [Phone]
        public required string Telefone { get; set; }

        [Required]
        public Categoria Categoria { get; set; }

        [Required]
        public required string HorarioFuncionamento { get; set; }

        public string? Instagram { get; set; }

        [Required]
        public required string Cep { get; set; }

        public string? Complemento { get; set; }

        [Required]
        public int Numero { get; set; }
        
        [Required]
        public required string Descricao { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroEstudantes.Models
{
    public class Estudante
    {
        public int Id { get; set; } // identidade única de cada registro no banco de dados

        [Required(ErrorMessage = "Campo obrigatório.")]
        [StringLength(100)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [MinLength(14, ErrorMessage ="CPF inválido.")]
        [StringLength(14)]
        public string? Cpf { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [StringLength(200)]
        public string? Endereco { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataConclusao { get; set; }
    }
}

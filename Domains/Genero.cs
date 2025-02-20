using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_filmes_senai.Domains
{
    [Table("Genero")]
    public class Genero
    {
        [Key]
        public Guid IdGenero { get; set; }

        [Column(TypeName = "varchar(38)")]
        [Required(ErrorMessage = "Nome do genero e obrigatorio !")]
        public string Nome { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_filmes_senai.Domains.Filme
{
    public class Filme
    {
        [Key]
        public Guid IdFilme { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Titulo do Filme e obrigatorio")]
        public string? Titulo { get; set; }

        ///<sumary>
        /// Referencia da tabela genero
        /// </sumary>

        public Guid IdGenero { get; set; }

        [ForeignKey("IdGenero")]
        public Genero? Genero { get; set; }
    }
}

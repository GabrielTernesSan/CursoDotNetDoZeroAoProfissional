using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesFilmes.Model
{
    public class Filme
    {
        public int Id { get; set; }
        
        [StringLength(100, MinimumLength = 3)]
        public string Titulo { get; set; } = string.Empty;
        
        [Display(Name = "Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTimeOffset DataLancamento { get; set; }

        [RegularExpression("^[A-ZÀ-Ÿ][a-zA-ZÀ-ÿ\\s]*$")]
        [StringLength(50)]
        public string Genero { get; set; } = string.Empty;

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }

        [Range(0, 5)]
        public int Classificacao { get; set; } = 0;
    }
}

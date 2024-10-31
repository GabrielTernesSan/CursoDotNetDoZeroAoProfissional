using System.ComponentModel.DataAnnotations;

namespace RazorPagesFilmes.Model
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = null!;
        [DataType(DataType.Date)]
        public DateTimeOffset DataLancamento { get; set; }
        public string Genero { get; set; } = null!;
        public decimal Preco { get; set; }
    }
}

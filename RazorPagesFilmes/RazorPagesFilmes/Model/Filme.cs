﻿using System.ComponentModel.DataAnnotations;

namespace RazorPagesFilmes.Model
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        [Display(Name = "Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTimeOffset DataLancamento { get; set; }
        public string Genero { get; set; } = string.Empty;
        public decimal Preco { get; set; }
        public int Classificacao { get; set; }
    }
}

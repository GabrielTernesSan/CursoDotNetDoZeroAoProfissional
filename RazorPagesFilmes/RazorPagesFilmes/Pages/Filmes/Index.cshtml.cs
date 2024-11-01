using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesFilmes.Model;

namespace RazorPagesFilmes.Pages.Filmes
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesFilmes.Data.RazorPagesFilmesContext _context;

        public IndexModel(RazorPagesFilmes.Data.RazorPagesFilmesContext context)
        {
            _context = context;
        }

        [BindProperty(SupportsGet = true)]
        public string PalavraChave { get; set; }
        
        [BindProperty(SupportsGet = true)]
        public string GeneroFilme { get; set; }
        
        public SelectList Generos { get; set; }

        public IList<Filme> Filme { get;set; } = default!;

        public async Task OnGetAsync()
        {
            var filmes = from f in _context.Filme
                         select f;

            if(!string.IsNullOrWhiteSpace(PalavraChave))
                filmes = filmes.Where(x => x.Titulo.Contains(PalavraChave));

            if(!string.IsNullOrEmpty(GeneroFilme))
                filmes = filmes.Where(x => x.Genero == GeneroFilme);

            Generos = new SelectList(await _context.Filme.Select(x => x.Genero).Distinct().ToListAsync());

            Filme = await filmes.ToListAsync();
        }
    }
}

﻿using Microsoft.AspNetCore.Mvc.RazorPages;
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

        public IList<Filme> Filme { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Filme = await _context.Filme.ToListAsync();
        }
    }
}

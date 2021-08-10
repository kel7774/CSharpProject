using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CSharpProject.Data;
using CSharpProject.Models;

namespace CSharpProject.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly CSharpProject.Data.CSharpProjectMovieContext _context;

        public IndexModel(CSharpProject.Data.CSharpProjectMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}

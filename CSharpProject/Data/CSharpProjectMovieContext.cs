using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CSharpProject.Models;

namespace CSharpProject.Data
{
    public class CSharpProjectMovieContext : DbContext
    {
        public CSharpProjectMovieContext (DbContextOptions<CSharpProjectMovieContext> options)
            : base(options)
        {
        }

        public DbSet<CSharpProject.Models.Movie> Movie { get; set; }
    }
}

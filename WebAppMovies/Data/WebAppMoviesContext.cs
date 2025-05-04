using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppMovies.Models;

namespace WebAppMovies.Data
{
    public class WebAppMoviesContext : DbContext
    {
        public WebAppMoviesContext(DbContextOptions<WebAppMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppMovies.Models.Movie> Movie { get; set; } = default!;
    }
}

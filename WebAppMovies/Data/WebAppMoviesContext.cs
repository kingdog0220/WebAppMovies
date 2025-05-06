using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppMovies.Models;

namespace WebAppMovies.Data
{
    public class WebAppMoviesContext : IdentityDbContext
    {
        public WebAppMoviesContext(DbContextOptions<WebAppMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; } = default!;
    }
}

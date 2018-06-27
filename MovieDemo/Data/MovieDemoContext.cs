using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MovieDemo.Models
{
    public class MovieDemoContext : DbContext
    {
        public MovieDemoContext (DbContextOptions<MovieDemoContext> options)
            : base(options)
        {
        }

        public DbSet<MovieDemo.Models.Movie> Movie { get; set; }
    }
}

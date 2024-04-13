using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Movie.Models;

namespace MVC_Movie.Data
{
    public class MVC_MovieContext : DbContext
    {
        public MVC_MovieContext (DbContextOptions<MVC_MovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; } = default!;
    }
}

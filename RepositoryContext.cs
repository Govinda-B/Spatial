using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Spatial
{
    public class RepositoryContext:DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {

        }
        public DbSet<City> Cities { get; set; }
        public DbSet<City2> Cities2 { get; set; }
        //public DbSet<Book> Books { get; set; }
    }
}

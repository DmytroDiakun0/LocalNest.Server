using LocalNest.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace LocalNest.Server.Data
{
    public class LocalNestDbContext : DbContext
    {
        public LocalNestDbContext(DbContextOptions<LocalNestDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}

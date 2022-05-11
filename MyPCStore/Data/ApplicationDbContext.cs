using Microsoft.EntityFrameworkCore;
using MyPCStore.Models;

namespace MyPCStore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Manufacturer> Manufacturer { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}

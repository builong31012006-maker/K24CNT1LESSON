using Microsoft.EntityFrameworkCore;

namespace NetCoreL.Models // Đồng bộ namespace với Category.cs và Product.cs
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
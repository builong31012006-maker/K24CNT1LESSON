using Microsoft.EntityFrameworkCore;
using buivanlong_2410900047_exam.Models;

namespace buivanlong_2410900047_exam.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<bvlStudent> bvlStudent { get; set; }
    }
}
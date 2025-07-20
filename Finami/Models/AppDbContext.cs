using Microsoft.EntityFrameworkCore;

namespace Finami.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories
        {
            get; set;
        }
    }
}

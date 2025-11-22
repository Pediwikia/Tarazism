using Microsoft.EntityFrameworkCore;
using Tarazism.Models;

namespace Tarazism.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        // === TABLES ===
        public DbSet<TarazUser> Users { get; set; } = null!;
        public DbSet<ReviewModel> Reviews { get; set; } = null!;
    }
}

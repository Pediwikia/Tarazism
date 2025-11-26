using Microsoft.EntityFrameworkCore;
using Tarazism.Models;

namespace Tarazism.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<TarazUser> Users { get; set; }
        public DbSet<UserReview> Reviews { get; set; }
    }
}

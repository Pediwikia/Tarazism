using Microsoft.EntityFrameworkCore;
using Tarazism.Models;

namespace Tarazism.Data
{
    public class TarazismDbContext : DbContext
    {
        public TarazismDbContext(DbContextOptions<TarazismDbContext> options)
            : base(options)
        {
        }

        public DbSet<TarazUser> Users { get; set; }
        public DbSet<UserReview> Reviews { get; set; }
    }
}

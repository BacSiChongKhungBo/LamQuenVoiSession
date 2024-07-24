using LamQuenVoiSession.Models;
using Microsoft.EntityFrameworkCore;

namespace LamQuenVoiSession
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasData(new User(1,"Admin", "Admin"));
            modelBuilder.Entity<User>().HasData(new User(2, "Admin1", "Admin1"));
        }
    }
}

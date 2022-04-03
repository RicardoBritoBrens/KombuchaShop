using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace KombuchaShop.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Kombucha> Kombuchas { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Kombucha>().HasData(new
                List<Kombucha>()
            {
                new Kombucha()
                {
                }
            });
        }
    }
}
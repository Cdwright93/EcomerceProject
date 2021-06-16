using eCommerceStarterCode.Configuration;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eCommerceStarterCode.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions options)
            :base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        public DbSet<Ratings> Ratings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ShoppingCart>().HasKey(SC => new { SC.UserId, SC.ProductId });
            modelBuilder.Entity<Ratings>().HasKey(r => new { r.ProductId });
            modelBuilder.Entity<Reviews>().HasKey(r => new { r.ProductId });
            modelBuilder.ApplyConfiguration(new RolesConfiguration());
        }

    }
}

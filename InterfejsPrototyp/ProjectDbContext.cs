using InterfejsPrototyp.Other;
using Microsoft.EntityFrameworkCore;

namespace InterfejsPrototyp
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options) {}
        public DbSet<Country> Countries { get; set; }
        public DbSet<Customer> Customers { get; set; } 
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CartItems> CartItems { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>()
                .HasKey(c => c.Code);
        }

    }
}

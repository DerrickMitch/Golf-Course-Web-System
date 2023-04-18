using Microsoft.EntityFrameworkCore;
using StoreAPI.Models;

namespace StoreAPI.Data;

public class ProductContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Manufacturer> Manufacturers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("DataSource=OnlineStore.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configured one to many relationship with Manufacturer
        modelBuilder.Entity<Product>(entity =>
        {
            // Relationships
            entity
                .HasOne(e => e.Manufacturer)
                .WithMany(p => p.Products);

            // Price converstions
            entity
                .Property(e => e.SalePrice)
                .HasConversion(
                    x => x * 100,
                    x => x / 100
                );
            entity
                .Property(e => e.PurchasePrice)
                .HasConversion(
                    x => x * 100,
                    x => x / 100
                );
        });
    }
}
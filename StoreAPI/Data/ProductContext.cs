using Microsoft.EntityFrameworkCore;
using StoreAPI.Models;

namespace StoreAPI.Data;

public class ProductContext : DbContext
{
    private DataConfig config;
    public DbSet<Product> Products { get; set; }

    public ProductContext(DataConfig _config)
    {
        config = _config;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(config.SqliteConnectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configured one to many relationship with Manufacturer
        modelBuilder.Entity<Product>()
            .HasOne(e => e.Manufacturer)
            .WithMany(p => p.Products);
    }
}
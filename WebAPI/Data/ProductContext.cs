using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data;

public class ProductContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Manufacturer> Manufacturers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("DataSource=GolfCourse.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configured one to many relationship with Manufacturer
        modelBuilder.Entity<Product>(entity =>
        {
            // Relationships
            entity
                .HasOne(e => e.Manufacturer);

            // Price converstion
            entity
                .Property(e => e.Price)
                .HasConversion(
                    x => x * 100,
                    x => x / 100
                );
        });
    }
}
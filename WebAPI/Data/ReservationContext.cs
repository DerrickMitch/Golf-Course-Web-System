using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data;

public class ReservationContext : DbContext
{
    public DbSet<TeeTimeReservation> Reservations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("DataSource=GolfCourse.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TeeTimeReservation>(entity => 
        {
            entity
                .Property(x => x.ReservationTime)
                .HasConversion(
                    x => x.ToString(),
                    x => DateTime.Parse(x)
                );
        });
    }
}
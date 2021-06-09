using Microsoft.EntityFrameworkCore;

namespace Travel.Models
{
  public class TravelContext : DbContext
  {
    public TravelContext(DbContextOptions<TravelContext> options)
        : base(options)
    {
    }


    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Review>()
        .HasData(
          new Review { ReviewId = 1, City = "New York", Country = "USA", Description = "Great", Rating = 9 },
          new Review { ReviewId = 2, City = "Paris", Country = "France", Description = "Great", Rating = 9 },
          new Review { ReviewId = 3, City = "Seoul", Country = "South Korea", Description = "Great", Rating = 9 },
          new Review { ReviewId = 4, City = "Milan", Country = "Italy", Description = "Great", Rating = 9 },
          new Review { ReviewId = 5, City = "Hong Kong", Country = "China", Description = "Great", Rating = 9 }
        );
    }
    public DbSet<Review> Reviews { get; set; }
  }
}

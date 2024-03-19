using Microsoft.EntityFrameworkCore;

namespace ParksLookup.Models
{
  public class ParksLookupContext : DbContext
  {
    public DbSet<Park> Parks { get; set; }

    public ParksLookupContext(DbContextOptions<ParksLookupContext> options) : base(options)
    {
    }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Park>()
              .HasData(
                new Park { ParkId = 1, Name = "Acadia", Type = "National", Location = "Maine" },
                new Park { ParkId = 2, Name = "Great Smoky Mountains", Type = "National", Location = "Tennessee" },
                new Park { ParkId = 3, Name = "Beacon Rock", Type = "State", Location = "Washington" }
              );
        }
    }
}
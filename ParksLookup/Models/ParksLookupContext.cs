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
                new Park { ParkId = 1 }
              );
        }
    }
}
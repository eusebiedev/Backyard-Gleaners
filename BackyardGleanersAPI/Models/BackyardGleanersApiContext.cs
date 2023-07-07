using Microsoft.EntityFrameworkCore;

namespace BackyardGleanersApi.Models
{
  public class BackyardGleanersApiContext : DbContext
  {
    public DbSet<Host> Hosts { get; set; }
    public BackyardGleanersApiContext(DbContextOptions<BackyardGleanersApiContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Host>()
        .HasData(
          new Host { },
          new Host { },
          new Host { },
          new Host { },
          new Host { },
          new Host { },
          new Host { },
          new Host { },
          new Host { },
          new Host { }
        );
    }
  }
}
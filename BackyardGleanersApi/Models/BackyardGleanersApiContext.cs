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
          new Host { HostId = 1, },
          new Host { HostId = 2, },
          new Host { HostId = 3, },
          new Host { HostId = 4, },
          new Host { HostId = 5, },
          new Host { HostId = 6, },
          new Host { HostId = 7, },
          new Host { HostId = 8, },
          new Host { HostId = 9, },
          new Host { HostId = 10, }

        );
    }
  }
}
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
          new Host { HostId = 1, Name = "", Description = "", Food = "", Availability = "", Location = "", Contact = "" },
          new Host { HostId = 2, Name = "", Description = "", Food = "", Availability = "", Location = "", Contact = "" },
          new Host { HostId = 3, Name = "", Description = "", Food = "", Availability = "", Location = "", Contact = "" },
          new Host { HostId = 4, Name = "", Description = "", Food = "", Availability = "", Location = "", Contact = "" },
          new Host { HostId = 5, Name = "", Description = "", Food = "", Availability = "", Location = "", Contact = "" },
          new Host { HostId = 6, Name = "", Description = "", Food = "", Availability = "", Location = "", Contact = "" },
          new Host { HostId = 7, Name = "", Description = "", Food = "", Availability = "", Location = "", Contact = "" },
          new Host { HostId = 8, Name = "", Description = "", Food = "", Availability = "", Location = "", Contact = "" },
          new Host { HostId = 9, Name = "", Description = "", Food = "", Availability = "", Location = "", Contact = "" },
          new Host { HostId = 10, Name = "", Description = "", Food = "", Availability = "", Location = "", Contact = "" }
        );
    }
  }
}
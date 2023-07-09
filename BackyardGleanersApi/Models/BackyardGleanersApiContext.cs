using Microsoft.EntityFrameworkCore;

namespace BackyardGleanersApi.Models
{
  public class BackyardGleanersApiContext : DbContext
  {
    public DbSet<Gardener> Gardeners { get; set; }
    public BackyardGleanersApiContext(DbContextOptions<BackyardGleanersApiContext> options) : base(options)
    {
    }
  }
}
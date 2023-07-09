using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using BackyardGleanersApi.Models;

namespace BackyardGleanersApi.Controllers.v2
{
  [ApiController] 
  [Route("api/v{version:apiVersion}/[controller]")]
  [ApiVersion("2.0")]
  
  public class GardenersController : ControllerBase
  {
    private readonly BackyardGleanersApiContext _db;

    public GardenersController(BackyardGleanersApiContext db)
    {
      _db  = db;
    }

    [HttpGet]
    public async Task<List<Gardener>> Get(string name, string description, string food, string availability, string location, string contact)
    {
      IQueryable<Gardener> query = _db.Gardeners 
                                  .AsQueryable();
      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }
      if (description != null)
      {
        query = query.Where(entry => entry.Description == description);
      }
      if (food != null)
      {
        query = query.Where(entry => entry.Food == food);
      }
      if (availability != null)
      {
        query = query.Where(entry => entry.Availability == availability);
      }
      if (location != null)
      {
        query = query.Where(entry => entry.Location == location);
      }
      if (contact != null)
      {
        query = query.Where(entry => entry.Contact == contact);
      }
    return await query.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Gardener>> GetHost(int id)
    {
      Gardener gardener = await _db.Gardeners
                            .FirstOrDefaultAsync(gardener => gardener.GardenerId == id);
      if (gardener == null)
      {
        return NotFound();
      }
      return gardener;
    }

  }
}

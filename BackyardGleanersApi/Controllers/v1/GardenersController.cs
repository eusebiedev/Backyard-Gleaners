using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using BackyardGleanersApi.Models;

namespace BackyardGleanersApi.Controllers.v1
{
  [ApiController] 
  [Route("api/v{version:apiVersion}/[controller]")]
  [ApiVersion("1.0")]
  
  public class GardenersController : ControllerBase
  {
    private readonly BackyardGleanersApiContext _db;

    public GardenersController(BackyardGleanersApiContext db)
    {
      _db  = db;
    }

    [HttpGet]
    public async Task<List<Gardener>> Get(int pageNumber, int pageSize, string name, string description, string food, string availability, string location, string contact)
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
      if (pageNumber > 0 && pageSize > 0)
      {
        query = query.Skip((pageNumber - 1) * pageSize).Take(pageSize); 
      }
    return await query.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Gardener>> GetGardener(int id)
    {
      Gardener gardener = await _db.Gardeners
                            .FirstOrDefaultAsync(gardener => gardener.GardenerId == id);
      if (gardener == null)
      {
        return NotFound();
      }
      return gardener;
    }

    [HttpPost]
    public async Task<ActionResult<Gardener>> Post([FromBody] Gardener gardener)
    {
      _db.Gardeners.Add(gardener);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetGardener), new { id = gardener.GardenerId }, gardener);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Gardener gardener)
    {
      if (id != gardener.GardenerId)
      {
        return BadRequest();
      }

      _db.Gardeners.Update(gardener);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!GardenerExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }
        return NoContent();
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteGardener(int id)
    {
      Gardener gardener = await _db.Gardeners.FindAsync(id);
      if (gardener == null)
      {
        return NotFound();
      }

      _db.Gardeners.Remove(gardener);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    private bool GardenerExists(int id)
    {
      return _db.Gardeners.Any(e => e.GardenerId == id);
    }
  }
}

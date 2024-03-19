using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksLookup.Models;

namespace ParksLookup.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private readonly ParksLookupContext _db;

    public ParksController(ParksLookupContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Park>>> Get()
    {
      IQueryable<Park> query = _db.Parks.AsQueryable();
      // query = query.Where(entry => entry.Group == group);

      // if (earlierDateTime != null)
      // {
      //   query = query.Where(entry => entry.ParkDateTime >= DateTime.Parse(earlierDateTime));
      // }

      // if (laterDateTime != null)
      // {
      //   query = query.Where(entry => entry.ParkDateTime <= DateTime.Parse(laterDateTime));
      // }

      return await query.ToListAsync();
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Park>> GetPark(int id)
    {
      Park park = await _db.Parks.FindAsync(id);

      if (park == null)
      {
        return NotFound();
      }

      return park;
    }

    [HttpPost]
    public async Task<ActionResult<Park>> Post(Park park)
    {
      _db.Parks.Add(park);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetPark), new { id = park.ParkId }, park);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Park park)
    {
      if (id != park.ParkId)
      {
        return BadRequest();
      }

      Park parkToModify = await _db.Parks.FindAsync(id);
      // if (userName != parkToModify.UserName)
      // {
      //   return BadRequest();
      // }
      
      _db.ChangeTracker.Clear();
      _db.Parks.Update(park);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ParkExists(id))
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

    private bool ParkExists(int id)
    {
      return _db.Parks.Any(e => e.ParkId == id);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePark(int id)
    {
      Park park = await _db.Parks.FindAsync(id);
      if (park == null)
      {
        return NotFound();
      }

      // if (userName != park.UserName)
      // {
      //   return BadRequest();
      // }

      _db.Parks.Remove(park);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}
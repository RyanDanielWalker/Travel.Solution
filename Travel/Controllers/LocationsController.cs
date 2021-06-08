// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Http;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using Travel.Models;
// using System.Security.Claims;
// using Microsoft.AspNetCore.Identity;
// using Microsoft.AspNetCore.Authorization;
// using Microsoft.AspNetCore.Mvc.Rendering;

// namespace Travel.Controllers
// {
//   // [Authorize]
//   [Route("api/[controller]")]
//   [ApiController]
//   public class LocationsController : ControllerBase
//   {
//     private readonly TravelContext _db;

//     public LocationsController(TravelContext db)
//     {
//       _db = db;
//     }

//     // GET api/locations
//     [HttpGet]
//     public async Task<ActionResult<IEnumerable<Location>>> Get(string city, string country)
//     {
//       var query = _db.Locations.AsQueryable();
//       if (city != null)
//       {
//         query = query.Where(entry => entry.City == city);
//       }
//       if (country != null)
//       {
//         query = query.Where(entry => entry.Country == country);
//       }
//       // if (rating != 0)
//       // {
//       //   query = query.Where(entry => entry.Rating == rating);
//       // }
//       // if (review != null)
//       // {
//       //   query = query.Where(entry => entry.Review == review);
//       // }
//       return await query.ToListAsync();
//     }

//     // POST api/locations
//     [HttpPost]
//     public async Task<ActionResult<Location>> Post(Location location)
//     {
//       _db.Locations.Add(location);
//       await _db.SaveChangesAsync();

//       return CreatedAtAction(nameof(GetLocation), new { id = location.LocationId }, location);
//     }

//     [HttpGet("{id}")]
//     public async Task<ActionResult<Location>> GetLocation(int id)
//     {
//       var location = await _db.Locations.FindAsync(id);
//       // var locationReviews = location.Reviews;

//       if (location == null)
//       {
//         return NotFound();
//       }

//       return location;
//     }

//     // PUT: api/Locations/5
//     [HttpPut("{id}")]
//     public async Task<IActionResult> Put(int id, Location location)
//     {
//       if (id != location.LocationId)
//       {
//         return BadRequest();
//       }

//       _db.Entry(location).State = EntityState.Modified;

//       try
//       {
//         await _db.SaveChangesAsync();
//       }
//       catch (DbUpdateConcurrencyException)
//       {
//         if (!LocationExists(id))
//         {
//           return NotFound();
//         }
//         else
//         {
//           throw;
//         }
//       }

//       return NoContent();
//     }

//     private bool LocationExists(int id)
//     {
//       return _db.Locations.Any(e => e.LocationId == id);
//     }

//     [HttpDelete("{id}")]
//     public async Task<IActionResult> DeleteLocation(int id)
//     {
//       var location = await _db.Locations.FindAsync(id);
//       if (location == null)
//       {
//         return NotFound();
//       }

//       _db.Locations.Remove(location);
//       await _db.SaveChangesAsync();

//       return NoContent();
//     }
//   }
// }


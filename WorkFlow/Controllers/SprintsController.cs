using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorkFlow.Models;

namespace WorkFlow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SprintsController : ControllerBase
    {
        //private readonly Context _context;

        //public SprintsController(Context context)
        //{
        //    _context = context;
        //}

        //// GET: api/Sprints
        //[HttpGet]
        //public IEnumerable<Sprint> GetSprints()
        //{
        //    return _context.Sprints;
        //}

        //// GET: api/Sprints/5
        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetSprint([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var sprint = await _context.Sprints.FindAsync(id);

        //    if (sprint == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(sprint);
        //}

        //// PUT: api/Sprints/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutSprint([FromRoute] int id, [FromBody] Sprint sprint)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != sprint.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(sprint).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!SprintExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Sprints
        //[HttpPost]
        //public async Task<IActionResult> PostSprint([FromBody] Sprint sprint)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    _context.Sprints.Add(sprint);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetSprint", new { id = sprint.Id }, sprint);
        //}

        //// DELETE: api/Sprints/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteSprint([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var sprint = await _context.Sprints.FindAsync(id);
        //    if (sprint == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Sprints.Remove(sprint);
        //    await _context.SaveChangesAsync();

        //    return Ok(sprint);
        //}

        //private bool SprintExists(int id)
        //{
        //    return _context.Sprints.Any(e => e.Id == id);
        //}
    }
}
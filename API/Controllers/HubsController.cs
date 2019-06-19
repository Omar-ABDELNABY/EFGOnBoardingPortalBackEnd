using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;

namespace API.Controllers
{
    [Authorize]
    [EnableCors("_myAllowSpecificOrigins")]
    [Route("api/[controller]")]
    [ApiController]
    public class HubsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public HubsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Hubs
        [HttpGet]
        public IEnumerable<Hub> GetHubs()
        {
            return _context.Hubs;
        }

        // GET: api/Hubs/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetHub([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var hub = await _context.Hubs.FindAsync(id);

            if (hub == null)
            {
                return NotFound();
            }

            return Ok(hub);
        }

        // PUT: api/Hubs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHub([FromRoute] int id, [FromBody] Hub hub)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != hub.ID)
            {
                return BadRequest();
            }

            _context.Entry(hub).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HubExists(id))
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

        // POST: api/Hubs
        [HttpPost]
        public async Task<IActionResult> PostHub([FromBody] Hub hub)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Hubs.Add(hub);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHub", new { id = hub.ID }, hub);
        }

        // DELETE: api/Hubs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHub([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var hub = await _context.Hubs.FindAsync(id);
            if (hub == null)
            {
                return NotFound();
            }

            _context.Hubs.Remove(hub);
            await _context.SaveChangesAsync();

            return Ok(hub);
        }

        private bool HubExists(int id)
        {
            return _context.Hubs.Any(e => e.ID == id);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DAL;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authorization;

namespace API.Controllers
{
    [Authorize]
    [EnableCors("_myAllowSpecificOrigins")]
    [Route("api/[controller]")]
    [ApiController]
    public class SubhubsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SubhubsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Subhubs
        [HttpGet]
        public IEnumerable<Subhub> GetSubHubs()
        {
            return _context.SubHubs;
        }

        // GET: api/Subhubs/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSubhub([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var subhub = await _context.SubHubs.FindAsync(id);

            if (subhub == null)
            {
                return NotFound();
            }

            return Ok(subhub);
        }

        // PUT: api/Subhubs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSubhub([FromRoute] int id, [FromBody] Subhub subhub)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != subhub.ID)
            {
                return BadRequest();
            }

            _context.Entry(subhub).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubhubExists(id))
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

        // POST: api/Subhubs
        [HttpPost]
        public async Task<IActionResult> PostSubhub([FromBody] Subhub subhub)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.SubHubs.Add(subhub);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSubhub", new { id = subhub.ID }, subhub);
        }

        // DELETE: api/Subhubs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubhub([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var subhub = await _context.SubHubs.FindAsync(id);
            if (subhub == null)
            {
                return NotFound();
            }

            _context.SubHubs.Remove(subhub);
            await _context.SaveChangesAsync();

            return Ok(subhub);
        }

        private bool SubhubExists(int id)
        {
            return _context.SubHubs.Any(e => e.ID == id);
        }
    }
}
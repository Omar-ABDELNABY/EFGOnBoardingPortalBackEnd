using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.IdentityModel.Tokens.Jwt;

namespace API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ConnectionsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private UserManager<ApplicationUser> userManager;
        private SignInManager<ApplicationUser> signInManager;

        public ConnectionsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _context = context;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        private Task<ApplicationUser> GetCurrentUserAsync() {
            var userId = User.Claims.ToArray()[0].Value;
            return userManager.FindByIdAsync(userId);
    }

        // GET: api/Connections
        [HttpGet]
        public IEnumerable<Connection> GetConnections()
        {
            return _context.Connections;
        }

        // GET: api/Connections/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetConnection([FromRoute] int id)
        {
            
           var claims =  User.Claims;
           var userId = claims.ToArray()[0].Value;
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var connection = await _context.Connections.FindAsync(id);

            if (connection == null)
            {
                return NotFound();
            }

            return Ok(connection);
        }

        // PUT: api/Connections/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConnection([FromRoute] int id, [FromBody] Connection connection)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != connection.ConnectionID)
            {
                return BadRequest();
            }

            _context.Entry(connection).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConnectionExists(id))
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

        // POST: api/Connections
        [HttpPost]
        public async Task<IActionResult> PostConnection([FromBody] Connection connection)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            connection.Initiator = await GetCurrentUserAsync();
            _context.Connections.Add(connection);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetConnection", new { id = connection.ConnectionID }, connection);
        }

        // DELETE: api/Connections/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConnection([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var connection = await _context.Connections.FindAsync(id);
            if (connection == null)
            {
                return NotFound();
            }

            _context.Connections.Remove(connection);
            await _context.SaveChangesAsync();

            return Ok(connection);
        }

        private bool ConnectionExists(int id)
        {
            return _context.Connections.Any(e => e.ConnectionID == id);
        }
    }
}
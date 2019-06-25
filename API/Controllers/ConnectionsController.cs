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
using DAL.Controls;
using Microsoft.AspNetCore.Cors;
using Utilities;

namespace API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ConnectionsController : ControllerBase
    {
        private ConnectionService connectionService;

        public ConnectionsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            connectionService = new ConnectionService(context, userManager, signInManager);
        }

        private Task<ApplicationUser> GetCurrentUserAsync() {
          
            var userId = User.Claims.ToArray()[0].Value;
            return connectionService.GetCurrentUserAsync(userId);
    }

        // GET: api/Connections
        [HttpGet]
        public IEnumerable<Connection> GetConnections()
        {
            return connectionService.GetConnections();
        }

        [HttpGet]
        [Route("userConnections")]
        public  IActionResult GetUserConnections()
        {

            var claims = User.Claims;
            var userId = claims.ToArray()[0].Value;
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

           
            if (connectionService.GetUserConnections(userId) == null)
            {
                return NotFound();
            }

            return Ok(connectionService.GetUserConnections(userId));
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

            var connection = await connectionService.GetConnection(id);

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
            try
            {
                await connectionService.PutConnection(id, connection);
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
        [EnableCors("_myAllowSpecificOrigins")]
        public async Task<IActionResult> PostConnection([FromBody] Connection connection)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            connection.Initiator = await GetCurrentUserAsync();
             await connectionService.AddConnection(connection);

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
            var connection = await connectionService.DeleteConnection(id);
            if (connection == null)
            {
                return NotFound();
            }
            return Ok(connection);
        }

        private bool ConnectionExists(int id)
        {
            return connectionService.ConnectionExists(id);
        }
    }
}
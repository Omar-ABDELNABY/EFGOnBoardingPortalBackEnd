using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BLL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Cors;
using Utilities;

namespace API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ConnectionsController : ControllerBase
    {
        public UserManager<ApplicationUser> userManager { get; set; }
        public SignInManager<ApplicationUser> signInManager { get; set; }

        public ConnectionsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        private ApplicationUser GetCurrentUser() {

            string userId = User.Claims.ToArray()[0].Value;
            return AuthenticationLogic.GetUserByID(userId);
    }

        // GET: api/Connections
        [Authorize(Roles="Admin")]
        [HttpGet]
        public IEnumerable<Connection> GetConnections()
        {
            return ConnectionsLogic.GetConnections();
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

            var connections = ConnectionsLogic.GetUserConnections(userId);
           
            if (connections == null)
            {
                return NotFound();
            }

            return Ok(connections);
        }




        // GET: api/Connections/5
        [HttpGet("{id}")]
        public IActionResult GetConnection([FromRoute] int id)
        {
            
           var claims =  User.Claims;
           var userId = claims.ToArray()[0].Value;
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var connection = ConnectionsLogic.GetConnection(userId, id);

            if (connection == null)
            {
                return NotFound();
            }

            return Ok(connection);
        }

        // PUT: api/Connections/5
        [Authorize(Roles = "Admin")]
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
            if (await ConnectionsLogic.PutConnection(connection))
                return Ok(connection);
            return NotFound();
        }

        // POST: api/Connections
        [HttpPost]
        [EnableCors("_myAllowSpecificOrigins")]
        public IActionResult PostConnection([FromBody] Connection connection)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            connection.Initiator = GetCurrentUser();
             ConnectionsLogic.AddConnection(connection);

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
            Connection connection = await ConnectionsLogic.DeleteConnection(id);
            if (connection == null)
            {
                return NotFound();
            }
            return Ok(connection);
        }

        private bool ConnectionExists(int id)
        {
            return ConnectionsLogic.ConnectionExists(id);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Utilities;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private UserManager<ApplicationUser> userManager;
        public AuthController(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }

        [HttpPost]
        [Route("login")]
        [EnableCors("_myAllowSpecificOrigins")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
           if (ModelState.IsValid)
            {
                LoginResponse res = await DAL.Auth.Login(userManager, model);
                if (res.success)
                    return Ok(res);
                else
                    return Unauthorized();
            }
            else
            {
                return BadRequest("Invalid Login Model");
            }
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BLL;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Authentication;
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
        private SignInManager<ApplicationUser> signInManager;
        public AuthController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpPost]
        [Route("login")]
        [EnableCors("_myAllowSpecificOrigins")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            if (ModelState.IsValid)
            {
                LoginResponse res = await AuthenticationLogic.Login(userManager, model);
                await Authenticate(res.claims, res.RememberMe);
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

        private async Task Authenticate(Claim[] claims, bool rememberMe)
        {
            var identity = new ClaimsIdentity(claims);
            ClaimsPrincipal identities = new ClaimsPrincipal(identity);
            await Microsoft.AspNetCore.Authentication.AuthenticationHttpContextExtensions.SignInAsync(HttpContext, identities);
        }

        [HttpPost]
        [Route("Register")]
        [EnableCors("_myAllowSpecificOrigins")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                LoginResponse res = await AuthenticationLogic.Register(userManager, signInManager, model);
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
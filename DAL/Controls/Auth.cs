using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DAL
{
    public static class Auth
    {
        public static async Task<LoginResponse> Login(UserManager<ApplicationUser> userManager, LoginModel model)
        {
            var user = await userManager.FindByNameAsync(model.Username);
            if (user != null && await userManager.CheckPasswordAsync(user, model.Password))
            {
                List<Claim> claims = new List<Claim>()
                {
                    new Claim(JwtRegisteredClaimNames.Sid,user.Id),
                    new Claim(JwtRegisteredClaimNames.UniqueName, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };
                var roles = await userManager.GetRolesAsync(user);
                //This is a very important line -> it adds the ROLES in the PAYLOAD of the TOKEN :)
                claims.AddRange(roles.Select(role => new Claim(ClaimsIdentity.DefaultRoleClaimType, role)));

                var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("MySuperSecureKey"));
                var token = new JwtSecurityToken(
                    issuer: "http://oec.com",
                    audience: "http://oec.com",
                    expires: DateTime.UtcNow.AddMinutes(60),
                    claims: claims,
                    signingCredentials: new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256)
                    );
                return new LoginResponse()
                {
                    success = true,
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo,
                    claims = claims.ToArray(),
                    RememberMe = model.RememberMe
                };
            }
            return new LoginResponse() { success = false };

        }


        public static async Task<LoginResponse> Register(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RegisterModel model)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            var user = new ApplicationUser
            {
                UserName = model.Username,
                NormalizedUserName = model.Username.ToUpper(),
                Email = model.Email,
                NormalizedEmail = model.Email.ToUpper(),
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, model.Password),
            };
            var result = await userManager.CreateAsync(user, model.Password);
            var result2 = await userManager.AddToRoleAsync(user, model.Type.ToString("G"));

            if (result.Succeeded && result2.Succeeded)
            {
                return await Login(userManager, new LoginModel() { Username = model.Username, Password = model.Password });
            }
            else
            {
                return new LoginResponse() { success = false };
            }
        }
    }
}

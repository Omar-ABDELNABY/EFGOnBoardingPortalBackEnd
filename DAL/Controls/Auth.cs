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
using System.Transactions;

namespace DAL
{
    public static class Auth
    {

        public static ApplicationUser GetUserByID(ApplicationDbContext context, string userId)
        {
            return context.Users.Find(userId);
                
        }

        public static async Task<LoginResponse> Login(UserManager<ApplicationUser> userManager, LoginModel model)
        {
            var user = await userManager.FindByNameAsync(model.Username);
            var s = await userManager.CheckPasswordAsync(user, model.Password);
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


            #region without Transaction
            IdentityResult result;
            IdentityResult result2 = null;
            result = await userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
                result2 = await userManager.AddToRoleAsync(user, model.Type.ToString("G"));
            #endregion

            #region Transaction
            //using (var scope = new TransactionScope(
            //    TransactionScopeOption.Required,
            //    new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
            //{
            //    try
            //    {
            //        // Run an EF Core command in the transaction
            //        var result = await userManager.CreateAsync(user, model.Password);
            //        var result2 = await userManager.AddToRoleAsync(user, model.Type.ToString("G"));

            //        // Commit transaction if all commands succeed, transaction will auto-rollback
            //        // when disposed if either commands fails
            //        scope.Complete();
            //        if (result.Succeeded & result2.Succeeded)
            //        {
            //            return await Login(userManager, new LoginModel() { Username = model.Username, Password = model.Password });
            //        }
            //        else
            //        {
            //            return new LoginResponse() { success = false };
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        // TODO: Handle failure
            //        return new LoginResponse() { success = false };
            //        //return BadRequest("Registeration failed");
            //    }

            //}
            #endregion

            #region without Transaction
            if (result.Succeeded & result2?.Succeeded??false)
            {
                return await Login(userManager, new LoginModel() { Username = model.Username, Password = model.Password });
            }
            else
            {
                return new LoginResponse() { success = false };
            }
            #endregion

        }

        private static LoginResponse BadRequest(string v)
        {
            throw new NotImplementedException();
        }
    }
}

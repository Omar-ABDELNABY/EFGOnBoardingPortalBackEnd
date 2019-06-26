using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Microsoft.AspNetCore.Identity;
using Utilities;

namespace BLL
{
    public static class AuthenticationLogic
    {
        public static async Task<LoginResponse> Login(UserManager<ApplicationUser> userManager, LoginModel model)
        {
            return await DAL.Auth.Login(userManager, model);
        }

        public static async Task<LoginResponse> Register(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RegisterModel model)
        {
            return await DAL.Auth.Register(userManager, signInManager, model);
        }

        public static ApplicationUser GetUserByID(string userId)
        {
            using (ApplicationDbContext context = Contexts.createApplicationDbContext())
            {
                return DAL.Auth.GetUserByID(context , userId);
            }
            
        }
    }

}

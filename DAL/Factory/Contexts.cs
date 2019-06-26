using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using Utilities;

namespace DAL
{
    public static class Contexts
    {
        private const string ConnectionString = "Server=.;Database=EFGOnBoardingPortal;Trusted_Connection=True;MultipleActiveResultSets=true";
        //public static UserManager<ApplicationUser> createUserManager()
        //{
        //    return new UserManager<ApplicationUser>(new UserStore<ApplicationUser, Microsoft.AspNet.Identity.EntityFramework.IdentityRole<string, >, string, CustomUserLogin, CustomUserRole, CustomUserClaim>(new DbContext()));
        //    return new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(createApplicationDbContext() ));
        //}

        public static  ApplicationDbContext createApplicationDbContext()
        {
            ConfigurationBuilder config = new ConfigurationBuilder();
            DbContextOptionsBuilder<ApplicationDbContext> optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(ConnectionString); //IConfiguration.GetConnectionString("DefaultConnection")
            return new ApplicationDbContext(optionsBuilder.Options);
                
        }
    }
}

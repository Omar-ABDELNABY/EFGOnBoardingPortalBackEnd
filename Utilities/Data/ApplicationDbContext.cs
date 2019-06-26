using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Utilities;

namespace Utilities
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Hub> Hubs { get; set; }
        public virtual DbSet<Subhub> SubHubs { get; set; }
        public virtual DbSet<Connection> Connections { get; set; }
        public virtual DbSet<Email> Emails { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{

            //var builder = new ConfigurationBuilder();
            //builder.SetBasePath(Directory.GetCurrentDirectory());
            //builder.AddJsonFile("appsettings.json");
            //IConfiguration Configuration = builder.Build();

            //optionsBuilder.UseSqlServer(
            //    GetConnectionString("DefaultConnection"));
            //base.OnConfiguring(optionsBuilder);
        //}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Connection>().HasOne(c => c.Initiator);
            builder.Entity<Connection>().HasOne(c => c.Client);
            builder.Entity<Connection>().HasOne(c => c.Hub);
            builder.Entity<Connection>().HasOne(c => c.SubHub);


            #region Seed Data
            builder.Entity<IdentityRole>().HasData(
                        new { Id = "1", Name = InitiatorType.Admin.ToString("G"), NormalizedName = InitiatorType.Admin.ToString("G").ToUpper() },
                        new { Id = "2", Name = InitiatorType.Client.ToString("G"), NormalizedName = InitiatorType.Client.ToString("G").ToUpper() },
                        new { Id = "3", Name = InitiatorType.Hub.ToString("G"), NormalizedName = InitiatorType.Hub.ToString("G").ToUpper() },
                        new { Id = "4", Name = InitiatorType.Subhub.ToString("G"), NormalizedName = InitiatorType.Subhub.ToString("G").ToUpper() }
                    );

            var hasher = new PasswordHasher<ApplicationUser>();
            builder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = "1234567890",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@efg.com",
                NormalizedEmail = "ADMIN@EFG.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Efg12#$"),
                SecurityStamp = string.Empty
            });
            builder.Entity<Hub>().HasData(
                        new { ID = 1, Name = "Bloomberg EMSX" },
                        new { ID = 2, Name = "Bloomberg EMSX NET" },
                        new { ID = 3, Name = "Reuters Autex" },
                        new { ID = 4, Name = "Reuters Normal" },
                        new { ID = 5, Name = "Fidessa" }
                    );
            builder.Entity<IdentityUserRole<string>>().HasData(
                    new { UserId = "1234567890", RoleId="1" }    
                );
            #endregion

        }


    }
}

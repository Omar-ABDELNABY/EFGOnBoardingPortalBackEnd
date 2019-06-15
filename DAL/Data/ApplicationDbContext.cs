using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Utilities;

namespace DAL
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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Connection>().HasOne(c => c.Initiator);
            builder.Entity<Connection>().HasOne(c => c.ConnClient);
            builder.Entity<Connection>().HasOne(c => c.ConnHub);
            builder.Entity<Connection>().HasOne(c => c.ConnSubHub);


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
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@efg.com",
                NormalizedEmail = "ADMIN@EFG.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Efg12#$"),
                SecurityStamp = string.Empty
            });
            #endregion

        }


    }
}

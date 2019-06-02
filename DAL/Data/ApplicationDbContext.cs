using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

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
                        new { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
                        new { Id = "2", Name = "Client", NormalizedName = "CLIENT" },
                        new { Id = "3", Name = "Hub", NormalizedName = "HUB" },
                        new { Id = "4", Name = "Subhub", NormalizedName = "SUBHUB" }
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

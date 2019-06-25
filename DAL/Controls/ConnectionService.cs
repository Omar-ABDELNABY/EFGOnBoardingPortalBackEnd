﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DAL.Controls
{
    public  class ConnectionService
    {
        private readonly ApplicationDbContext context;
        private UserManager<ApplicationUser> userManager;
        private SignInManager<ApplicationUser> signInManager;

        public ConnectionService(ApplicationDbContext _context, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            context = _context;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public async Task AddConnection(Connection connection)
        {
            context.Connections.Add(connection);
            await context.SaveChangesAsync();
        }

        public Task<ApplicationUser> GetCurrentUserAsync(string userId)
        {
            return userManager.FindByIdAsync(userId);
        }

        public IEnumerable<Connection> GetConnections()
        {
            return context.Connections;
        }


        public List<Connection> GetUserConnections(string userId)
        {
            var connection = context.Connections.Where(c => c.Initiator.Id == userId && c.Deactivated == false)
             .Include(c => c.Client)
             .Include(c => c.Hub)
             .Include(c => c.SubHub)
             .ToList();
            return connection;
        }


        public async Task<Connection> GetConnection(int id)
        {

           // var claims = User.Claims;
          //  var userId = claims.ToArray()[0].Value;
           

            var connection = await context.Connections.FindAsync(id);



            return connection;
        }



        public async Task PutConnection(int id,  Connection connection)
        {
            
            context.Entry(connection).State = EntityState.Modified;
                await context.SaveChangesAsync();
            
        }


        public async Task<Connection> DeleteConnection( int id)
        {
            var connection = await context.Connections.FindAsync(id);
            if (connection != null)
            {
                connection.Deactivated = true;
                var x = await context.SaveChangesAsync();
            }
            return connection;

        }

       
        public bool ConnectionExists(int id)
        {
            return context.Connections.Any(e => e.ConnectionID == id);
          
        }

    }
}

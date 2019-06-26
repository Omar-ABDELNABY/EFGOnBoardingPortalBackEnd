using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public static class ConnectionService
    {
        //private readonly ApplicationDbContext context;
        //private UserManager<ApplicationUser> userManager;
        //private SignInManager<ApplicationUser> signInManager;

        static ConnectionService()
        {
            //context = _context;
            //this.userManager = userManager;
            //this.signInManager = signInManager;
        }



        public static ApplicationUser GetUserByID(ApplicationDbContext context, string userId)
        {
            return context.Users.Find(userId);

        }

        public static IEnumerable<Connection> GetConnections(ApplicationDbContext context)
        {
            return context.Connections
                .Include(c => c.Client)
                .Include(c => c.Hub)
                .Include(c => c.SubHub)
                .ToList();
        }
        public static IEnumerable<Connection> GetUserConnections(ApplicationDbContext context , string userID)
        {
            return context.Connections.Where(c => c.Initiator.Id == userID)
                .Include(c => c.Client)
                .Include(c => c.Hub)
                .Include(c => c.SubHub)
                .ToList();
        }
        public static Connection GetConnection(ApplicationDbContext context, string userID, int connectionId)
        {
            return context.Connections.FirstOrDefault(c => c.Initiator.Id == userID && c.ConnectionID==connectionId);
        }

        public static async Task PutConnection(ApplicationDbContext context, Connection connection)
        {
            context.Entry(connection).State = EntityState.Modified;
            await context.SaveChangesAsync();

        }
        public static void AddConnection(ApplicationDbContext context, Connection connection)
        {
            //connection.ConnectionID = null;
            context.Connections.Add(connection);
            context.SaveChanges();

        }
        public static async Task<Connection> DeleteConnection(ApplicationDbContext context, int id)
        {
            var connection = await context.Connections.FindAsync(id);
            if (connection != null)
            {
                connection.Deactivated = true;
                await context.SaveChangesAsync();
            }
            return connection;
        }
        public static bool ConnectionExists(ApplicationDbContext context, int id)
        {
            return context.Connections.Any(e => e.ConnectionID == id);

        }







        //public static async Task AddConnection(Connection connection)
        //{
        //    context.Connections.Add(connection);
        //    await context.SaveChangesAsync();
        //}

        //public Task<ApplicationUser> GetCurrentUserAsync(string userId)
        //{
        //    return userManager.FindByIdAsync(userId);
        //}

        //public IEnumerable<Connection> GetConnections()
        //{
        //    return context.Connections;
        //}


        //public IEnumerable<Connection> GetUserConnections(string userId)
        //{
        //    var connection = context.Connections.Where(c => c.Initiator.Id == userId && c.Deactivated == false)
        //     .Include(c => c.Client)
        //     .Include(c => c.Hub)
        //     .Include(c => c.SubHub)
        //     .ToList();
        //    return connection;
        //}


        //public async Task<Connection> GetConnection(int id)
        //{
        //    var connection = await context.Connections.FindAsync(id);
        //    return connection;
        //}



        //public async Task PutConnection(int id, Connection connection)
        //{

        //    context.Entry(connection).State = EntityState.Modified;
        //    await context.SaveChangesAsync();

        //}


        //public async Task<Connection> DeleteConnection(int id)
        //{
        //    var connection = await context.Connections.FindAsync(id);
        //    if (connection != null)
        //    {
        //        connection.Deactivated = true;
        //        var x = await context.SaveChangesAsync();
        //    }
        //    return connection;

        //}


        //public bool ConnectionExists(int id)
        //{
        //    return context.Connections.Any(e => e.ConnectionID == id);

        //}

    }
}

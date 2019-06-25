using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace DAL.Controls
{
    public static class ConnectionService
    {
        public static async Task AddConnection(ApplicationDbContext context,Connection connection)
        {
            context.Connections.Add(connection);
            await context.SaveChangesAsync();
        }

    }
}

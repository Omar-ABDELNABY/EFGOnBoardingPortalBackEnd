using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Utilities;

namespace BLL
{
    public class ConnectionsLogic
    {
        public static IEnumerable<Connection> GetConnections()
        {
            using (ApplicationDbContext context = Contexts.createApplicationDbContext())
            {
                try
                {
                    return DAL.ConnectionService.GetConnections(context);
                }
                catch (Exception ex)
                {
                    //log exception here
                    return null;
                }
            }
        }

        public static IEnumerable<Connection> GetUserConnections(string userId)
        {
            using (ApplicationDbContext context = Contexts.createApplicationDbContext())
            {
                try
                {
                    return DAL.ConnectionService.GetUserConnections(context, userId);
                }
                catch (Exception ex)
                {
                    //log exception here
                    return null;
                }
            }
        }
        public static Connection GetConnection(string userId , int connectionId)
        {
            using (ApplicationDbContext context = Contexts.createApplicationDbContext())
            {
                try
                {
                    return DAL.ConnectionService.GetConnection(context, userId, connectionId);
                }
                catch (Exception ex)
                {
                    //log exception here
                    return null;
                }
            }
        }
        public static async Task<bool> PutConnection(Connection connection)
        {
            using (ApplicationDbContext context = Contexts.createApplicationDbContext())
            {
                try
                {
                    await DAL.ConnectionService.PutConnection(context, connection);
                    return true;
                }
                catch (Exception ex)
                {
                    //log exception here
                    return false;
                }
            }
        }

        public static bool AddConnection(Connection connection)
        {
            using (ApplicationDbContext context = Contexts.createApplicationDbContext())
            {
                //try
                //{
                    DAL.ConnectionService.AddConnection(context, connection);
                    return true;
                //}
                //catch (Exception ex)
                //{
                //    //log exception here
                //    return false;
                //}
            }
        }
        public static async Task<Connection> DeleteConnection(int connectionId)
        {
            using (ApplicationDbContext context = Contexts.createApplicationDbContext())
            {
                try
                {
                    Connection Connection = await DAL.ConnectionService.DeleteConnection(context, connectionId);
                    return Connection;
                }
                catch (Exception ex)
                {
                    //log exception here
                    return null;
                }
            }
        }
        public static bool ConnectionExists(int connectionId)
        {
            using (ApplicationDbContext context = Contexts.createApplicationDbContext())
            {
                try
                {
                    bool result =  DAL.ConnectionService.ConnectionExists(context, connectionId);
                    return result;
                }
                catch (Exception ex)
                {
                    //log exception here
                    return false;
                }
            }
        }

        


    }
}

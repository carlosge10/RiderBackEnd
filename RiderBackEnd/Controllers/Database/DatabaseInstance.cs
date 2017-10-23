using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace RiderBackEnd.Controllers.Database
{
    public class DatabaseInstance
    {
        private static string connectionString;
        public static MongoClient client { get; private set; }
        public static IMongoDatabase db { get; private set; }

        static DatabaseInstance() {
            String connectionString = ConfigurationManager.AppSettings["ConnectionString"];
            client = new MongoClient(connectionString);
            db = client.GetDatabase("riderproto");
        }
    }
}
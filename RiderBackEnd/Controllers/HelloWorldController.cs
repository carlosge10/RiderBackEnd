using MongoDB.Bson;
using MongoDB.Driver;
using RiderBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RiderBackEnd.Controllers
{
    public class HelloWorldController : ApiController
    {
        // GET: api/HelloWorld
        public string Get()
        {
            List<Persona> names = new List<Persona>();

            String connectionString = ConfigurationManager.AppSettings["ConnectionString"];
            MongoClient client = new MongoClient(connectionString);
            IMongoDatabase db = client.GetDatabase("riderproto");
            IMongoCollection<Persona> personas = db.GetCollection<Persona>("HelloMongo");
            Persona p1 = new Persona();
            p1.name = "Damian";
            personas.InsertOne(p1);
            String res = "";
            foreach (Persona p in personas.Find(new BsonDocument()).ToList()) {
                res += p.ToString();
            }
            return res;
        }

        // GET: api/HelloWorld/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/HelloWorld
        public void Post([FromBody]string value)
        {



        }

        // PUT: api/HelloWorld/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/HelloWorld/5
        public void Delete(int id)
        {
        }
    }
}

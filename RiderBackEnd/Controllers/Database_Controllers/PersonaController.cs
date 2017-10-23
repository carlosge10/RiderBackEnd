using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using RiderBackEnd.Controllers.Database;
using MongoDB.Driver;
using RiderBackEnd.Models;
using System.Diagnostics;
using MongoDB.Bson;

namespace RiderBackEnd.Controllers.Database_Controllers
{
    public class PersonaController
    {
        public static bool UpsertPersona(Persona p) {
            IMongoDatabase db = DatabaseInstance.db;
            IMongoCollection<Persona> collection = db.GetCollection<Persona>("Models");
            try
            {
                collection.ReplaceOne(nueva => nueva._id == p._id, p, new UpdateOptions { IsUpsert = true });
            }
            catch (Exception e)
            {
                Debug.Print(e.ToString());
                return false;
            }
            return true;
        }

        internal static Persona GetPersona(string id)
        {
            var db = DatabaseInstance.db;
            var coll = db.GetCollection<Persona>("Models");
            var persona = coll.Find<Persona>(p => p._id == new ObjectId(id)).FirstOrDefault();
            return persona;
        }
    }
}

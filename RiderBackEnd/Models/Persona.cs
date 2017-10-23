using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RiderBackEnd.Models
{
    [BsonDiscriminator("Persona")]
    public class Persona
    {
        public Persona()
        {
        }

        public Persona(ObjectId id, string facebookId, string name, string email, string telephone, GeoPoint home, List<Carro> carros, JObject facebookObject)
        {
            _id = id;
            this.facebookId = facebookId;
            this.name = name;
            this.email = email;
            this.telephone = telephone;
            this.home = home;
            this.carros = carros;
        }

        public ObjectId _id { get; set; }

        public string facebookId { get; set; }

        public string name { get; set; }
        public string imagen { get; set; }
        public string email { get; set; }
        public string telephone { get; set; }
        public GeoPoint home { get; set; }
        public List<Carro> carros { get; set; }
        public JObject facebookObject { get; set; }
    }
}
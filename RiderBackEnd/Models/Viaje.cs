using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RiderBackEnd.Models
{
    [BsonDiscriminator("Viaje")]
    public class Viaje
    {
        public ObjectId _id { get; set; }
        public Persona chofer { set; get; }
        public Carro carro { set; get; }
        public GeoPoint locacionChofer { get; set; }
        public List<PickUpRequest> request { get; set; }
        public List<PickUpRequest> aceptados { get; set; }
        public List<PickUpRequest> rechazados { get; set; }
        public string status { get; set; }
    }
}
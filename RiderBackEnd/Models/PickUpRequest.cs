using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RiderBackEnd.Models
{
    [BsonDiscriminator("PickUp")]
    public class PickUpRequest
    {
        public ObjectId _id { get; set; }
        public string eventId;
        public Persona persona {get; set;}
        public GeoPoint coordenadas { get; set; }
        public DateTime time { get; set; }
        public string status { get; set; }
    }
}
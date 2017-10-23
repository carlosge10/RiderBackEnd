using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Facebook;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json.Linq;

namespace RiderBackEnd.Models
{

    [BsonDiscriminator("Evento")]
    public class Evento
    {
        public Evento(ObjectId objectId, string v1, DateTime dateTime, string v2, object p)
        {
            this._id = objectId;
            this.ciudad = v2;
            this.fecha = dateTime;
            this.nombre = v1;
            this.facebookEvent = (JObject) p;
        }


        public ObjectId _id { get; set; }
        public DateTime fecha { get; set; }
        public string ciudad { get; set; }
        public string nombre { get; set; }
        public JObject facebookEvent { get; set; }
    }
}
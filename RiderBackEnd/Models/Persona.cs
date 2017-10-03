using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RiderBackEnd.Models
{
    public class Persona
    {
        public string name { get; set; }
        public int value { get; set; }

        public ObjectId _id { get; set; }

    }
}
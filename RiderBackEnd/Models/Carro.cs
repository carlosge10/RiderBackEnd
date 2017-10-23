using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RiderBackEnd.Models
{
    public class Carro
    {
        ObjectId _id { get; set; }
        string modelo { get; set; }
        string imageId { get; set; }
        int numberOfSeats { get; set; }
        string placas { get; set; }
        
        public Carro() { }
        
        public Carro(string modelo, string imageId) {
            this.modelo = modelo;
            this.imageId = imageId;
        }
    }
}

using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RiderBackEnd.Models
{
    public class HarcodedObjects
    {
        List<Evento> evt1 = new List<Evento> {
            new Evento(new ObjectId("idevt1"), "MalumaBeibi", DateTime.Today.AddDays(30), "guadaljara", null),
            new Evento(new ObjectId("idevt2"), "Evento2", DateTime.Now.AddDays(30), "zapopann", null)};

        public List<Persona> pp = new List<Models.Persona>{
            new Persona(new ObjectId("idp1:"), "idf1", "Damian", "a@a.a", "11111", null, new List<Carro>{ new Carro("c1", "url1")}, null)
            ,new Persona(new ObjectId("idp2:"), "idf2", "Charly", "b@b.b", "11112", null,  new List<Carro>{ new Carro("c2","url2")}, null)};

        
    }
}
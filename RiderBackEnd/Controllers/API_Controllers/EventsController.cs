using RiderBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RiderBackEnd.Controllers.API_Controllers
{
    public class EventsController : ApiController
    {
        // GET: api/Events
        public IEnumerable<Evento> GetAllEventsForUser(Persona persona)
        {
            return null; 
        }

        // GET: api/Events/5
        public string GetEventForUser(Persona persona)
        {
            return null; 
        }

        // POST
        public void agregarEvento(Evento evt) {

        }

        public void agregarEventos(List<Evento> eventos) {

        }

    }
}

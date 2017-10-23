using RiderBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RiderBackEnd.Controllers.Database;
using RiderBackEnd.Controllers.Database_Controllers;

namespace RiderBackEnd.Controllers.API_Controllers
{
    public class UserController : ApiController
    {
        public void RegistrarVehiculo([FromBody] Persona p,[FromBody] Carro c) {
            if (p != null && c != null)
            {
                if (p.carros == null)
                {
                    p.carros = new List<Csarro>();
                    p.carros.Add(c);
                }
                PersonaController.UpsertPersona(p);
            }
            else
            {
                throw new Exception();
            }
        }
    }
}

using RiderBackEnd.Controllers.Database_Controllers;
using RiderBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RiderBackEnd.Controllers.API_Controllers
{
    public class SignUpController : ApiController
    {

        public Persona Get(string id)
        {
            return PersonaController.GetPersona( id);
        }

        // POST: api/SignUp
        public Persona Post([FromBody]Persona value)
        {
            var completed = PersonaController.UpsertPersona(value);
            if (completed) {
                return value;
            }
            return null;
        }
    }
}

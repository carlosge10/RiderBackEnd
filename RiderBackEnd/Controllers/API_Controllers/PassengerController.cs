using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using RiderBackEnd.Models;

namespace RiderBackEnd.Controllers.API_Controllers
{
    public class PassengerController : ApiController
    {
        public List<Viaje> RequestRide( PickUpRequest pickUp ) {
            return null;
        }

        public void SeleccionarChofer(Viaje viaje, PickUpRequest pickUp) {
            throw new NotImplementedException();
        }
       
    }
}

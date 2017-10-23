using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using RiderBackEnd.Models;

namespace RiderBackEnd.Controllers.API_Controllers
{
    public class ChoferController : ApiController
    {
        void crearViaje(Persona persona, Carro carro, GeoPoint geo) {

        }

        void cancelarViaje(Persona persona, string id) {
        }

        void aceptarPasajero(Persona chofer, PickUpRequest pick) {
        }

        void rechazarPasajero(Persona chofer, PickUpRequest pick) {
        }

        void iniciarViaje(Persona chofer) {
        }

        void terminarViaje(Persona choffer) {
        }

        List<PickUpRequest> PendingRequests(Persona chofer) {
            throw new NotImplementedException();
        }



    }
}

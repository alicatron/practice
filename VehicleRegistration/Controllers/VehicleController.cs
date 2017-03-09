using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using VehicleRegistration.Models;

namespace VehicleRegistration.Controllers
{
    [RoutePrefix("vehicle")]


    public class VehicleRegistrationController : ApiController
    {
        List<Vehicle> vehicles;

        public VehicleRegistrationController()
        {
            vehicles = new List<Vehicle>
                {
                    new Vehicle { Registration = "17D123", Make = "Nissan", Model = "Micra"},
                    new Vehicle { Registration = "11D987", Make = "Opel", Model =  "Astra"},
                    new Vehicle { Registration = "99C654", Make = "Ford", Model = "Focus"},
                    new Vehicle { Registration = "01L7891", Make = "Skoda", Model = "Octavia" },
                    new Vehicle { Registration = "97C0123", Make = "Skoda", Model = "Fabia" },
                };
        }


            [Route("all")]
            [HttpGet]
            public IHttpActionResult GetAllVehicles()
            {
                return Ok(vehicles);
            }

            [Route("registration")]
            [HttpGet]
            public IHttpActionResult OrderByRegistration()
            {
                return Ok(vehicles.OrderBy(v => v.Registration));
            }
        
            [Route("skoda")]
            [HttpGet]
            public IHttpActionResult GetMake()
        {
            return Ok(vehicles.Where(v => v.Make == "Skoda"));
        }        


        }
    }



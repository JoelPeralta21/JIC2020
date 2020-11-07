using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ServiciodeDatos.Model;

namespace API.Controllers
{
    public class HospitalController : ApiController
    {
        PruebaJIC2020Entities bd = new PruebaJIC2020Entities();

        [HttpGet]
        public IEnumerable<Hospital> Get()
        {
            var listado = bd.Hospital.ToList();
            return listado;
        }

        [HttpGet]
        public Hospital Get(int id)
        {
            var hospital = bd.Hospital.FirstOrDefault(x => x.IdHospital == id);
            return hospital;
        }
    }
}

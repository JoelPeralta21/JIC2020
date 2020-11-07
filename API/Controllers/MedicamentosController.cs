using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ServiciodeDatos.Model;

namespace API.Controllers
{
    public class MedicamentosController : ApiController
    {
        PruebaJIC2020Entities bd = new PruebaJIC2020Entities();
        [HttpGet]
        public IEnumerable<Medicamentos> Get()
        {
            var listado = bd.Medicamentos.ToList();
            return listado;
        }

        [HttpGet]
        public Medicamentos Get(int id)
        {
            var medicamentos = bd.Medicamentos.FirstOrDefault(x => x.IdMedicamento == id);
            return medicamentos;
        }
    }
}

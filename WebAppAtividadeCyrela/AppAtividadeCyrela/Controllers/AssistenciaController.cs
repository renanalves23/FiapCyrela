using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AppAtividadeCyrela.Models;
using AppAtividadeCyrela.DAL;

namespace AppAtividadeCyrela.Controllers
{
    public class AssistenciaController : ApiController
    {

        public IHttpActionResult Get() 
        {
            return Ok(new AssistenciaDAL().Listar());
        }

        public IHttpActionResult Get(int id) 
        {
            try
            {
                AssistenciaDAL dal = new AssistenciaDAL();
                Assistencia Assistencia = dal.Consultar(id);
                return Ok(Assistencia);
            }
            catch (KeyNotFoundException) 
            {
                return NotFound();
            }
        }
    }
}

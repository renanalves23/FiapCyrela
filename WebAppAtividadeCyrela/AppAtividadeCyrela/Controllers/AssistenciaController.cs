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

        public IHttpActionResult Post([FromBody] Assistencia Assistencia) 
        {
            try
            {
                AssistenciaDAL dal = new AssistenciaDAL();
                dal.Inserir(Assistencia);

                string location = Url.Link("DefaultApi", new { controller = "assistencia", id = Assistencia.IdAssistencia });

                return Created(new Uri(location), Assistencia);

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        public IHttpActionResult Delete(int id) 
        {
            try
            {
                AssistenciaDAL dal = new AssistenciaDAL();
                dal.Excluir(id);
                return Ok();
            }
            catch (Exception) 
            {
                return BadRequest();
            }
        }

        public IHttpActionResult Put([FromBody] Assistencia assistencia) 
        {
            try
            {
                AssistenciaDAL dal = new AssistenciaDAL();
                dal.Alterar(assistencia);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}

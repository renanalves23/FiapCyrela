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
    public class OcorrenciaController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok(new OcorrenciaDAL().Listar());
        }

        public IHttpActionResult Get(int id)
        {
            try
            {
                OcorrenciaDAL dal = new OcorrenciaDAL();
                Ocorrencia ocorrencia = dal.Consultar(id);
                return Ok(ocorrencia);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }

        public IHttpActionResult Post([FromBody] Ocorrencia Ocorrencia)
        {
            try
            {
                OcorrenciaDAL dal = new OcorrenciaDAL();
                dal.Inserir(Ocorrencia);

                string location = Url.Link("DefaultApi", new { controller = "ocorrencia", id = Ocorrencia.numeroTicket });

                return Created(new Uri(location), Ocorrencia);

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
                OcorrenciaDAL dal = new OcorrenciaDAL();
                dal.Excluir(id);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        public IHttpActionResult Put([FromBody] Ocorrencia ocorrencia)
        {
            try
            {
                OcorrenciaDAL dal = new OcorrenciaDAL();
                dal.Alterar(ocorrencia);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}

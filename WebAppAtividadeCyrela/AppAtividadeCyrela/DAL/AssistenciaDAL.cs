using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppAtividadeCyrela.Models;

namespace AppAtividadeCyrela.DAL
{
    public class AssistenciaDAL
    {

        private static Dictionary<long, Assistencia> bancoAssistencia = new Dictionary<long, Assistencia>();
        private static int contadorBanco = 2;

        static AssistenciaDAL() 
        {
            Assistencia tecnico = new Assistencia();
            tecnico.IdAssistencia = 1;
            tecnico.IdBloco = 2;
            tecnico.IdEmpreendimento = 30;
            tecnico.IdUnidade = 23;
            tecnico.TipoAtividade = "Assistencia Técnica";
            tecnico.AtividadeIni = DateTime.Now;
            tecnico.AtividadeFim = DateTime.Now.AddHours(1);
            tecnico.Assunto = "TV a Cabo";

            bancoAssistencia.Add(1, tecnico);
        }

        public void Inserir(Assistencia assistencia) 
        {
            contadorBanco++;
            assistencia.IdAssistencia = contadorBanco;
            bancoAssistencia.Add(contadorBanco, assistencia);
        }        

        public Assistencia Consultar(int IdAssistencia) 
        {
            return bancoAssistencia[IdAssistencia];
        }

        public IList<Assistencia> Listar() 
        {
            return new List<Assistencia>(bancoAssistencia.Values);
        }

        public void Excluir(int IdAssistencia) 
        {
            bancoAssistencia.Remove(IdAssistencia);
        }

        public void Alterar(Assistencia assistencia) 
        {
            bancoAssistencia[assistencia.IdAssistencia] = assistencia;
        }
    }
}
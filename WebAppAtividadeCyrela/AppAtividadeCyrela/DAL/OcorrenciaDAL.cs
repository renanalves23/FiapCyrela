using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppAtividadeCyrela.Models;

namespace AppAtividadeCyrela.DAL
{
    public class OcorrenciaDAL
    {
        private static Dictionary<long, Ocorrencia> bancoOcorrencia = new Dictionary<long, Ocorrencia>();
        private static int contadorBanco = 2;

        static OcorrenciaDAL()
        {
            Ocorrencia ocorrencia = new Ocorrencia();
            ocorrencia.numeroTicket = 1;
            ocorrencia.IdBloco = 2;
            ocorrencia.IdEmpreendimento = 30;
            ocorrencia.IdUnidade = 23;
            ocorrencia.idCliente = 5;
            ocorrencia.Descricao = "Cano Estourado";
            ocorrencia.Bandeira = 3;

            bancoOcorrencia.Add(1, ocorrencia);
        }

        public void Inserir(Ocorrencia ocorrencia)
        {
            contadorBanco++;
            ocorrencia.numeroTicket = contadorBanco;
            bancoOcorrencia.Add(contadorBanco, ocorrencia);
        }

        public Ocorrencia Consultar(int numeroTicket)
        {
            return bancoOcorrencia[numeroTicket];
        }

        public IList<Ocorrencia> Listar()
        {
            return new List<Ocorrencia>(bancoOcorrencia.Values);
        }

        public void Excluir(int numeroTicket)
        {
            bancoOcorrencia.Remove(numeroTicket);
        }

        public void Alterar(Ocorrencia ocorrencia)
        {
            bancoOcorrencia[ocorrencia.numeroTicket] = ocorrencia;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppAtividadeCyrela.Models
{
    public class Ocorrencia
    {
        public int numeroTicket { get; set; }
        public int idCliente { get; set; }        
        public int IdEmpreendimento { get; set; }
        public int IdBloco { get; set; }
        public int IdUnidade { get; set; }
        public int Bandeira { get; set; }
        public string Descricao { get; set; }

        public Ocorrencia() { }

        public Ocorrencia(int Ticket, int Cliente, int Empreendimento, int Bloco, int Unidade, int Bandeira, string Descricao) 
        {
            numeroTicket = Ticket;
            idCliente = Cliente;
            IdEmpreendimento = Empreendimento;
            IdBloco = Bloco;
            IdUnidade = Unidade;
            this.Bandeira = Bandeira;
            this.Descricao = Descricao;

        }
    }
}
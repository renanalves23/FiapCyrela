using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppAtividadeCyrela.Models
{
    public class Assistencia
    {
        public DateTime AtividadeIni{ get; set; }
        public DateTime AtividadeFim { get; set; }
        public string TipoAtividade { get; set; }
        public string Assunto { get; set; }
        public int IdEmpreendimento { get; set; }
        public int IdBloco { get; set; }
        public int IdUnidade { get; set; }
        public int IdAssistencia { get; set; }

        public Assistencia() { }

        public Assistencia(DateTime Inicio, DateTime Fim, string Tipo, string Assunto, int Empreendimento, int Bloco, int Unidade, int Atividade)
        {
            AtividadeIni = Inicio;
            AtividadeFim = Fim;
            TipoAtividade = Tipo;
            this.Assunto = Assunto;
            IdEmpreendimento = Empreendimento;
            IdBloco = Bloco;
            IdUnidade = Unidade;
            IdAssistencia = Atividade;
            
        }

    }
}
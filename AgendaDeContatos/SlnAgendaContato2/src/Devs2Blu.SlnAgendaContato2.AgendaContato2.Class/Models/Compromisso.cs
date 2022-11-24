using Devs2Blu.SlnAgendaContato2.AgendaContato2.Class.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.SlnAgendaContato2.AgendaContato2.Class.Models
{
    public class Compromisso
    {
        public int Id { get; set; }
        public Contato Contato { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataIni { get; set; }
        public DateTime DataFim { get; set; }
        public StatusEnum Status { get; set; }

        public Compromisso()
        {
            Contato = new Contato();
        }

        public Compromisso(int id, Contato contato, string titulo, string descricao, DateTime dataIni, DateTime dataFim, StatusEnum status)
        {
            Id = id;
            Contato = contato;
            Titulo = titulo;
            Descricao = descricao;
            DataIni = dataIni;
            DataFim = dataFim;
            Status = status;
        }
    }
}

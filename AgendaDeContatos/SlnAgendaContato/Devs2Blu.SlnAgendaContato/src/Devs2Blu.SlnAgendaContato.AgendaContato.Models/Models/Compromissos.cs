using Devs2Blu.SlnAgendaContato.AgendaContato.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.SlnAgendaContato.AgendaContato.Models.Models
{
    public class Compromissos
    {
        public Int32 IdContato { get; set; }
        public Int32 Id { get; set; }
        public String Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public DiasSemana DiasSemana { get; set; }
        public FlStatus FlStatus  { get; set; }
       
        public Compromissos() { }

        public Compromissos(int idContato, int id, string descricao, DateTime dataInicio, DateTime dataFim, DiasSemana diasSemana, FlStatus flStatus)
        {
            IdContato = idContato;
            Id = id;
            Descricao = descricao;
            DataInicio = dataInicio;
            DataFim = dataFim;
            DiasSemana = diasSemana;
            FlStatus = flStatus;
            
        }
    }
    

}

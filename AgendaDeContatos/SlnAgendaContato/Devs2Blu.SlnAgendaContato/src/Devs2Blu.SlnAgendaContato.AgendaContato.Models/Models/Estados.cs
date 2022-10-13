using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.SlnAgendaContato.AgendaContato.Models.Models
{
    public class Estados
    {

        public Int32 Id { get; set; }
        public String UF { get; set; }
        public String Nome { get; set; }

        public Estados() {}

        public Estados(int id, string uF, string nome)
        {
            Id = id;
            UF = uF;
            Nome = nome;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.SlnAgendaContato2.AgendaContato2.Class.Enum
{
    public enum StatusEnum
    {
        [Description("Inativo")]
        I,
        [Description("Ativo")]
        A,
        [Description("Concluído")]
        C,
        [Description("Remarcado")]
        R
    }
}

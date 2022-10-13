using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.SlnAgendaContato.AgendaContato.Models.Enum
{
    public enum FlStatus
    {
        [Description("Marcado")]
        M = 0,
        [Description("Desmarcado")]
        D = 1,
        [Description("Remarcado")]
        R = 2,
        [Description("Concluído")]
        C = 3
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.SlnAgendaContato.AgendaContato.Models.Enum
{
    public enum DiasSemana
    {
        [Description("Domingo")]
        DOM = 0,
        [Description("Segunda")]
        SEG = 1,
        [Description("Terça")]
        TER = 3,
        [Description("Quarta")]
        QUA = 4,
        [Description("Quinta")]
        QUI = 5,
        [Description("Sexta")]
        SEX = 6,
        [Description("Sábado")]
        SAB = 7,
    }
}

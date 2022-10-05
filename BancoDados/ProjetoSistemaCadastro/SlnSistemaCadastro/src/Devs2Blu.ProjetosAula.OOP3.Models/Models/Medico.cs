using System;
using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Enum;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Models.Models
{
    public class Medico: Pessoa
    {
        public Int32 Id { get; set; }
        public Int32 CRM { get; set; }
        public String Especialidade { get; set; }

        public Medico()
        {
            TipoPessoa = TipoPessoa.PF;
        }
    }
}

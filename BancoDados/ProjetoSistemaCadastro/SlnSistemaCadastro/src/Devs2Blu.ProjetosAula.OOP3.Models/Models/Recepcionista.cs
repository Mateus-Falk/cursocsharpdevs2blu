using System;
using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Enum;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Models.Models
{
    public class Recepcionista
    {
        public Int32 Id { get; set; }
        public String Setor { get; set; }

        public Recepcionista()
        {
            TipoPessoa = TipoPessoa.PF;
        }
  
    }
}

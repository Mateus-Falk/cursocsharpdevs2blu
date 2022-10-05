using System;
using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Enum;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Models.Models
{
    public class Fornecedor : Pessoa
    {
        public Int32 Id { get; set; }
        public String TipoFornecedor { get; set; }

        public Fornecedor()
        {
            TipoPessoa = TipoPessoa.PJ;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.SlnAgendaContato2.AgendaContato2.Class.Models
{
    public class Endereco
    {
        public Int32 Id { get; set; }
        public String CEP { get; set; }
        public String Rua { get; set; }
        public Int32 Numero { get; set; }
        public String Bairro { get; set; }
        public String Cidade { get; set; }
        public Estados Estados { get; set; }


        public Endereco()
        {
            Estados = new Estados();
        }

        public Endereco(int id, string cEP, string rua, int numero, string bairro, string cidade, Estados estados)
        {
            Id = id;
            CEP = cEP;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estados = estados;
        }
    }
}

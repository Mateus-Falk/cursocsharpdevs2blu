using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.AulaPOO2Class
{
    public class Contato
    {
        public string Nome { get; set; }
        public string TelCel { get; set; }
        public string Email { get; set; }

        public string CEP { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public Contato() { }
        public Contato(string nome, string telCel, string email)
        {
            Nome = nome;
            TelCel = telCel;
            Email = email;
        }
    }

}

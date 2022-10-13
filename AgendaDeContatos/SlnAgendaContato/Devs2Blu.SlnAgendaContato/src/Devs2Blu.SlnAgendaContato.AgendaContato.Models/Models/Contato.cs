using Devs2Blu.SlnAgendaContato.AgendaContato.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.SlnAgendaContato.AgendaContato.Models
{
    public class Contato
    {
        public Int32 Id { get; set; }
        public String Nome { get; set; }
        public String Telefone1 { get; set; }
        public String Telefone2 { get; set; }
        public String Email { get; set; }
        public Endereco Endereco { get; set; }
        public Contato()
        {
            Endereco = new Endereco();
        }

        public Contato(int id, string nome, string telefone1, string telefone2, string email, Endereco endereco)
        {
            Id = id;
            Nome = nome;
            Telefone1 = telefone1;
            Telefone2 = telefone2;
            Email = email;
            Endereco = endereco;
        }
    }
}

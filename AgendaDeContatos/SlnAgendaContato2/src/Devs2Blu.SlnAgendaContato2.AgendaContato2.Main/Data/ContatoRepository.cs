using Devs2Blu.SlnAgendaContato2.AgendaContato2.Class.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.SlnAgendaContato2.AgendaContato2.Main.Data
{
    public class ContatoRepository : BaseRepository
    {
        public ContatoRepository() : base("contatos")
        {

        }

        public Contato FindById(int id)
        {
            Contato contato = new Contato();
            var r = base.FindById(id);
            while (r.Read())
            {
                contato = new Contato(r.GetInt32("id"), r.GetString("nome"), r.GetString("telefone"), r.GetString("celular"), r.GetString("email"), r.GetString("rua"), r.GetInt32("numero"), r.GetString("bairro"), r.GetString("cidade"), r.GetString("uf"), GetStatus(r.GetString("status")));
            }

            return contato;
        }
        public List<Contato> GetContatosCbo()
        {
            List<Contato> listContato = new List<Contato>();
            Contato itemzero = new Contato(0, "Selecione...");
            listContato.Add(itemzero);

            var rdr = base.Get(SQL_CONTATOS_CBO);
            while (rdr.Read())
            {
                Contato contato = new Contato(rdr.GetInt32("id"), rdr.GetString("Nome"));
                listContato.Add(contato);
            }
         
            return listContato;
        }
        const string SQL_CONTATOS_CBO ="SELECT id, concat(nome, '(', telefone,')') as nome from contatos";
            
    }
}

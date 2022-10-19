using Devs2Blu.SlnAgendaContato2.AgendaContato2.Class.Enum;
using Devs2Blu.SlnAgendaContato2.AgendaContato2.Class.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.SlnAgendaContato2.AgendaContato2.Main.Data
{
    public class CompromissoRepository : BaseRepository
    {
        public CompromissoRepository () : base("compromissos")
        {

        }
        public Compromisso FindById(int id)
        {
            Compromisso compromisso = new Compromisso ();
            var r = base.FindById(id);
            while (r.Read())
            {

            }
            return compromisso;
        }
        public List<Compromisso> GetCompromissoGrid()
        {
            List<Compromisso> listCompromisso = new List<Compromisso> ();
            Contato contato = new Contato();

            var rdr = base.Get(SQL_COMPROMISSOS_CONTATO);

            while (rdr.Read())
            {
                if (rdr.GetInt32("id_contato") > 0)
                {
                    contato.Id = rdr.GetInt32("id_contato");
                    contato.Nome = rdr.GetString("nome");
                }
                Compromisso compromisso = new Compromisso(rdr.GetInt32("id"), contato, rdr.GetString("titulo"), rdr.GetString("descricao"), rdr.GetDateTime("dataini"), rdr.GetDateTime("datafim"), (rdr.GetString("status").Equals("A")) ? StatusEnum.A : StatusEnum.I);
                listCompromisso.Add(compromisso);
            }
            return listCompromisso;
        }

        #region SQLs
        const string SQL_COMPROMISSOS_CONTATO = @"select cm.id,
                case isnull(cm.contatos_id)
                        When 1 then 0 else cm.contatos_id end as id_contato,
                case isnull(cn.nome)
                        When 1 then '' else cn.nome end as nome,
                cm.titulo,
                cm.descricao,
                cm.dataini,
                cm.datafim,
                cm.status
from compromissos cm
left join contatos cn
        on cn.id = cm.contatos_id";
        #endregion
    }
}

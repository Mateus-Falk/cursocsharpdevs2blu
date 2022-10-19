using Devs2Blu.SlnAgendaContato.AgendaContato.Models;
using Devs2Blu.SlnAgendaContato.AgendaContato.Models.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.SlnAgendaContato.AgendaContato.Main.Data
{
    public class CompromissosRepository
    {
        #region Methods
        public Compromissos Save(Compromissos compromissos, MySqlConnection conn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_COMPROMISSOS, conn);
                cmd.Parameters.Add("@id_contatos", MySqlDbType.Int32).Value = compromissos.IdContato;
                cmd.Parameters.Add("@descricao", MySqlDbType.VarChar, 200).Value = compromissos.Descricao;
                cmd.Parameters.Add("@dia_semana", MySqlDbType.Enum).Value = compromissos.DiasSemana;
                cmd.Parameters.Add("@data_ini", MySqlDbType.DateTime).Value = compromissos.DataInicio;
                cmd.Parameters.Add("@data_fim", MySqlDbType.DateTime).Value = compromissos.DataFim;
               
                cmd.ExecuteNonQuery();
                return compromissos;
            }
            catch (Exception myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public Compromissos UpdateRemarcar(Compromissos compromissos)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_UPDATE_COMPROMISSOS_REMARCAR);
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = compromissos.Id;
                cmd.Parameters.Add("@dia_semana", MySqlDbType.Enum).Value = compromissos.DiasSemana;
                cmd.Parameters.Add("@data_ini", MySqlDbType.DateTime).Value = compromissos.DataInicio;
                cmd.Parameters.Add("@data_fim", MySqlDbType.DateTime).Value = compromissos.DataFim;
 
                cmd.ExecuteNonQuery();
                return compromissos;
            }
            catch (Exception myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public Compromissos UpdateDesmarcar(Compromissos compromissos)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_UPDATE_COMPROMISSOS_DESMARCAR);
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = compromissos.Id;

                cmd.ExecuteNonQuery();
                return compromissos;
            }
            catch (Exception myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public Compromissos UpdateConcluido(Compromissos compromissos)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_UPDATE_COMPROMISSOS_CONCLUIDO);
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = compromissos.Id;

                cmd.ExecuteNonQuery();
                return compromissos;
            }
            catch (Exception myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        #endregion
        #region SQLS
        private const String SQL_INSERT_COMPROMISSOS = @"INSERT INTO compromissos 
(id_contatos,
descricao,
dia_semana,
data_ini,
data_fim,
flstatus)
VALUES 
(@id_contatos,
@descricao,
@dia_semana,
@data_ini,
@data_fim,
'M')";
        private const String SQL_UPDATE_COMPROMISSOS_REMARCAR = @"UPDATE compromissos
SET dia_semana = @dia_semana,
data_ini = @data_ini,
data_fim = @data_fim,
flstatus = 'R'
WHERE id = @id";
        private const String SQL_UPDATE_COMPROMISSOS_DESMARCAR = @"UPDATE compromissos
SET flstatus = 'D'
WHERE id = @id";
        private const String SQL_UPDATE_COMPROMISSOS_CONCLUIDO = @"UPDATE compromissos
SET flstatus = 'C'
WHERE id = @id";
        #endregion
    }

}

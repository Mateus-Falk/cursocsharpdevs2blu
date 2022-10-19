using Devs2Blu.SlnAgendaContato.AgendaContato.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.SlnAgendaContato.AgendaContato.Main.Data
{
    public class ContatoRepository
    {
        #region Methods
        public Int32 Save(Contato contato, MySqlConnection conn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_CONTATOS, conn);
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = contato.Nome;
                cmd.Parameters.Add("@telefone1", MySqlDbType.VarChar, 20).Value = contato.Telefone1;
                cmd.Parameters.Add("@telefone2", MySqlDbType.VarChar, 20).Value = contato.Telefone2;
                cmd.Parameters.Add("@email", MySqlDbType.VarChar, 50).Value = contato.Email;

                cmd.ExecuteNonQuery();
                return (Int32)cmd.LastInsertedId;
            }
            catch (Exception myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public void Update(Contato contato, MySqlConnection conn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_UPDATE_CONTATOS, conn);
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = contato.Id;
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = contato.Nome;
                cmd.Parameters.Add("@telefone1", MySqlDbType.VarChar, 20).Value = contato.Telefone1;
                cmd.Parameters.Add("@telefone2", MySqlDbType.VarChar, 20).Value = contato.Telefone2;
                cmd.Parameters.Add("@email", MySqlDbType.VarChar, 50).Value = contato.Email;

                cmd.ExecuteNonQuery();
            }
            catch (Exception myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public void Exclui(Contato contato, MySqlConnection conn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_DELETE_CONTATOS, conn);
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = contato.Id;

                cmd.ExecuteNonQuery();
            }
            catch (Exception myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        #endregion
        #region SQLS
        private const String SQL_INSERT_CONTATOS = @"INSERT INTO contatos 
(nome,
telefone1,
telefone2,
email)
VALUES 
(@nome,
@telefone1,
@telefone2,
@email)";
        private const String SQL_UPDATE_CONTATOS = @"UPDATE contatos 
SET nome = @nome,
telefone1 = @telefone1,
telefone2 = @telefone2,
email = @email
WHERE id = @id";
        private const String SQL_DELETE_CONTATOS = @"DELETE FROM contatos
WHERE id = @id";
        #endregion
    }
}

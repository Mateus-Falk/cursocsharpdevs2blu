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
    public class EnderecoRepository
    {
        #region Methods
        public void Save(Contato contato, MySqlConnection conn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_ENDERECO, conn);
                cmd.Parameters.Add("@id_contatos", MySqlDbType.Int32).Value = contato.Id;
                cmd.Parameters.Add("@cep", MySqlDbType.VarChar, 15).Value = contato.Endereco.CEP;
                cmd.Parameters.Add("@rua", MySqlDbType.VarChar, 50).Value = contato.Endereco.Rua;
                cmd.Parameters.Add("@numero", MySqlDbType.Int32).Value = contato.Endereco.Numero;
                cmd.Parameters.Add("@bairro", MySqlDbType.VarChar, 50).Value = contato.Endereco.Bairro;
                cmd.Parameters.Add("@cidade", MySqlDbType.VarChar, 50).Value = contato.Endereco.Cidade;
                cmd.Parameters.Add("@id_estados", MySqlDbType.Int32).Value = contato.Endereco.Estados.Id;

                cmd.ExecuteNonQuery();
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
                MySqlCommand cmd = new MySqlCommand(SQL_UPDATE_ENDERECO, conn);
                cmd.Parameters.Add("@id_contatos", MySqlDbType.Int32).Value = contato.Id;
                cmd.Parameters.Add("@cep", MySqlDbType.VarChar, 15).Value = contato.Endereco.CEP;
                cmd.Parameters.Add("@rua", MySqlDbType.VarChar,50).Value = contato.Endereco.Rua;
                cmd.Parameters.Add("@numero", MySqlDbType.Int32).Value = contato.Endereco.Numero;
                cmd.Parameters.Add("@bairro", MySqlDbType.VarChar, 50).Value = contato.Endereco.Bairro;
                cmd.Parameters.Add("@cidade", MySqlDbType.VarChar, 50).Value = contato.Endereco.Cidade;
                cmd.Parameters.Add("@id_estados", MySqlDbType.Int32).Value = contato.Endereco.Estados.Id;

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
                MySqlCommand cmd = new MySqlCommand(SQL_DELETE_ENDERECO, conn);
                cmd.Parameters.Add("@id_contatos", MySqlDbType.Int32).Value = contato.Id;

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
        private const String SQL_INSERT_ENDERECO = @"INSERT INTO endereco 
(id_contatos,
cep,
rua,
numero,
bairro,
cidade,
id_estados)
VALUES
(@id_contatos,
@cep,
@rua,
@numero,
@bairro,
@cidade,
@id_estados)";
        private const String SQL_UPDATE_ENDERECO = @"UPDATE endereco 
SET id_contatos = @id_contatos,
cep = @cep,
rua = @rua,
numero = @numero,
bairro = @bairro,
cidade = @cidade,
id_estados = @id_estados
WHERE id_contatos = id_contatos";
        private const String SQL_DELETE_ENDERECO = @"DELETE FROM endereco
WHERE id_contatos = @id_contatos";
        #endregion
    }
}

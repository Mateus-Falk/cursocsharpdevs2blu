using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms.Data
{
    public class PacienteRepository
    {
        #region Inserts
        public Paciente Save(Paciente paciente)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {

                paciente.Pessoa.Id = SavePessoa(paciente, conn);
                SavePaciente(paciente, conn);
                SaveEndereco(paciente, conn);

                return paciente;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private Int32 SavePessoa(Paciente paciente, MySqlConnection conn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_PESSOA, conn);
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = paciente.Pessoa.Nome;
                cmd.Parameters.Add("@cgccpf", MySqlDbType.VarChar, 25).Value = paciente.Pessoa.CGCCPF;
                cmd.Parameters.Add("@tipopessoa", MySqlDbType.Enum).Value = paciente.Pessoa.TipoPessoa;

                cmd.ExecuteNonQuery();
                return (Int32)cmd.LastInsertedId;
            }
            catch (Exception myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private void SavePaciente(Paciente paciente, MySqlConnection conn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_PACIENTE, conn);
                cmd.Parameters.Add("@id_pessoa", MySqlDbType.Int32).Value = paciente.Pessoa.Id;
                cmd.Parameters.Add("@id_convenio", MySqlDbType.Int32).Value = paciente.Convenio.Id;
                cmd.Parameters.Add("@numero_prontuario", MySqlDbType.Enum).Value = paciente.NrProntuario;
                cmd.Parameters.Add("@paciente_risco", MySqlDbType.VarChar, 5).Value = paciente.PacienteRisco;

                cmd.ExecuteNonQuery();
            }
            catch (Exception myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private void SaveEndereco(Paciente paciente, MySqlConnection conn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_ENDERECO, conn);
                cmd.Parameters.Add("@idPessoa", MySqlDbType.Int32).Value = paciente.Pessoa.Id;
                cmd.Parameters.Add("@CEP", MySqlDbType.VarChar, 15).Value = paciente.Endereco.CEP;
                cmd.Parameters.Add("@rua", MySqlDbType.VarChar, 45).Value = paciente.Endereco.Rua;
                cmd.Parameters.Add("@numero", MySqlDbType.Int32).Value = paciente.Endereco.Numero;
                cmd.Parameters.Add("@bairro", MySqlDbType.VarChar, 45).Value = paciente.Endereco.Bairro;
                cmd.Parameters.Add("@cidade", MySqlDbType.VarChar, 45).Value = paciente.Endereco.Cidade;
                cmd.Parameters.Add("@uf", MySqlDbType.VarChar, 2).Value = paciente.Endereco.UF;

                cmd.ExecuteNonQuery();
            }
            catch (Exception myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        #endregion
        #region Deletes
        public int Exclui(Paciente paciente)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                ExcluiPaciente(paciente, conn);
                ExcluiEndereco(paciente, conn);
                ExcluiPessoa(paciente, conn);
                return 0;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private void ExcluiPaciente(Paciente paciente, MySqlConnection conn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_DELETE_PACIENTE, conn);
                cmd.Parameters.Add("@id_pessoa", MySqlDbType.Int32).Value = paciente.Pessoa.Id;

                cmd.ExecuteNonQuery();
            }
            catch (Exception myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private void ExcluiPessoa(Paciente paciente, MySqlConnection conn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_DELETE_PESSOA, conn);
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = paciente.Pessoa.Id;
               
                cmd.ExecuteNonQuery();
            }
            catch (Exception myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private void ExcluiEndereco(Paciente paciente, MySqlConnection conn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_DELETE_ENDERECO, conn);
                cmd.Parameters.Add("@id_pessoa", MySqlDbType.Int32).Value = paciente.Pessoa.Id;

                cmd.ExecuteNonQuery();
            }
            catch (Exception myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        #endregion

        #region Updates
        public Paciente Update(Paciente paciente)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                UpdatePessoa(paciente, conn);
                UpdatePaciente(paciente, conn);
                UpdateEndereco(paciente, conn);
                return paciente;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private void UpdatePaciente(Paciente paciente, MySqlConnection conn) 
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_UPDATE_PACIENTE, conn);
                cmd.Parameters.Add("@id_pessoa", MySqlDbType.Int32).Value = paciente.Pessoa.Id;
                cmd.Parameters.Add("@id_convenio", MySqlDbType.Int32).Value = paciente.Convenio.Id;
                cmd.Parameters.Add("@numero_prontuario", MySqlDbType.Enum).Value = paciente.NrProntuario;
                cmd.Parameters.Add("@paciente_risco", MySqlDbType.VarChar, 5).Value = paciente.PacienteRisco;

                cmd.ExecuteNonQuery();
            }
            catch (Exception myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private void UpdatePessoa(Paciente paciente, MySqlConnection conn) 
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_UPDATE_PESSOA, conn);
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = paciente.Pessoa.Id;
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = paciente.Pessoa.Nome;
                cmd.Parameters.Add("@cgccpf", MySqlDbType.VarChar, 25).Value = paciente.Pessoa.CGCCPF;
                cmd.Parameters.Add("@tipopessoa", MySqlDbType.Enum).Value = paciente.Pessoa.TipoPessoa;

                cmd.ExecuteNonQuery();
            }
            catch (Exception myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private void UpdateEndereco(Paciente paciente, MySqlConnection conn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_UPDATE_ENDERECO, conn);
                cmd.Parameters.Add("@id_pessoa", MySqlDbType.Int32).Value = paciente.Pessoa.Id;
                cmd.Parameters.Add("@CEP", MySqlDbType.VarChar, 15).Value = paciente.Endereco.CEP;
                cmd.Parameters.Add("@rua", MySqlDbType.VarChar, 45).Value = paciente.Endereco.Rua;
                cmd.Parameters.Add("@numero", MySqlDbType.Int32).Value = paciente.Endereco.Numero;
                cmd.Parameters.Add("@bairro", MySqlDbType.VarChar, 45).Value = paciente.Endereco.Bairro;
                cmd.Parameters.Add("@cidade", MySqlDbType.VarChar, 45).Value = paciente.Endereco.Cidade;
                cmd.Parameters.Add("@uf", MySqlDbType.VarChar, 2).Value = paciente.Endereco.UF;

                cmd.ExecuteNonQuery();
            }
            catch (Exception myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        #endregion

        internal MySqlDataReader GetPessoas()
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_PESSOAS, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                return dataReader;
            }
            catch (Exception myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        #region SQLS
        private const String SQL_INSERT_PESSOA = @"INSERT INTO pessoa 
(nome,
cgccpf,
tipopessoa,
flstatus)
VALUES 
(@nome,
@cgccpf,
@tipopessoa,
'A')";
        private const String SQL_INSERT_ENDERECO = @"INSERT INTO endereco 
(id_pessoa,
CEP,
rua,
numero,
bairro,
cidade,
uf)
VALUES 
(@idPessoa,
@CEP,
@rua,
@numero,
@bairro,
@cidade,
@uf)";
        private const String SQL_INSERT_PACIENTE = @"INSERT INTO paciente 
(id_pessoa,
id_convenio,
numero_prontuario,
paciente_risco,
flstatus,
flobito)
VALUES 
(@id_pessoa,
@id_convenio,
@numero_prontuario,
@paciente_risco,
'A',
0
)";
        
        private const String SQL_SELECT_PESSOAS = @"SELECT id,
nome, 
cgccpf, 
flstatus 
from pessoa";
        
        private const String SQL_UPDATE_PESSOA = @"UPDATE pessoa 
SET nome = @nome,
cgccpf = @cgccpf,
tipopessoa = @tipopessoa,
flstatus = 'A'
where id = @id";
        private const String SQL_UPDATE_PACIENTE = @"UPDATE paciente
SET id_pessoa = @id_pessoa,
id_convenio = @id_convenio,
numero_prontuario = @numero_prontuario,
paciente_risco = @paciente_risco,
flstatus = 'A',
flobito = 0
where id_pessoa = @id_pessoa";
        private const String SQL_UPDATE_ENDERECO = @"UPDATE endereco 
SET id_pessoa = @id_pessoa,
CEP = @cep,
rua = @rua,
numero = @numero,
bairro = @bairro,
cidade = @cidade,
uf = @uf
where id_pessoa = @id_pessoa";

        private const String SQL_DELETE_PESSOA = @"DELETE FROM pessoa
WHERE id = @id";
        private const String SQL_DELETE_ENDERECO = @"DELETE FROM endereco
WHERE id_pessoa = @id_pessoa";
        private const String SQL_DELETE_PACIENTE = @"DELETE FROM paciente
WHERE id_pessoa = @id_pessoa";
        #endregion
    }
}

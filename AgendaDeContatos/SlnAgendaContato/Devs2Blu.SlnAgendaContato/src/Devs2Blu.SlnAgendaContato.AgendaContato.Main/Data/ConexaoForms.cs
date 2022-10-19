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
    public class ConexaoForms
    {
        public EnderecoRepository EnderecoRepository = new EnderecoRepository();
        public ContatoRepository ContatoRepository = new ContatoRepository();
        #region Methods
        public Contato Save(Contato contato)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                contato.Id = ContatoRepository.Save(contato, conn);
                EnderecoRepository.Save(contato, conn);

                return contato;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public Contato Update(Contato contato)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                ContatoRepository.Update(contato, conn);
                EnderecoRepository.Update(contato, conn);
                return contato;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public int Exclui(Contato contato)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                EnderecoRepository.Exclui(contato, conn);
                ContatoRepository.Exclui(contato, conn);
                return 0;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        #endregion
        #region Get
        internal MySqlDataReader GetContatos()
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_CONTATOS, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                return dataReader;
            }
            catch (Exception myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        internal MySqlDataReader GetCompromissos()
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_COMPROMISSOS, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                return dataReader;
            }
            catch (Exception myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public MySqlDataReader GetContatoById(int idContato)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_CONTATOS_BY_ID, conn);
                cmd.Parameters.Add("@id",MySqlDbType.Int32).Value = idContato;
                MySqlDataReader dataReader = cmd.ExecuteReader();
                return dataReader;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public MySqlDataReader GetCompromissoById(int idCompromisso)
        {
            
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_COMPROMISSOS_BY_ID, conn);
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = idCompromisso;
                MySqlDataReader dataReader = cmd.ExecuteReader();
                return dataReader;
            }
            catch (MySqlException MyExc)
            {
                MessageBox.Show(MyExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        #endregion
        #region SQLS
        private const String SQL_SELECT_CONTATOS = @"SELECT c.id Código,
c.nome Nome,
c.telefone1 Telefone,
c.telefone2 Telefone_Reserva,
c.email Email,
en.cep CEP,
en.rua Rua,
en.numero Numero,
en.bairro Bairro,
en.cidade Cidade,
es.nome Estado
FROM contatos c
JOIN endereco en ON en.id_contatos = c.id
JOIN estados es ON es.id = en.id_estados";
        private const String SQL_SELECT_COMPROMISSOS = @"SELECT cp.id Código,
ct.nome Contato,
cp.descricao Descrição,
cp.dia_semana Dia_da_Semana,
cp.flstatus Status,
cp.data_ini Data_Início,
cp.data_fim Data_Fim
FROM compromissos cp
JOIN contatos ct ON ct.id = cp.id_contatos";
        private const String SQL_SELECT_CONTATOS_BY_ID = @"SELECT
c.id,
c.nome,
c.telefone1,
c.telefone2,
c.email,
en.cep,
en.rua,
en.numero,
en.bairro,
en.cidade,
es.uf 
FROM contatos c
JOIN endereco en ON en.id_contatos = c.id
JOIN estados es ON es.id = en.id_estados
WHERE c.id = @id";
        private const String SQL_SELECT_COMPROMISSOS_BY_ID = @"SELECT id,
descricao,
dia_semana,
data_ini,
data_fim
FROM compromissos
WHERE id = @id";
        #endregion
    }
}

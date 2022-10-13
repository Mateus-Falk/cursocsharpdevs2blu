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
    public class ConexaoForms
    {

        public PacienteRepository PacienteRepository = new PacienteRepository();
        public EnderecoRepository EnderecoRepository = new EnderecoRepository();
        public PessoaRepository PessoaRepository = new PessoaRepository();

        #region Methods
        public Paciente Update(Paciente paciente)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                PessoaRepository.Update(paciente, conn);
                PacienteRepository.Update(paciente, conn);
                EnderecoRepository.Update(paciente, conn);
                return paciente;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public int Exclui(Paciente paciente)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                PacienteRepository.Exclui(paciente, conn);
                EnderecoRepository.Exclui(paciente, conn);
                PessoaRepository.Exclui(paciente, conn);
                return 0;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public Paciente Save(Paciente paciente)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                paciente.Pessoa.Id = PessoaRepository.Save(paciente, conn);
                PacienteRepository.Save(paciente, conn);
                EnderecoRepository.Save(paciente, conn);

                return paciente;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
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
        #endregion

        private const String SQL_SELECT_PESSOAS = @"SELECT p.id as Código, 
       p.nome Nome, 
       cgccpf CPF, 
       p.flstatus Status, 
       pa.numero_prontuario Prontuário, 
       pa.paciente_risco as Risco, 
       (select nome from convenio where id = pa.id_convenio) Convênio, 
       e.CEP, 
       e.Rua, 
       numero as Número, 
       bairro as Bairro,
       cidade as Cidade, 
       UF as Estado
        FROM pessoa p 
        LEFT JOIN endereco e ON p.id = e.id_pessoa
        LEFT JOIN paciente pa ON p.id = pa.id_pessoa";

    }
}

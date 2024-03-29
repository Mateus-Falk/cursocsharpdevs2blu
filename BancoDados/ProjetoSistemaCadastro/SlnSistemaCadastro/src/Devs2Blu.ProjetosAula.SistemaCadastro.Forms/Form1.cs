﻿using Devs2Blu.ProjetosAula.SistemaCadastro.Forms.Data;
using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms
{
    public partial class Form1 : Form
    {
        public MySqlConnection Conn { get; set; }
        public ConvenioRepository ConvenioRepository = new ConvenioRepository();
        public ConexaoForms ConexaoForms = new ConexaoForms();
        public Form1()
        {
            InitializeComponent();
        }

        #region Methods

        private void PopulaComboConvenio()
        {
            var listConvenios = ConvenioRepository.FetchAll();
            cboConvenio.DataSource = new BindingSource(listConvenios, null);
            cboConvenio.DisplayMember = "nome";
            cboConvenio.ValueMember = "id";
        }
        private void PopulaDataGridPessoa()
        {
            var listPessoas = ConexaoForms.GetPessoas();
            gridPaciente.DataSource = new BindingSource(listPessoas, null);           
        }
        private bool validaFormCadastro() 
        {
            if(txtNome.Text.Equals(""))
                return false;
            if (txtCGCCPF.Text.Equals(""))
                return false;
            if (cboConvenio.SelectedIndex == -1)
                return false;
            if (mskCEP.Text.Equals(""))
                return false;
            if (cboUF.Text.Equals(""))
                return false;
            if (txtCidade.Text.Equals(""))
                return false;
            if (txtRua.Text.Equals(""))
                return false;
            if (txtNumero.Text.Equals(""))
                return false;
            if (txtBairro.Text.Equals(""))
                return false;

            return true;
        }
        private void AtualizaCampos(Paciente paciente)
        {
            Random rd = new Random();
            string[] nivelRisco = { "Baixo", "Médio", "Alto" };

            paciente.Pessoa.Nome = txtNome.Text;
            paciente.Pessoa.CGCCPF = txtCGCCPF.Text.Replace(',', '.');

            paciente.Convenio.Id = (int)cboConvenio.SelectedValue;
            paciente.NrProntuario = rd.Next(1000, 9999);
            paciente.PacienteRisco = nivelRisco[rd.Next(0, nivelRisco.Length)];

            paciente.Endereco.CEP = mskCEP.Text.Replace(',', '.');
            paciente.Endereco.Rua = txtRua.Text;
            paciente.Endereco.Numero = Int32.Parse(txtNumero.Text);
            paciente.Endereco.Bairro = txtBairro.Text;
            paciente.Endereco.Cidade = txtCidade.Text;
            paciente.Endereco.UF = cboUF.Text;
        }
        #endregion

        #region events
        private void Form1_Load(object sender, EventArgs e)
        {
            #region TesteConexao
            /*Conn = ConnectionMySQL.GetConnection();
            if (Conn.State == ConnectionState.Open)
            {
                MessageBox.Show("Conexão efetuada com sucesso!", "Conexão MySql", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Conn.Close();
            }*/
            #endregion
            PopulaComboConvenio();
            PopulaDataGridPessoa();
        }

        private void rdFisica_CheckedChanged(object sender, EventArgs e)
        {
             lblCGCCPF.Text = "CPF";
        }

        private void rdJuridica_CheckedChanged(object sender, EventArgs e)
        {
            lblCGCCPF.Text = "CNPJ";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validaFormCadastro())
            {
                Paciente paciente = new Paciente();
               
                AtualizaCampos(paciente);
                
                var pacienteResult = ConexaoForms.Save(paciente);

                if (pacienteResult.Pessoa.Id > 0)
                {
                    MessageBox.Show($"Pessoa {paciente.Pessoa.Id} - {paciente.Pessoa.Nome} salva com sucesso!", "Adicionar Pessoa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    PopulaDataGridPessoa();
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();
            paciente.Pessoa.Id = int.Parse(gridPaciente.CurrentRow.Cells["Código"].Value.ToString());
            
            var result = ConexaoForms.Exclui(paciente);
            if (result == 0)
            {
                MessageBox.Show($"Pessoa {paciente.Pessoa.Id} - {paciente.Pessoa.Nome} Excluída com sucesso!", "Excluir Pessoa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                PopulaDataGridPessoa();
            }
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            if (validaFormCadastro())
            {
                Paciente paciente = new Paciente();

                paciente.Pessoa.Id = int.Parse(gridPaciente.CurrentRow.Cells["Código"].Value.ToString());
                AtualizaCampos(paciente);

                MySqlConnection conn = ConnectionMySQL.GetConnection();


                var pacienteResult = ConexaoForms.Update(paciente);
                
                if (pacienteResult.Pessoa.Id > 0)
                {
                    MessageBox.Show($"Pessoa {paciente.Pessoa.Id} - {paciente.Pessoa.Nome} Atualizada com sucesso!", "Atalizar Pessoa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    PopulaDataGridPessoa();
                }
            }  
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtCGCCPF.Text = "";
            mskCEP.Text = "";
            txtCidade.Text = "";
            cboUF.Text = "";
            txtBairro.Text = "";
            txtRua.Text = "";
            txtNumero.Text = "";
        } 

        private void gridPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Paciente paciente = new Paciente();

            paciente.Pessoa.Id = int.Parse(gridPaciente.CurrentRow.Cells["Código"].Value.ToString());

            txtNome.Text = gridPaciente.CurrentRow.Cells[1].Value.ToString();
            txtCGCCPF.Text = gridPaciente.CurrentRow.Cells[2].Value.ToString();
            cboConvenio.Text = gridPaciente.CurrentRow.Cells[6].Value.ToString();
            mskCEP.Text = gridPaciente.CurrentRow.Cells[7].Value.ToString();
            txtRua.Text = gridPaciente.CurrentRow.Cells[8].Value.ToString();
            txtNumero.Text = gridPaciente.CurrentRow.Cells[9].Value.ToString();
            txtBairro.Text = gridPaciente.CurrentRow.Cells[10].Value.ToString();
            txtCidade.Text = gridPaciente.CurrentRow.Cells[11].Value.ToString();
            cboUF.Text = gridPaciente.CurrentRow.Cells[12].Value.ToString();
        }
        #endregion
    }
}

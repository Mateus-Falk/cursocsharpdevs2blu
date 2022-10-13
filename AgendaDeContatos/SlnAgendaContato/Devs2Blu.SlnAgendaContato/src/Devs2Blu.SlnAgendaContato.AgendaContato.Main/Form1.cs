using Devs2Blu.SlnAgendaContato.AgendaContato.Main.Data;
using Devs2Blu.SlnAgendaContato.AgendaContato.Models;
using Devs2Blu.SlnAgendaContato.AgendaContato.Models.Models;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Devs2Blu.SlnAgendaContato.AgendaContato.Main
{
    public partial class Form1 : Form
    {
        public MySqlConnection Coon { get; set; }
        public EstadoRepository EstadoRepository = new EstadoRepository();
        public ConexaoForms ConexaoForms = new ConexaoForms();
        public CompromissosRepository CompromissosRepository = new CompromissosRepository();
        public Form1()
        {
            InitializeComponent();
        }

        #region Methods
        #region Methods Contatos
        private void PopulaComboEstados()
        {
            var listEstados = EstadoRepository.FetchAll();
            cboEstado.DataSource = new BindingSource(listEstados, null);
            cboEstado.DisplayMember = "uf";
            cboEstado.ValueMember = "id";
        }
        private void PopulaDataGridContatos()
        {
            var listContatos = ConexaoForms.GetContatos();
            gridContatos.DataSource = new BindingSource(listContatos, null);
        }
        private bool ValidaFormCadastro()
        {
            if (txtNome.Text.Equals(""))
                return false;
            if (mskTelefone1.Text.Equals(""))
                return false;
            if (txtEmail.Text.Equals(""))
                return false;

            if (mskCEP.Text.Equals(""))
                return false;
            if (txtRua.Text.Equals(""))
                return false;
            if (txtNumero.Text.Equals(""))
                return false;
            if (txtBairro.Text.Equals(""))
                return false;
            if (txtCidade.Text.Equals(""))
                return false;
            if (cboEstado.SelectedIndex == -1)
                return false;

            return true;
        }
        private void AtualizaCampos(Contato contato)
        {
            contato.Nome = txtNome.Text;
            contato.Telefone1 = mskTelefone1.Text;
            contato.Telefone2 = mskTelefone2.Text;
            contato.Email = txtEmail.Text;

            contato.Endereco.CEP = mskCEP.Text.Replace(',', '.');
            contato.Endereco.Rua = txtRua.Text;
            contato.Endereco.Numero = Int32.Parse(txtNumero.Text);
            contato.Endereco.Bairro = txtBairro.Text;
            contato.Endereco.Cidade = txtCidade.Text;
            contato.Endereco.Estados.Id = (int)cboEstado.SelectedValue;
        }
        private void LimpaContatos()
        {
            txtNome.Text = "";
            mskTelefone1.Text = "";
            mskTelefone2.Text = "";
            txtEmail.Text = "";

            mskCEP.Text = "";
            txtBairro.Text = "";
            txtRua.Text = "";
            txtNumero.Text = "";
            txtCidade.Text = "";
            cboEstado.SelectedValue = "";
        }
        #endregion
        #region Methods Compromissos
        private void PopulaDataGridCompromissos()
        {
            var listCompromissos = ConexaoForms.GetCompromissos();
            gridCompromissos.DataSource = new BindingSource(listCompromissos, null);
        }
        private void LimpaCompromisso()
        {
            txtDescricao.Text = "";
            cboDiaSemana.SelectedValue = "";
            dtInicio.Text = "";
            dtFim.Text = "";
        }
        private bool ValidaFormCompromisso()
        {
            if (txtDescricao.Text.Equals(""))
                return false;
            if (cboDiaSemana.Text.Equals(""))
                return false;
            if (dtInicio.Text.Equals(""))
                return false;
            if (dtFim.Text.Equals(""))
                return false;

            return true;
        }
        private void SetDiaSemana(Compromissos compromissos)
        {
            if (cboDiaSemana.Text.Equals("Domigo"))
                compromissos.DiasSemana = Models.Enum.DiasSemana.DOM;
            if (cboDiaSemana.Text.Equals("Segunda"))
                compromissos.DiasSemana = Models.Enum.DiasSemana.SEG;
            if (cboDiaSemana.Text.Equals("Terça"))
                compromissos.DiasSemana = Models.Enum.DiasSemana.TER;
            if (cboDiaSemana.Text.Equals("Quarta"))
                compromissos.DiasSemana = Models.Enum.DiasSemana.QUA;
            if (cboDiaSemana.Text.Equals("Quinta"))
                compromissos.DiasSemana = Models.Enum.DiasSemana.QUI;
            if (cboDiaSemana.Text.Equals("Sexta"))
                compromissos.DiasSemana = Models.Enum.DiasSemana.SEX;
            if (cboDiaSemana.Text.Equals("Sábado"))
                compromissos.DiasSemana = Models.Enum.DiasSemana.SAB;
        }
        #endregion
        #endregion
        #region Events
        private void Form1_Load_1(object sender, EventArgs e)
        {
            PopulaComboEstados();
            PopulaDataGridContatos();
            PopulaDataGridCompromissos();
        }
        #region Events Contato

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaFormCadastro())
            {
                Contato contato = new Contato();

                AtualizaCampos(contato);

                var contatoResult = ConexaoForms.Save(contato);

                if (contatoResult.Id > 0)
                {
                    MessageBox.Show($"Contato {contato.Id} - {contato.Nome} salvo com sucesso!", "Adicionar Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    PopulaDataGridContatos();
                }
            }
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (ValidaFormCadastro())
            {
                Contato contato = new Contato();

                contato.Id = int.Parse(gridContatos.CurrentRow.Cells["Código"].Value.ToString());
                AtualizaCampos(contato);

                MySqlConnection conn = ConnectionMySQL.GetConnection();

                var contatoResult = ConexaoForms.Update(contato);

                if (contatoResult.Id > 0)
                {
                    MessageBox.Show($"Contato {contato.Id} - {contato.Nome} Atualizado com sucesso!", "Atualizar Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    PopulaDataGridContatos();
                }
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato();
            contato.Id = int.Parse(gridContatos.CurrentRow.Cells["Código"].Value.ToString());

            var result = ConexaoForms.Exclui(contato);
            if (result == 0)
            {
                MessageBox.Show($"Contato {contato.Id} - {contato.Nome} Excluído com sucesso!", "Excluir Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                PopulaDataGridContatos();
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaContatos();
        }
        private void gridContatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idContato = (int)gridContatos.Rows[e.RowIndex].Cells["Código"].Value;
            MySqlDataReader rdrC = ConexaoForms.GetContatoById(idContato);
            while (rdrC.Read())
            {
                txtNome.Text = rdrC.GetString("nome");
                mskTelefone1.Text = rdrC.GetString("telefone1");
                mskTelefone2.Text = rdrC.GetString("telefone2");
                txtEmail.Text = rdrC.GetString("email");
                mskCEP.Text = rdrC.GetString("cep");
                txtRua.Text = rdrC.GetString("rua");
                txtNumero.Text = rdrC.GetString("numero");
                txtBairro.Text = rdrC.GetString("bairro");
                txtCidade.Text = rdrC.GetString("cidade");
                cboEstado.Text = rdrC.GetString("uf");
            }
        }
        #endregion
        #region Events Compromissos
        private void btnMarcar_Click(object sender, EventArgs e)
        {
            if (ValidaFormCompromisso())
            {
                Compromissos compromissos = new Compromissos();

                compromissos.IdContato = int.Parse(gridContatos.CurrentRow.Cells["Código"].Value.ToString());
                compromissos.Descricao = txtDescricao.Text;
                SetDiaSemana(compromissos);
                compromissos.DataInicio = dtInicio.Value;
                compromissos.DataFim = dtFim.Value;

                MySqlConnection conn = ConnectionMySQL.GetConnection();


                var compromissoResult = CompromissosRepository.Save(compromissos, conn);

                if (compromissoResult.Id > 0)
                {
                    MessageBox.Show($"Compromisso {compromissos.Id} - {compromissos.Descricao} Salvo com sucesso!", "Salvar Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    PopulaDataGridCompromissos();
                }
            }
        }
        private void btnRemarcar_Click(object sender, EventArgs e)
        {
            Compromissos compromissos = new Compromissos();

            compromissos.Id = int.Parse(gridCompromissos.CurrentRow.Cells["Código"].Value.ToString());
            SetDiaSemana(compromissos);
            compromissos.DataInicio = dtInicio.Value;
            compromissos.DataFim = dtFim.Value;

            MySqlConnection conn = ConnectionMySQL.GetConnection();


            var compromissoResult = CompromissosRepository.UpdateRemarcar(compromissos);

            if (compromissoResult.Id > 0)
            {
                MessageBox.Show($"Compromisso {compromissos.Id} - {compromissos.Descricao} Remarcado com sucesso!", "Remarcar Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                PopulaDataGridCompromissos();
            }
        }
        private void btnDesmarcar_Click(object sender, EventArgs e)
        {
            Compromissos compromissos = new Compromissos();

            compromissos.Id = int.Parse(gridCompromissos.CurrentRow.Cells["Código"].Value.ToString());


            MySqlConnection conn = ConnectionMySQL.GetConnection();


            var compromissoResult = CompromissosRepository.UpdateDesmarcar(compromissos);

            if (compromissoResult.Id > 0)
            {
                MessageBox.Show($"Compromisso {compromissos.Id} - {compromissos.Descricao} Desmarcado com sucesso!", "Desmarcar Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                PopulaDataGridCompromissos();
            }
        }
        private void btnConcluido_Click(object sender, EventArgs e)
        {
            Compromissos compromissos = new Compromissos();

            compromissos.Id = int.Parse(gridCompromissos.CurrentRow.Cells["Código"].Value.ToString());


            MySqlConnection conn = ConnectionMySQL.GetConnection();


            var compromissoResult = CompromissosRepository.UpdateConcluido(compromissos);

            if (compromissoResult.Id > 0)
            {
                MessageBox.Show($"Compromisso {compromissos.Id} - {compromissos.Descricao} Concluído com sucesso!", "Concluir Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                PopulaDataGridCompromissos();
            }
        }
        private void btnLimparCompromisso_Click(object sender, EventArgs e)
        {
            LimpaCompromisso();
        }
        private void gridCompromissos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idCompromissos = (int)gridCompromissos.Rows[e.RowIndex].Cells["Código"].Value;
            MySqlDataReader rdrC = ConexaoForms.GetCompromissoById(idCompromissos);

            while (rdrC.Read())
            {
                txtDescricao.Text = rdrC.GetString("descricao");
                cboDiaSemana.Text = rdrC.GetString("dia_semana");
                dtInicio.Text = rdrC.GetString("data_ini");
                dtFim.Text = rdrC.GetString("data_fim");
            }
        }
        #endregion

        #endregion
    }
}

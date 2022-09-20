using Devs2Blu.ProjetosAula.AulaPOO2Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.AulaOOP2
{
    public partial class Form1 : Form
    {
        public Contato contato { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contato = new Contato();
        }

        #region Eventos

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!ValidaForm())
            {
                MessageBox.Show(this, "Preencha todos os campos! ","Erro - Formulário de contato",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            bindClass();
            string textoMensagem = $"{contato.Nome}, mensagem enviada com sucesso";
            MessageBox.Show(this, textoMensagem, "Formulário de contato");
            LimpaTela();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }

        private void txtCEP_TextChanged(object sender, EventArgs e)
        {
            if(txtCEP.Text.Length == 8)
            {
                txtRua.Text = "7 de Setembro";
                txtBairro.Text = "Centro";
                txtCidade.Text = "Blumenau";
                txtEstado.Text = "Santa Catarina";
            }
            else
            {
                txtRua.Clear();
                txtBairro.Clear();
                txtCidade.Clear();
                txtEstado.Clear();
            }
        }
        #endregion

        #region Metodos
        private void LimpaTela()
        {
            txtNome.Clear();
            txtTelCel.Clear();
            txtEmail.Clear();
            txtCEP.Clear();
            txtRua.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtRecado.Clear(); 
        }

        public bool ValidaForm()
        {
            bool isValid = true;
            if (txtNome.Text.Equals("")) return false;
            if (txtTelCel.Text.Equals("")) return false;
            if (txtEmail.Text.Equals("")) return false;
            if (txtCEP.Text.Equals("")) return false;
            if (txtRua.Text.Equals("")) return false;
            if (txtBairro.Text.Equals("")) return false;
            if (txtCidade.Text.Equals("")) return false;
            if (txtEstado.Text.Equals("")) return false;
            if (txtRecado.Text.Equals("")) return false;
          
            return true;
        }
        public void bindClass()
        {
            contato.Nome = txtNome.Text;
            contato.TelCel = txtNome.Text;
            contato.Email = txtEmail.Text;
            contato.CEP = txtCEP.Text;
            contato.Rua = txtRua.Text;
            contato.Bairro = txtBairro.Text;
            contato.Cidade = txtCidade.Text;
            contato.Estado = txtEstado.Text;
        }
        #endregion
    }

}

using Devs2Blu.ProjetosAula.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.AulaOOP1INT
{
    public partial class Form1 : Form
    {
        public List<Recepcionista> RecepcionistasList { get; set; }
        public List<Diretor> DiretorsList { get; set; }
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            RecepcionistasList = new List<Recepcionista>();
            DiretorsList = new List<Diretor>();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (rdDiretor.Checked)
            {
                Diretor diretor= new Diretor();
                diretor.Nome = txtNome.Text;
                diretor.SobreNome = txtSobrenome.Text;
                diretor.Idade = Int32.Parse(txtIdade.Text);
                diretor.Endereco = txtEndereco.Text;
                DiretorsList.Add(diretor);
                txtStatus.Text += "\r\nCadastro do Diretor efetuado com sucesso";
                txtStatus.Text += $"\r\n{diretor.Nome} {diretor.SobreNome}";

            }else if (rdRecepcionista.Checked)
            {
                Recepcionista recepcionista = new Recepcionista();
                recepcionista.Nome = txtNome.Text;
                recepcionista.SobreNome = txtSobrenome.Text;
                recepcionista.Idade = Int32.Parse(txtIdade.Text);
                recepcionista.Endereco = txtEndereco.Text;
                RecepcionistasList.Add(recepcionista);
                txtStatus.Text += "\r\nCadastro da Recepcionista efetuado com sucesso";
                txtStatus.Text += $"\r\n{recepcionista.Nome} {recepcionista.SobreNome}";
            }
            LimparFormulario();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario();
            txtStatus.Text += "\r\nCadastro Cancelado";
        }

        private void LimparFormulario()
        {
            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtIdade.Text = "";
            txtEndereco.Text = "";
        }
    }
}

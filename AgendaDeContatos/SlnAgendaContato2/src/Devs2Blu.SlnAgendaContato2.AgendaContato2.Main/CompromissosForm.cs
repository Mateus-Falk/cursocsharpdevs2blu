using Devs2Blu.SlnAgendaContato2.AgendaContato2.Class.Enum;
using Devs2Blu.SlnAgendaContato2.AgendaContato2.Class.Models;
using Devs2Blu.SlnAgendaContato2.AgendaContato2.Main.Data;
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
using System.Xml.Serialization;

namespace Devs2Blu.SlnAgendaContato2.AgendaContato2.Main
{
    public partial class CompromissosForm : Form
    {
        public ContatoRepository ContatoRepository { get; set; }
        public CompromissoRepository CompromissoRepository { get; set; }
        public Compromisso Compromisso{ get; set; }

        public CompromissosForm()
        {
            InitializeComponent();
        }

        #region Methods
        private void PopulaCboContatos()
        {
            var listContatos = ContatoRepository.GetContatosCbo();
            cboContatos.DataSource = new BindingSource(listContatos,null);
            cboContatos.DisplayMember = "nome";
            cboContatos.ValueMember = "id";
        }
        private void PopulaCboStatus()
        {
            cboStatus.DataSource = Enum.GetValues(typeof(StatusEnum))
                                            .Cast<Enum>().Select(value => new
                                            {
                                                Description =(value.GetType().GetMember(value.ToString()).FirstOrDefault()
                                                .GetCustomAttributes(typeof(DescriptionAttribute),inherit: false).FirstOrDefault()
                                                as DescriptionAttribute)?.Description ?? value.ToString(),
                                                Value = value
                                            })
                                            .OrderBy(item => item.Value)
                                            .ToList();
            cboStatus.DisplayMember = "Description";
            cboStatus.ValueMember = "Value";
            
        }

        private void PopulaGridCompromisso()
        {
            var listCompromisso = CompromissoRepository.GetCompromissoGrid();
            gridCompromissos.DataSource = new BindingSource(listCompromisso, null);
        }

        private void PreparaObjetoSalvar()
        {
            if (cboContatos.SelectedIndex > 0)
            {
                Compromisso.Contato = new Contato((int)cboContatos.SelectedValue, "");
            }
            Compromisso.Titulo = txtTitulo.Text;
            Compromisso.Descricao = txtDescricao.Text;
            Compromisso.DataIni = dtInicio.Value;
            Compromisso.DataFim = dtFim.Value;
            Compromisso.Status = (StatusEnum)cboStatus.SelectedValue;
        }
        private int SalvarCompromisso()
        {
            try
            {
                string columns = "titulo,descricao,dataini,datafim,status";
                string values = $"'{Compromisso.Titulo}','{Compromisso.Descricao}','{Compromisso.DataIni.ToString("yyyy-MM-dd HH-mm-ss")}','{Compromisso.DataFim.ToString("yyyy-MM-dd HH-mm-ss")}','{Compromisso.Status}'";
                if(Compromisso.Contato.Id > 0)
                {
                    columns += ",contatos_id";
                    values += $",{Compromisso.Contato.Id}";
                }
                var retorno = CompromissoRepository.Insert(columns, values);
                return retorno;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
        #region Events
        private void CompromissosForm_Load(object sender, EventArgs e)
        {
            ContatoRepository = new ContatoRepository();
            CompromissoRepository = new CompromissoRepository();
            Compromisso = new Compromisso();
            PopulaCboContatos();
            PopulaCboStatus();
            PopulaGridCompromisso();
        }
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            PreparaObjetoSalvar();
            if (SalvarCompromisso() > 0)
            {
                MessageBox.Show($"Compromisso: {Compromisso.Titulo} salvo com sucesso!", "Compromissos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void CompromissosForm_Activated(object sender, EventArgs e)
        {
            PopulaGridCompromisso();
        }
        #endregion
    }
}

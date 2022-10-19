namespace Devs2Blu.SlnAgendaContato.AgendaContato.Main
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbCadastroContatos = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.gbEndereco = new System.Windows.Forms.GroupBox();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.mskTelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.mskTelefone1 = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridContatos = new System.Windows.Forms.DataGridView();
            this.gbCompromissos = new System.Windows.Forms.GroupBox();
            this.btnLimparCompromisso = new System.Windows.Forms.Button();
            this.btnDesmarcar = new System.Windows.Forms.Button();
            this.btnRemarcar = new System.Windows.Forms.Button();
            this.btnConcluido = new System.Windows.Forms.Button();
            this.btnMarcar = new System.Windows.Forms.Button();
            this.cboDiaSemana = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gridCompromissos = new System.Windows.Forms.DataGridView();
            this.gbCadastroContatos.SuspendLayout();
            this.gbEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContatos)).BeginInit();
            this.gbCompromissos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompromissos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCadastroContatos
            // 
            this.gbCadastroContatos.Controls.Add(this.btnExcluir);
            this.gbCadastroContatos.Controls.Add(this.gbEndereco);
            this.gbCadastroContatos.Controls.Add(this.btnLimpar);
            this.gbCadastroContatos.Controls.Add(this.mskTelefone2);
            this.gbCadastroContatos.Controls.Add(this.btnAtualizar);
            this.gbCadastroContatos.Controls.Add(this.mskTelefone1);
            this.gbCadastroContatos.Controls.Add(this.btnSalvar);
            this.gbCadastroContatos.Controls.Add(this.txtEmail);
            this.gbCadastroContatos.Controls.Add(this.txtNome);
            this.gbCadastroContatos.Controls.Add(this.label4);
            this.gbCadastroContatos.Controls.Add(this.label3);
            this.gbCadastroContatos.Controls.Add(this.label2);
            this.gbCadastroContatos.Controls.Add(this.label1);
            this.gbCadastroContatos.Location = new System.Drawing.Point(12, 44);
            this.gbCadastroContatos.Name = "gbCadastroContatos";
            this.gbCadastroContatos.Size = new System.Drawing.Size(363, 327);
            this.gbCadastroContatos.TabIndex = 0;
            this.gbCadastroContatos.TabStop = false;
            this.gbCadastroContatos.Text = "Cadastro de Contatos";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(290, 287);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(59, 23);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // gbEndereco
            // 
            this.gbEndereco.Controls.Add(this.mskCEP);
            this.gbEndereco.Controls.Add(this.cboEstado);
            this.gbEndereco.Controls.Add(this.txtCidade);
            this.gbEndereco.Controls.Add(this.txtBairro);
            this.gbEndereco.Controls.Add(this.txtNumero);
            this.gbEndereco.Controls.Add(this.txtRua);
            this.gbEndereco.Controls.Add(this.label10);
            this.gbEndereco.Controls.Add(this.label9);
            this.gbEndereco.Controls.Add(this.label8);
            this.gbEndereco.Controls.Add(this.label7);
            this.gbEndereco.Controls.Add(this.label6);
            this.gbEndereco.Controls.Add(this.label5);
            this.gbEndereco.Location = new System.Drawing.Point(12, 136);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Size = new System.Drawing.Size(337, 145);
            this.gbEndereco.TabIndex = 8;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "Endereço";
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(49, 27);
            this.mskCEP.Mask = "00.000-00";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(60, 20);
            this.mskCEP.TabIndex = 9;
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(284, 110);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(47, 21);
            this.cboEstado.TabIndex = 13;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(64, 111);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(167, 20);
            this.txtCidade.TabIndex = 12;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(58, 82);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(173, 20);
            this.txtBairro.TabIndex = 11;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(274, 53);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(57, 20);
            this.txtNumero.TabIndex = 10;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(49, 53);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(182, 20);
            this.txtRua.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(238, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Estado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Cidade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Bairro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Número";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Rua";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "CEP";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(194, 287);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(59, 23);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // mskTelefone2
            // 
            this.mskTelefone2.Location = new System.Drawing.Point(249, 62);
            this.mskTelefone2.Mask = "(00) 0000-0000";
            this.mskTelefone2.Name = "mskTelefone2";
            this.mskTelefone2.Size = new System.Drawing.Size(100, 20);
            this.mskTelefone2.TabIndex = 7;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(100, 287);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(59, 23);
            this.btnAtualizar.TabIndex = 15;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // mskTelefone1
            // 
            this.mskTelefone1.Location = new System.Drawing.Point(61, 62);
            this.mskTelefone1.Mask = "(00) 0000-0000";
            this.mskTelefone1.Name = "mskTelefone1";
            this.mskTelefone1.Size = new System.Drawing.Size(84, 20);
            this.mskTelefone1.TabIndex = 6;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 287);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(59, 23);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(47, 88);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(302, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(47, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(302, 20);
            this.txtNome.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone Reserva";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // gridContatos
            // 
            this.gridContatos.AllowUserToAddRows = false;
            this.gridContatos.AllowUserToOrderColumns = true;
            this.gridContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridContatos.Location = new System.Drawing.Point(12, 387);
            this.gridContatos.Name = "gridContatos";
            this.gridContatos.ReadOnly = true;
            this.gridContatos.Size = new System.Drawing.Size(363, 208);
            this.gridContatos.TabIndex = 1;
            this.gridContatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridContatos_CellContentClick);
            // 
            // gbCompromissos
            // 
            this.gbCompromissos.Controls.Add(this.btnLimparCompromisso);
            this.gbCompromissos.Controls.Add(this.btnDesmarcar);
            this.gbCompromissos.Controls.Add(this.btnRemarcar);
            this.gbCompromissos.Controls.Add(this.btnConcluido);
            this.gbCompromissos.Controls.Add(this.btnMarcar);
            this.gbCompromissos.Controls.Add(this.cboDiaSemana);
            this.gbCompromissos.Controls.Add(this.txtDescricao);
            this.gbCompromissos.Controls.Add(this.dtFim);
            this.gbCompromissos.Controls.Add(this.dtInicio);
            this.gbCompromissos.Controls.Add(this.label14);
            this.gbCompromissos.Controls.Add(this.label13);
            this.gbCompromissos.Controls.Add(this.label12);
            this.gbCompromissos.Controls.Add(this.label11);
            this.gbCompromissos.Location = new System.Drawing.Point(413, 53);
            this.gbCompromissos.Name = "gbCompromissos";
            this.gbCompromissos.Size = new System.Drawing.Size(435, 318);
            this.gbCompromissos.TabIndex = 2;
            this.gbCompromissos.TabStop = false;
            this.gbCompromissos.Text = "Marcar Novo Compromisso";
            // 
            // btnLimparCompromisso
            // 
            this.btnLimparCompromisso.Location = new System.Drawing.Point(344, 224);
            this.btnLimparCompromisso.Name = "btnLimparCompromisso";
            this.btnLimparCompromisso.Size = new System.Drawing.Size(75, 23);
            this.btnLimparCompromisso.TabIndex = 12;
            this.btnLimparCompromisso.Text = "Limpar";
            this.btnLimparCompromisso.UseVisualStyleBackColor = true;
            this.btnLimparCompromisso.Click += new System.EventHandler(this.btnLimparCompromisso_Click);
            // 
            // btnDesmarcar
            // 
            this.btnDesmarcar.Location = new System.Drawing.Point(182, 224);
            this.btnDesmarcar.Name = "btnDesmarcar";
            this.btnDesmarcar.Size = new System.Drawing.Size(75, 23);
            this.btnDesmarcar.TabIndex = 11;
            this.btnDesmarcar.Text = "Desmarcar";
            this.btnDesmarcar.UseVisualStyleBackColor = true;
            this.btnDesmarcar.Click += new System.EventHandler(this.btnDesmarcar_Click);
            // 
            // btnRemarcar
            // 
            this.btnRemarcar.Location = new System.Drawing.Point(101, 224);
            this.btnRemarcar.Name = "btnRemarcar";
            this.btnRemarcar.Size = new System.Drawing.Size(75, 23);
            this.btnRemarcar.TabIndex = 10;
            this.btnRemarcar.Text = "Remarcar";
            this.btnRemarcar.UseVisualStyleBackColor = true;
            this.btnRemarcar.Click += new System.EventHandler(this.btnRemarcar_Click);
            // 
            // btnConcluido
            // 
            this.btnConcluido.Location = new System.Drawing.Point(263, 224);
            this.btnConcluido.Name = "btnConcluido";
            this.btnConcluido.Size = new System.Drawing.Size(75, 23);
            this.btnConcluido.TabIndex = 9;
            this.btnConcluido.Text = "Concluído";
            this.btnConcluido.UseVisualStyleBackColor = true;
            this.btnConcluido.Click += new System.EventHandler(this.btnConcluido_Click);
            // 
            // btnMarcar
            // 
            this.btnMarcar.Location = new System.Drawing.Point(20, 224);
            this.btnMarcar.Name = "btnMarcar";
            this.btnMarcar.Size = new System.Drawing.Size(75, 23);
            this.btnMarcar.TabIndex = 8;
            this.btnMarcar.Text = "Marcar";
            this.btnMarcar.UseVisualStyleBackColor = true;
            this.btnMarcar.Click += new System.EventHandler(this.btnMarcar_Click);
            // 
            // cboDiaSemana
            // 
            this.cboDiaSemana.FormattingEnabled = true;
            this.cboDiaSemana.Items.AddRange(new object[] {
            "Domingo",
            "Segunda",
            "Terça",
            "Quarta",
            "Quinta",
            "Sexta",
            "Sábado"});
            this.cboDiaSemana.Location = new System.Drawing.Point(101, 130);
            this.cboDiaSemana.Name = "cboDiaSemana";
            this.cboDiaSemana.Size = new System.Drawing.Size(121, 21);
            this.cboDiaSemana.TabIndex = 7;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(101, 30);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(308, 97);
            this.txtDescricao.TabIndex = 6;
            // 
            // dtFim
            // 
            this.dtFim.Location = new System.Drawing.Point(83, 181);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(200, 20);
            this.dtFim.TabIndex = 5;
            // 
            // dtInicio
            // 
            this.dtInicio.Location = new System.Drawing.Point(83, 155);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(200, 20);
            this.dtInicio.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Dia da Semana";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Data Início";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Data Fim";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Descrição";
            // 
            // gridCompromissos
            // 
            this.gridCompromissos.AllowUserToAddRows = false;
            this.gridCompromissos.AllowUserToOrderColumns = true;
            this.gridCompromissos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCompromissos.Location = new System.Drawing.Point(413, 387);
            this.gridCompromissos.Name = "gridCompromissos";
            this.gridCompromissos.ReadOnly = true;
            this.gridCompromissos.Size = new System.Drawing.Size(435, 208);
            this.gridCompromissos.TabIndex = 3;
            this.gridCompromissos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCompromissos_CellDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 619);
            this.Controls.Add(this.gridCompromissos);
            this.Controls.Add(this.gbCompromissos);
            this.Controls.Add(this.gridContatos);
            this.Controls.Add(this.gbCadastroContatos);
            this.Name = "Form1";
            this.Text = "Agenda de Contatos";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.gbCadastroContatos.ResumeLayout(false);
            this.gbCadastroContatos.PerformLayout();
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContatos)).EndInit();
            this.gbCompromissos.ResumeLayout(false);
            this.gbCompromissos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompromissos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCadastroContatos;
        private System.Windows.Forms.MaskedTextBox mskTelefone2;
        private System.Windows.Forms.MaskedTextBox mskTelefone1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbEndereco;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView gridContatos;
        private System.Windows.Forms.GroupBox gbCompromissos;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDesmarcar;
        private System.Windows.Forms.Button btnRemarcar;
        private System.Windows.Forms.Button btnConcluido;
        private System.Windows.Forms.Button btnMarcar;
        private System.Windows.Forms.ComboBox cboDiaSemana;
        private System.Windows.Forms.DataGridView gridCompromissos;
        private System.Windows.Forms.Button btnLimparCompromisso;
    }
}


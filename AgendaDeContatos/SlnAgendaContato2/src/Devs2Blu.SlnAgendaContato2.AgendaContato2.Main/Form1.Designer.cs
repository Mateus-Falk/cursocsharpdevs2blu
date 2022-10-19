namespace Devs2Blu.SlnAgendaContato2.AgendaContato2.Main
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
            this.gbContatos = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rdAtivo = new System.Windows.Forms.RadioButton();
            this.rdInativo = new System.Windows.Forms.RadioButton();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cboUF = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gridContatos = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compromissosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbContatos.SuspendLayout();
            this.gbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContatos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbContatos
            // 
            this.gbContatos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbContatos.Controls.Add(this.txtEmail);
            this.gbContatos.Controls.Add(this.label8);
            this.gbContatos.Controls.Add(this.gbStatus);
            this.gbContatos.Controls.Add(this.btnExcluir);
            this.gbContatos.Controls.Add(this.btnLimpar);
            this.gbContatos.Controls.Add(this.btnSalvar);
            this.gbContatos.Controls.Add(this.label7);
            this.gbContatos.Controls.Add(this.cboUF);
            this.gbContatos.Controls.Add(this.label6);
            this.gbContatos.Controls.Add(this.mskCelular);
            this.gbContatos.Controls.Add(this.label5);
            this.gbContatos.Controls.Add(this.mskTelefone);
            this.gbContatos.Controls.Add(this.label4);
            this.gbContatos.Controls.Add(this.label3);
            this.gbContatos.Controls.Add(this.label2);
            this.gbContatos.Controls.Add(this.label1);
            this.gbContatos.Controls.Add(this.txtCidade);
            this.gbContatos.Controls.Add(this.txtBairro);
            this.gbContatos.Controls.Add(this.txtNumero);
            this.gbContatos.Controls.Add(this.txtRua);
            this.gbContatos.Controls.Add(this.txtNome);
            this.gbContatos.Location = new System.Drawing.Point(10, 35);
            this.gbContatos.Name = "gbContatos";
            this.gbContatos.Size = new System.Drawing.Size(822, 95);
            this.gbContatos.TabIndex = 0;
            this.gbContatos.TabStop = false;
            this.gbContatos.Text = "Cadastro Contatos";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(626, 19);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(190, 20);
            this.txtEmail.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(588, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Email";
            // 
            // gbStatus
            // 
            this.gbStatus.BackColor = System.Drawing.SystemColors.Control;
            this.gbStatus.Controls.Add(this.rdAtivo);
            this.gbStatus.Controls.Add(this.rdInativo);
            this.gbStatus.Location = new System.Drawing.Point(626, 44);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(190, 47);
            this.gbStatus.TabIndex = 21;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // rdAtivo
            // 
            this.rdAtivo.AutoSize = true;
            this.rdAtivo.BackColor = System.Drawing.Color.Lime;
            this.rdAtivo.Location = new System.Drawing.Point(105, 19);
            this.rdAtivo.Name = "rdAtivo";
            this.rdAtivo.Size = new System.Drawing.Size(49, 17);
            this.rdAtivo.TabIndex = 1;
            this.rdAtivo.TabStop = true;
            this.rdAtivo.Text = "Ativo";
            this.rdAtivo.UseVisualStyleBackColor = false;
            // 
            // rdInativo
            // 
            this.rdInativo.AutoSize = true;
            this.rdInativo.BackColor = System.Drawing.Color.Red;
            this.rdInativo.Location = new System.Drawing.Point(6, 19);
            this.rdInativo.Name = "rdInativo";
            this.rdInativo.Size = new System.Drawing.Size(57, 17);
            this.rdInativo.TabIndex = 0;
            this.rdInativo.TabStop = true;
            this.rdInativo.Text = "Inativo";
            this.rdInativo.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.Location = new System.Drawing.Point(498, 73);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 24);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Yellow;
            this.btnLimpar.Location = new System.Drawing.Point(413, 73);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 19;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Lime;
            this.btnSalvar.Location = new System.Drawing.Point(325, 71);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 18;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(160, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cidade";
            // 
            // cboUF
            // 
            this.cboUF.FormattingEnabled = true;
            this.cboUF.Location = new System.Drawing.Point(47, 70);
            this.cboUF.Name = "cboUF";
            this.cboUF.Size = new System.Drawing.Size(107, 21);
            this.cboUF.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "UF";
            // 
            // mskCelular
            // 
            this.mskCelular.Location = new System.Drawing.Point(492, 19);
            this.mskCelular.Mask = "(00) 00000-0000";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.Size = new System.Drawing.Size(94, 20);
            this.mskCelular.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Celular";
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(362, 19);
            this.mskTelefone.Mask = "(00) 0000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(81, 20);
            this.mskTelefone.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bairro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Rua";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(206, 73);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(110, 20);
            this.txtCidade.TabIndex = 5;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(362, 44);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(224, 20);
            this.txtBairro.TabIndex = 3;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(276, 44);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(40, 20);
            this.txtNumero.TabIndex = 2;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(47, 44);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(223, 20);
            this.txtRua.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(47, 19);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(247, 20);
            this.txtNome.TabIndex = 0;
            // 
            // gridContatos
            // 
            this.gridContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridContatos.Location = new System.Drawing.Point(10, 136);
            this.gridContatos.Name = "gridContatos";
            this.gridContatos.Size = new System.Drawing.Size(822, 261);
            this.gridContatos.TabIndex = 1;
            this.gridContatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridContatos_CellClick);
            this.gridContatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridContatos_CellDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.agendaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compromissosToolStripMenuItem});
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.agendaToolStripMenuItem.Text = "Agenda";
            // 
            // compromissosToolStripMenuItem
            // 
            this.compromissosToolStripMenuItem.Name = "compromissosToolStripMenuItem";
            this.compromissosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.compromissosToolStripMenuItem.Text = "Compromissos";
            this.compromissosToolStripMenuItem.Click += new System.EventHandler(this.compromissosToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 404);
            this.Controls.Add(this.gridContatos);
            this.Controls.Add(this.gbContatos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbContatos.ResumeLayout(false);
            this.gbContatos.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContatos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbContatos;
        private System.Windows.Forms.MaskedTextBox mskCelular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboUF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView gridContatos;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rdAtivo;
        private System.Windows.Forms.RadioButton rdInativo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compromissosToolStripMenuItem;
    }
}


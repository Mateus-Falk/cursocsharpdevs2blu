namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms
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
            this.gbFormCadastro = new System.Windows.Forms.GroupBox();
            this.txtCGCCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gbEnderecoCadastro = new System.Windows.Forms.GroupBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCGCCPF = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbTipoPessoa = new System.Windows.Forms.GroupBox();
            this.rdJuridica = new System.Windows.Forms.RadioButton();
            this.rdFisica = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cboConvenio = new System.Windows.Forms.ComboBox();
            this.gbConteudo = new System.Windows.Forms.GroupBox();
            this.gridPaciente = new System.Windows.Forms.DataGridView();
            this.panelControles = new System.Windows.Forms.Panel();
            this.BtnInfo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbFormCadastro.SuspendLayout();
            this.gbEnderecoCadastro.SuspendLayout();
            this.gbTipoPessoa.SuspendLayout();
            this.gbConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPaciente)).BeginInit();
            this.panelControles.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFormCadastro
            // 
            this.gbFormCadastro.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbFormCadastro.Controls.Add(this.txtCGCCPF);
            this.gbFormCadastro.Controls.Add(this.txtNome);
            this.gbFormCadastro.Controls.Add(this.gbEnderecoCadastro);
            this.gbFormCadastro.Controls.Add(this.label4);
            this.gbFormCadastro.Controls.Add(this.lblCGCCPF);
            this.gbFormCadastro.Controls.Add(this.label2);
            this.gbFormCadastro.Controls.Add(this.gbTipoPessoa);
            this.gbFormCadastro.Controls.Add(this.label1);
            this.gbFormCadastro.Controls.Add(this.cboConvenio);
            this.gbFormCadastro.Location = new System.Drawing.Point(12, 39);
            this.gbFormCadastro.Name = "gbFormCadastro";
            this.gbFormCadastro.Size = new System.Drawing.Size(733, 176);
            this.gbFormCadastro.TabIndex = 2;
            this.gbFormCadastro.TabStop = false;
            this.gbFormCadastro.Text = "Formulário de cadastro";
            this.gbFormCadastro.Enter += new System.EventHandler(this.Form1_Load);
            // 
            // txtCGCCPF
            // 
            this.txtCGCCPF.Location = new System.Drawing.Point(62, 70);
            this.txtCGCCPF.Mask = "000.000.000-00";
            this.txtCGCCPF.Name = "txtCGCCPF";
            this.txtCGCCPF.Size = new System.Drawing.Size(123, 20);
            this.txtCGCCPF.TabIndex = 20;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Gold;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(106, 93);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 31);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(62, 39);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(287, 20);
            this.txtNome.TabIndex = 12;
            // 
            // gbEnderecoCadastro
            // 
            this.gbEnderecoCadastro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbEnderecoCadastro.Controls.Add(this.txtUF);
            this.gbEnderecoCadastro.Controls.Add(this.mskCEP);
            this.gbEnderecoCadastro.Controls.Add(this.txtRua);
            this.gbEnderecoCadastro.Controls.Add(this.txtNumero);
            this.gbEnderecoCadastro.Controls.Add(this.txtBairro);
            this.gbEnderecoCadastro.Controls.Add(this.txtCidade);
            this.gbEnderecoCadastro.Controls.Add(this.label9);
            this.gbEnderecoCadastro.Controls.Add(this.label8);
            this.gbEnderecoCadastro.Controls.Add(this.label7);
            this.gbEnderecoCadastro.Controls.Add(this.label6);
            this.gbEnderecoCadastro.Controls.Add(this.label5);
            this.gbEnderecoCadastro.Controls.Add(this.label3);
            this.gbEnderecoCadastro.Location = new System.Drawing.Point(374, 19);
            this.gbEnderecoCadastro.Name = "gbEnderecoCadastro";
            this.gbEnderecoCadastro.Size = new System.Drawing.Size(353, 100);
            this.gbEnderecoCadastro.TabIndex = 11;
            this.gbEnderecoCadastro.TabStop = false;
            this.gbEnderecoCadastro.Text = "Endereço/Contato";
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(129, 25);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(47, 20);
            this.txtUF.TabIndex = 20;
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(40, 26);
            this.mskCEP.Mask = "00.000-00";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(69, 20);
            this.mskCEP.TabIndex = 19;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(40, 48);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(181, 20);
            this.txtRua.TabIndex = 18;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(282, 48);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(57, 20);
            this.txtNumero.TabIndex = 17;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(40, 71);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(136, 20);
            this.txtBairro.TabIndex = 16;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(221, 25);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(118, 20);
            this.txtCidade.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(108, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "UF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(6, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Rua";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(232, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Número";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Bairro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(175, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "CEP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 10;
            // 
            // lblCGCCPF
            // 
            this.lblCGCCPF.AutoSize = true;
            this.lblCGCCPF.Location = new System.Drawing.Point(29, 71);
            this.lblCGCCPF.Name = "lblCGCCPF";
            this.lblCGCCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCGCCPF.TabIndex = 9;
            this.lblCGCCPF.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome";
            // 
            // gbTipoPessoa
            // 
            this.gbTipoPessoa.Controls.Add(this.rdJuridica);
            this.gbTipoPessoa.Controls.Add(this.rdFisica);
            this.gbTipoPessoa.Location = new System.Drawing.Point(200, 71);
            this.gbTipoPessoa.Name = "gbTipoPessoa";
            this.gbTipoPessoa.Size = new System.Drawing.Size(149, 41);
            this.gbTipoPessoa.TabIndex = 7;
            this.gbTipoPessoa.TabStop = false;
            this.gbTipoPessoa.Text = "Tipo Pessoa";
            // 
            // rdJuridica
            // 
            this.rdJuridica.AutoSize = true;
            this.rdJuridica.Location = new System.Drawing.Point(80, 18);
            this.rdJuridica.Name = "rdJuridica";
            this.rdJuridica.Size = new System.Drawing.Size(63, 17);
            this.rdJuridica.TabIndex = 7;
            this.rdJuridica.Text = "Jurídica";
            this.rdJuridica.UseVisualStyleBackColor = true;
            this.rdJuridica.CheckedChanged += new System.EventHandler(this.rdJuridica_CheckedChanged);
            // 
            // rdFisica
            // 
            this.rdFisica.AutoSize = true;
            this.rdFisica.Checked = true;
            this.rdFisica.Location = new System.Drawing.Point(20, 18);
            this.rdFisica.Name = "rdFisica";
            this.rdFisica.Size = new System.Drawing.Size(54, 17);
            this.rdFisica.TabIndex = 6;
            this.rdFisica.TabStop = true;
            this.rdFisica.Text = "Física";
            this.rdFisica.UseVisualStyleBackColor = true;
            this.rdFisica.CheckedChanged += new System.EventHandler(this.rdFisica_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Convênio";
            // 
            // cboConvenio
            // 
            this.cboConvenio.FormattingEnabled = true;
            this.cboConvenio.Location = new System.Drawing.Point(61, 96);
            this.cboConvenio.Name = "cboConvenio";
            this.cboConvenio.Size = new System.Drawing.Size(124, 21);
            this.cboConvenio.TabIndex = 2;
            // 
            // gbConteudo
            // 
            this.gbConteudo.Controls.Add(this.gridPaciente);
            this.gbConteudo.Location = new System.Drawing.Point(17, 231);
            this.gbConteudo.Name = "gbConteudo";
            this.gbConteudo.Size = new System.Drawing.Size(1034, 263);
            this.gbConteudo.TabIndex = 3;
            this.gbConteudo.TabStop = false;
            // 
            // gridPaciente
            // 
            this.gridPaciente.AllowUserToAddRows = false;
            this.gridPaciente.AllowUserToOrderColumns = true;
            this.gridPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPaciente.Location = new System.Drawing.Point(7, 19);
            this.gridPaciente.Name = "gridPaciente";
            this.gridPaciente.ReadOnly = true;
            this.gridPaciente.Size = new System.Drawing.Size(1021, 238);
            this.gridPaciente.TabIndex = 0;
            this.gridPaciente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPaciente_CellContentClick);
            // 
            // panelControles
            // 
            this.panelControles.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelControles.Controls.Add(this.BtnInfo);
            this.panelControles.Controls.Add(this.btnLimpar);
            this.panelControles.Controls.Add(this.btnExcluir);
            this.panelControles.Controls.Add(this.btnSalvar);
            this.panelControles.Location = new System.Drawing.Point(756, 42);
            this.panelControles.Name = "panelControles";
            this.panelControles.Size = new System.Drawing.Size(289, 173);
            this.panelControles.TabIndex = 4;
            // 
            // BtnInfo
            // 
            this.BtnInfo.BackColor = System.Drawing.Color.Blue;
            this.BtnInfo.BackgroundImage = global::Devs2Blu.ProjetosAula.SistemaCadastro.Forms.Properties.Resources.update;
            this.BtnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInfo.ForeColor = System.Drawing.Color.White;
            this.BtnInfo.Location = new System.Drawing.Point(16, 90);
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.Size = new System.Drawing.Size(79, 58);
            this.BtnInfo.TabIndex = 15;
            this.BtnInfo.UseVisualStyleBackColor = false;
            this.BtnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.BackgroundImage = global::Devs2Blu.ProjetosAula.SistemaCadastro.Forms.Properties.Resources.btnIconExcluir;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(106, 16);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 58);
            this.btnExcluir.TabIndex = 0;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSalvar.BackgroundImage = global::Devs2Blu.ProjetosAula.SistemaCadastro.Forms.Properties.Resources.btnIconSalvar;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(16, 16);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 58);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1062, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 557);
            this.Controls.Add(this.gbConteudo);
            this.Controls.Add(this.panelControles);
            this.Controls.Add(this.gbFormCadastro);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "+Devs2Blu - Sistema Hospitalar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbFormCadastro.ResumeLayout(false);
            this.gbFormCadastro.PerformLayout();
            this.gbEnderecoCadastro.ResumeLayout(false);
            this.gbEnderecoCadastro.PerformLayout();
            this.gbTipoPessoa.ResumeLayout(false);
            this.gbTipoPessoa.PerformLayout();
            this.gbConteudo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPaciente)).EndInit();
            this.panelControles.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFormCadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboConvenio;
        private System.Windows.Forms.GroupBox gbTipoPessoa;
        private System.Windows.Forms.RadioButton rdJuridica;
        private System.Windows.Forms.RadioButton rdFisica;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCGCCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbEnderecoCadastro;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox gbConteudo;
        private System.Windows.Forms.Panel panelControles;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView gridPaciente;
        private System.Windows.Forms.Button BtnInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox txtCGCCPF;
        private System.Windows.Forms.TextBox txtUF;
    }
}


namespace Devs2Blu.SlnAgendaContato2.AgendaContato2.Main
{
    partial class CompromissosForm
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
            this.gbCompromissos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboContatos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gridCompromissos = new System.Windows.Forms.DataGridView();
            this.gbCompromissos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompromissos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCompromissos
            // 
            this.gbCompromissos.Controls.Add(this.btnLimpar);
            this.gbCompromissos.Controls.Add(this.btnSalvar);
            this.gbCompromissos.Controls.Add(this.label6);
            this.gbCompromissos.Controls.Add(this.label5);
            this.gbCompromissos.Controls.Add(this.txtDescricao);
            this.gbCompromissos.Controls.Add(this.txtTitulo);
            this.gbCompromissos.Controls.Add(this.cboStatus);
            this.gbCompromissos.Controls.Add(this.label4);
            this.gbCompromissos.Controls.Add(this.dtFim);
            this.gbCompromissos.Controls.Add(this.dtInicio);
            this.gbCompromissos.Controls.Add(this.label3);
            this.gbCompromissos.Controls.Add(this.label2);
            this.gbCompromissos.Controls.Add(this.label1);
            this.gbCompromissos.Controls.Add(this.cboContatos);
            this.gbCompromissos.Location = new System.Drawing.Point(23, 12);
            this.gbCompromissos.Name = "gbCompromissos";
            this.gbCompromissos.Size = new System.Drawing.Size(696, 177);
            this.gbCompromissos.TabIndex = 0;
            this.gbCompromissos.TabStop = false;
            this.gbCompromissos.Text = "Adicionar Compromisso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contatos";
            // 
            // cboContatos
            // 
            this.cboContatos.FormattingEnabled = true;
            this.cboContatos.Location = new System.Drawing.Point(81, 20);
            this.cboContatos.Name = "cboContatos";
            this.cboContatos.Size = new System.Drawing.Size(242, 21);
            this.cboContatos.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data Fim";
            // 
            // dtInicio
            // 
            this.dtInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInicio.Location = new System.Drawing.Point(81, 75);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(129, 20);
            this.dtInicio.TabIndex = 4;
            this.dtInicio.Value = new System.DateTime(2022, 10, 17, 0, 0, 0, 0);
            // 
            // dtFim
            // 
            this.dtFim.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFim.Location = new System.Drawing.Point(81, 106);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(129, 20);
            this.dtFim.TabIndex = 5;
            this.dtFim.Value = new System.DateTime(2022, 10, 17, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Titulo";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(279, 75);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(92, 21);
            this.cboStatus.TabIndex = 7;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(81, 45);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(242, 20);
            this.txtTitulo.TabIndex = 8;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(390, 24);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(272, 95);
            this.txtDescricao.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Descricao";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Status";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Lime;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(19, 134);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Yellow;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Location = new System.Drawing.Point(112, 134);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // gridCompromissos
            // 
            this.gridCompromissos.AllowUserToAddRows = false;
            this.gridCompromissos.AllowUserToOrderColumns = true;
            this.gridCompromissos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCompromissos.Location = new System.Drawing.Point(23, 196);
            this.gridCompromissos.Name = "gridCompromissos";
            this.gridCompromissos.ReadOnly = true;
            this.gridCompromissos.Size = new System.Drawing.Size(696, 231);
            this.gridCompromissos.TabIndex = 1;
            // 
            // CompromissosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 450);
            this.Controls.Add(this.gridCompromissos);
            this.Controls.Add(this.gbCompromissos);
            this.Name = "CompromissosForm";
            this.Text = "Agenda de Compromissos";
            this.Activated += new System.EventHandler(this.CompromissosForm_Activated);
            this.Load += new System.EventHandler(this.CompromissosForm_Load);
            this.gbCompromissos.ResumeLayout(false);
            this.gbCompromissos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompromissos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCompromissos;
        private System.Windows.Forms.ComboBox cboContatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gridCompromissos;
    }
}
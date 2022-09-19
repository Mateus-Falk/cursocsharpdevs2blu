namespace Devs2Blu.ProjetosAula.AulaOOP1INT
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
            this.gbCadastroFuncionario = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.gbControle = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.gbTipoFuncionario = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtControle = new System.Windows.Forms.TextBox();
            this.rdRecepcionista = new System.Windows.Forms.RadioButton();
            this.rdDiretor = new System.Windows.Forms.RadioButton();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.gbCadastroFuncionario.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbControle.SuspendLayout();
            this.gbTipoFuncionario.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCadastroFuncionario
            // 
            this.gbCadastroFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gbCadastroFuncionario.Controls.Add(this.txtSobrenome);
            this.gbCadastroFuncionario.Controls.Add(this.gbTipoFuncionario);
            this.gbCadastroFuncionario.Controls.Add(this.txtIdade);
            this.gbCadastroFuncionario.Controls.Add(this.label4);
            this.gbCadastroFuncionario.Controls.Add(this.txtEndereco);
            this.gbCadastroFuncionario.Controls.Add(this.txtNome);
            this.gbCadastroFuncionario.Controls.Add(this.label2);
            this.gbCadastroFuncionario.Controls.Add(this.label1);
            this.gbCadastroFuncionario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbCadastroFuncionario.Location = new System.Drawing.Point(12, 12);
            this.gbCadastroFuncionario.Name = "gbCadastroFuncionario";
            this.gbCadastroFuncionario.Size = new System.Drawing.Size(394, 426);
            this.gbCadastroFuncionario.TabIndex = 0;
            this.gbCadastroFuncionario.TabStop = false;
            this.gbCadastroFuncionario.Text = "Cadastro de Funcionários";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Cyan;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // gbStatus
            // 
            this.gbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gbStatus.Controls.Add(this.txtStatus);
            this.gbStatus.Location = new System.Drawing.Point(425, 12);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(319, 235);
            this.gbStatus.TabIndex = 1;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // gbControle
            // 
            this.gbControle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gbControle.Controls.Add(this.btnLimpar);
            this.gbControle.Controls.Add(this.btnSalvar);
            this.gbControle.Controls.Add(this.txtControle);
            this.gbControle.Location = new System.Drawing.Point(425, 267);
            this.gbControle.Name = "gbControle";
            this.gbControle.Size = new System.Drawing.Size(319, 171);
            this.gbControle.TabIndex = 2;
            this.gbControle.TabStop = false;
            this.gbControle.Text = "Controle";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.Cyan;
            this.txtNome.Location = new System.Drawing.Point(75, 38);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(163, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.Color.Cyan;
            this.txtEndereco.Location = new System.Drawing.Point(112, 113);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(267, 20);
            this.txtEndereco.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Cyan;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(12, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Idade";
            // 
            // txtIdade
            // 
            this.txtIdade.BackColor = System.Drawing.Color.Cyan;
            this.txtIdade.Location = new System.Drawing.Point(75, 73);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(87, 20);
            this.txtIdade.TabIndex = 7;
            // 
            // gbTipoFuncionario
            // 
            this.gbTipoFuncionario.BackColor = System.Drawing.Color.Cyan;
            this.gbTipoFuncionario.Controls.Add(this.rdDiretor);
            this.gbTipoFuncionario.Controls.Add(this.rdRecepcionista);
            this.gbTipoFuncionario.Location = new System.Drawing.Point(28, 187);
            this.gbTipoFuncionario.Name = "gbTipoFuncionario";
            this.gbTipoFuncionario.Size = new System.Drawing.Size(319, 170);
            this.gbTipoFuncionario.TabIndex = 3;
            this.gbTipoFuncionario.TabStop = false;
            this.gbTipoFuncionario.Text = "Tipo Funcionário";
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.Cyan;
            this.txtStatus.Location = new System.Drawing.Point(22, 20);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatus.Size = new System.Drawing.Size(269, 197);
            this.txtStatus.TabIndex = 0;
            this.txtStatus.Text = "Cadastrando Funcionários ...";
            // 
            // txtControle
            // 
            this.txtControle.BackColor = System.Drawing.Color.Cyan;
            this.txtControle.Location = new System.Drawing.Point(25, 19);
            this.txtControle.Multiline = true;
            this.txtControle.Name = "txtControle";
            this.txtControle.ReadOnly = true;
            this.txtControle.Size = new System.Drawing.Size(266, 146);
            this.txtControle.TabIndex = 1;
            // 
            // rdRecepcionista
            // 
            this.rdRecepcionista.AutoSize = true;
            this.rdRecepcionista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdRecepcionista.Location = new System.Drawing.Point(19, 43);
            this.rdRecepcionista.Name = "rdRecepcionista";
            this.rdRecepcionista.Size = new System.Drawing.Size(128, 24);
            this.rdRecepcionista.TabIndex = 0;
            this.rdRecepcionista.TabStop = true;
            this.rdRecepcionista.Text = "Recepcionista";
            this.rdRecepcionista.UseVisualStyleBackColor = true;
            // 
            // rdDiretor
            // 
            this.rdDiretor.AutoSize = true;
            this.rdDiretor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDiretor.Location = new System.Drawing.Point(153, 43);
            this.rdDiretor.Name = "rdDiretor";
            this.rdDiretor.Size = new System.Drawing.Size(75, 24);
            this.rdDiretor.TabIndex = 1;
            this.rdDiretor.TabStop = true;
            this.rdDiretor.Text = "Diretor";
            this.rdDiretor.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Lime;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(73, 45);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(177, 44);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Red;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpar.Location = new System.Drawing.Point(73, 95);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(177, 45);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.BackColor = System.Drawing.Color.Cyan;
            this.txtSobrenome.Location = new System.Drawing.Point(244, 38);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(150, 20);
            this.txtSobrenome.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbControle);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.gbCadastroFuncionario);
            this.Name = "Form1";
            this.Text = "Aula OOP1 - Sistema de Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCadastroFuncionario.ResumeLayout(false);
            this.gbCadastroFuncionario.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbControle.ResumeLayout(false);
            this.gbControle.PerformLayout();
            this.gbTipoFuncionario.ResumeLayout(false);
            this.gbTipoFuncionario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCadastroFuncionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.GroupBox gbControle;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox gbTipoFuncionario;
        private System.Windows.Forms.RadioButton rdDiretor;
        private System.Windows.Forms.RadioButton rdRecepcionista;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtControle;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtSobrenome;
    }
}


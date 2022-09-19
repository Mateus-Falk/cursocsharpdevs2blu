namespace Jogo21_2
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
            this.gbPlayer1 = new System.Windows.Forms.GroupBox();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.txtJogadaPlayer1 = new System.Windows.Forms.TextBox();
            this.btnPlayer1 = new System.Windows.Forms.Button();
            this.gbPlayer2 = new System.Windows.Forms.GroupBox();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.txtJogadaPlayer2 = new System.Windows.Forms.TextBox();
            this.btnPlayer2 = new System.Windows.Forms.Button();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnNovoJogo = new System.Windows.Forms.Button();
            this.gbPlayer1.SuspendLayout();
            this.gbPlayer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPlayer1
            // 
            this.gbPlayer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbPlayer1.Controls.Add(this.txtPlayer1);
            this.gbPlayer1.Controls.Add(this.txtJogadaPlayer1);
            this.gbPlayer1.Controls.Add(this.btnPlayer1);
            this.gbPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPlayer1.ForeColor = System.Drawing.Color.Navy;
            this.gbPlayer1.Location = new System.Drawing.Point(23, 34);
            this.gbPlayer1.Name = "gbPlayer1";
            this.gbPlayer1.Size = new System.Drawing.Size(274, 375);
            this.gbPlayer1.TabIndex = 0;
            this.gbPlayer1.TabStop = false;
            this.gbPlayer1.Text = "Player 1";
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.BackColor = System.Drawing.Color.Lime;
            this.txtPlayer1.ForeColor = System.Drawing.Color.Navy;
            this.txtPlayer1.Location = new System.Drawing.Point(23, 30);
            this.txtPlayer1.Multiline = true;
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPlayer1.Size = new System.Drawing.Size(224, 268);
            this.txtPlayer1.TabIndex = 2;
            // 
            // txtJogadaPlayer1
            // 
            this.txtJogadaPlayer1.BackColor = System.Drawing.Color.Red;
            this.txtJogadaPlayer1.ForeColor = System.Drawing.Color.Navy;
            this.txtJogadaPlayer1.Location = new System.Drawing.Point(23, 325);
            this.txtJogadaPlayer1.Name = "txtJogadaPlayer1";
            this.txtJogadaPlayer1.Size = new System.Drawing.Size(100, 31);
            this.txtJogadaPlayer1.TabIndex = 1;
            this.txtJogadaPlayer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPlayer1
            // 
            this.btnPlayer1.BackColor = System.Drawing.Color.Red;
            this.btnPlayer1.Location = new System.Drawing.Point(129, 322);
            this.btnPlayer1.Name = "btnPlayer1";
            this.btnPlayer1.Size = new System.Drawing.Size(110, 36);
            this.btnPlayer1.TabIndex = 0;
            this.btnPlayer1.Text = "OK";
            this.btnPlayer1.UseVisualStyleBackColor = false;
            this.btnPlayer1.Click += new System.EventHandler(this.btnPlayer1_Click);
            // 
            // gbPlayer2
            // 
            this.gbPlayer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbPlayer2.Controls.Add(this.txtPlayer2);
            this.gbPlayer2.Controls.Add(this.txtJogadaPlayer2);
            this.gbPlayer2.Controls.Add(this.btnPlayer2);
            this.gbPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPlayer2.ForeColor = System.Drawing.Color.Navy;
            this.gbPlayer2.Location = new System.Drawing.Point(524, 34);
            this.gbPlayer2.Name = "gbPlayer2";
            this.gbPlayer2.Size = new System.Drawing.Size(264, 375);
            this.gbPlayer2.TabIndex = 3;
            this.gbPlayer2.TabStop = false;
            this.gbPlayer2.Text = "Player 2";
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.BackColor = System.Drawing.Color.Lime;
            this.txtPlayer2.ForeColor = System.Drawing.Color.Navy;
            this.txtPlayer2.Location = new System.Drawing.Point(22, 48);
            this.txtPlayer2.Multiline = true;
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPlayer2.Size = new System.Drawing.Size(216, 268);
            this.txtPlayer2.TabIndex = 2;
            // 
            // txtJogadaPlayer2
            // 
            this.txtJogadaPlayer2.BackColor = System.Drawing.Color.Red;
            this.txtJogadaPlayer2.ForeColor = System.Drawing.Color.Navy;
            this.txtJogadaPlayer2.Location = new System.Drawing.Point(22, 325);
            this.txtJogadaPlayer2.Name = "txtJogadaPlayer2";
            this.txtJogadaPlayer2.Size = new System.Drawing.Size(100, 31);
            this.txtJogadaPlayer2.TabIndex = 1;
            this.txtJogadaPlayer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPlayer2
            // 
            this.btnPlayer2.BackColor = System.Drawing.Color.Red;
            this.btnPlayer2.Enabled = false;
            this.btnPlayer2.Location = new System.Drawing.Point(128, 322);
            this.btnPlayer2.Name = "btnPlayer2";
            this.btnPlayer2.Size = new System.Drawing.Size(110, 36);
            this.btnPlayer2.TabIndex = 0;
            this.btnPlayer2.Text = "OK";
            this.btnPlayer2.UseVisualStyleBackColor = false;
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.Color.Lime;
            this.txtConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsole.ForeColor = System.Drawing.Color.Navy;
            this.txtConsole.Location = new System.Drawing.Point(303, 117);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole.Size = new System.Drawing.Size(208, 292);
            this.txtConsole.TabIndex = 3;
            this.txtConsole.Text = "Bem Vindo ao jogo 21";
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Red;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(303, 34);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(208, 37);
            this.btnIniciar.TabIndex = 4;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnNovoJogo
            // 
            this.btnNovoJogo.BackColor = System.Drawing.Color.Red;
            this.btnNovoJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoJogo.Location = new System.Drawing.Point(303, 74);
            this.btnNovoJogo.Name = "btnNovoJogo";
            this.btnNovoJogo.Size = new System.Drawing.Size(208, 37);
            this.btnNovoJogo.TabIndex = 7;
            this.btnNovoJogo.Text = "Novo Jogo";
            this.btnNovoJogo.UseVisualStyleBackColor = false;
            this.btnNovoJogo.Click += new System.EventHandler(this.btnNovoJogo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNovoJogo);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.gbPlayer2);
            this.Controls.Add(this.gbPlayer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPlayer1.ResumeLayout(false);
            this.gbPlayer1.PerformLayout();
            this.gbPlayer2.ResumeLayout(false);
            this.gbPlayer2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPlayer1;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.TextBox txtJogadaPlayer1;
        private System.Windows.Forms.Button btnPlayer1;
        private System.Windows.Forms.GroupBox gbPlayer2;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.TextBox txtJogadaPlayer2;
        private System.Windows.Forms.Button btnPlayer2;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnNovoJogo;
    }
}


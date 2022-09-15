using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo21_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int jogadaPlayer1;
        public int jogadaPlayer2;
        public int jogadaExtra;
        public int pontuacaoRodadaPlayer1;
        public int pontuacaoRodadaPlayer2;
        public int pontuacaoTotalPlayer1;
        public int pontuacaoTotalPlayer2;
        public int contador = 1;


        private void Form1_Load(object sender, EventArgs e)
        {
            txtConsole.Text += "\r\nPrecione \"Iniciar\" para começar";
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            txtConsole.Text += "\r\nFaça uma aposta entre 1 e 20 e pressione OK";
            txtJogadaPlayer1.Focus();
        }

        private void btnPlayer1_Click(object sender, EventArgs e)
        {

            if (contador < 4)
            {
                jogadaPlayer1 = Int32.Parse(txtJogadaPlayer1.Text);
                txtConsole.Text = "Aguardando jogador 2...";
                Thread.Sleep(2000);

                Random rd = new Random();
                jogadaPlayer2 = rd.Next(1, 20);
                jogadaExtra = rd.Next(1, 20);

                txtJogadaPlayer2.Text = jogadaPlayer2.ToString();

                pontuacaoRodadaPlayer1 = jogadaPlayer1 + jogadaExtra;
                pontuacaoRodadaPlayer2 = jogadaPlayer2 + jogadaExtra;

                switches();
                
                txtConsole.Text += $"\r\nJogada Extra: {jogadaExtra}";
                txtPlayer1.Text += $"\r\nPontuação: {pontuacaoTotalPlayer1}";
                txtPlayer2.Text += $"\r\nPontuação: {pontuacaoTotalPlayer2}";
                contador++;
                if(contador < 4)
                {
                    txtConsole.Text += "\r\nFaça uma aposta entre 1 e 20 e pressione OK";
                    txtJogadaPlayer1.Focus();
                }
                else
                {
                    txtConsole.Clear();
                    if (pontuacaoTotalPlayer1 > pontuacaoTotalPlayer2)
                    {
                        txtConsole.Text += "\r\nPlayer 1 venceu";
                    }
                    else if (pontuacaoTotalPlayer1 < pontuacaoTotalPlayer2)
                    {
                        txtConsole.Text += "\r\nPlayer 2 venceu";
                    }
                    else
                    {
                        txtConsole.Text += "\r\nEmpate";
                    }
                    txtConsole.Text += "\r\nPrecione \"Novo Jogo\" para reiniciar";


                }

            }
            
        }

       private void btnNovoJogo_Click(object sender, EventArgs e)
        {
            txtConsole.Clear();
            txtJogadaPlayer1.Clear();
            txtJogadaPlayer2.Clear();
            txtPlayer1.Clear();
            txtPlayer2.Clear();
            txtConsole.Text += "\r\nPrecione \"Iniciar\" para começar";
            contador = 1;
            pontuacaoTotalPlayer1 = 0;
            pontuacaoTotalPlayer2 = 0;
        }
    
        private void switches()
        {
            switch (pontuacaoRodadaPlayer1)
            {
                case int i when i > 0 && i < 7:
                    pontuacaoTotalPlayer1 += 1;
                    break;
                case 7:
                    pontuacaoTotalPlayer1 += 10;
                    break;
                case int i when i > 7 && i < 14:
                    pontuacaoTotalPlayer1 += 5;
                    break;
                case 14:
                    pontuacaoTotalPlayer1 += 20;
                    break;
                case int i when i > 14 && i < 21:
                    pontuacaoTotalPlayer1 += 6;
                    break;
                case 21:
                    pontuacaoTotalPlayer1 += 30;
                    break;
                default:
                    break;
            }
            switch (pontuacaoRodadaPlayer2)
            {
                case int i when i > 0 && i < 7:
                    pontuacaoTotalPlayer2 += 1;
                    break;
                case 7:
                    pontuacaoTotalPlayer2 += 10;
                    break;
                case int i when i > 7 && i < 14:
                    pontuacaoTotalPlayer2 += 5;
                    break;
                case 14:
                    pontuacaoTotalPlayer2 += 20;
                    break;
                case int i when i > 14 && i < 21:
                    pontuacaoTotalPlayer2 += 6;
                    break;
                case 21:
                    pontuacaoTotalPlayer2 += 30;
                    break;
                default:
                    break;
            }
        }
    }

}

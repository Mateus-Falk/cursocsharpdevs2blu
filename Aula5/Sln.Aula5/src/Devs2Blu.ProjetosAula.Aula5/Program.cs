using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.Aula5
{
    class Program
    {
        static void Main(string[] args)
        {

            Exercicio3();
        }

        static void Exercicio5() 
        {
            const int PT7 = 10;
            const int PT14 = 20;
            const int PT21 = 30;
            const int PT1A6 = 1;
            const int PT8A13 = 5;
            const int PT15A20 = 6;

            int pontuacaoFinalPlayer, pontuacaoFinalNPC;

            Console.WriteLine(@"**********************
***** Cassino ********
****** Jogo **********
******* de ***********
******* 21 ***********
**********************");

            Console.WriteLine("Informe sua jogada: ");
            string jogadaPlayer1STR = Console.ReadLine();
            Int32.TryParse(jogadaPlayer1STR, out int jogadaPlayer1);

            Random rd = new Random();
            int jogadaNPC1 = rd.Next(1,20);
            int jogadaBoth = rd.Next(1,20);

            int pontuacaoPlayer = jogadaPlayer1 + jogadaBoth;
            int pontuacaoNPC = jogadaNPC1 + jogadaBoth;
            
            


            switch (pontuacaoPlayer)
            {   
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    pontuacaoFinalPlayer = PT1A6;
                    break; 
                case 7:
                    pontuacaoFinalPlayer = PT7;
                    break;
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                    pontuacaoFinalPlayer = PT8A13;
                    break;
                case 14:
                    pontuacaoFinalPlayer = PT14;
                    break;
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    pontuacaoFinalPlayer = PT15A20;
                    break;
                case 21:
                    pontuacaoFinalPlayer = PT21;
                    break;
                default:
                    pontuacaoFinalPlayer = 0;
                    break;
            }

            switch (pontuacaoNPC)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    pontuacaoFinalNPC = PT1A6;
                    break;
                case 7:
                    pontuacaoFinalNPC = PT7;
                    break;
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                    pontuacaoFinalNPC = PT8A13;
                    break;
                case 14:
                    pontuacaoFinalNPC = PT14;
                    break;
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    pontuacaoFinalNPC = PT15A20;
                    break;
                case 21:
                    pontuacaoFinalNPC = PT21;
                    break;
                default:
                    pontuacaoFinalNPC = 0;
                    break;
            }





            if (pontuacaoFinalPlayer > pontuacaoFinalNPC)
            {
                Console.WriteLine("YOU WON (:");
            }
            else if (pontuacaoFinalPlayer < pontuacaoFinalNPC)
            {
                
                Console.WriteLine("YOU LOST )=");
            }
            else
            {
                Console.WriteLine("Draw");
            }

            Console.WriteLine("p"+jogadaPlayer1);
            Console.WriteLine("c"+jogadaNPC1);
            Console.WriteLine(jogadaBoth);

        }

        static void Exercicio3()
        {
 
            string resultado = "Resultado: ";
            Console.WriteLine(@"*************
*CALCULADORA*
*************

");
            Console.WriteLine("Escolha a operação matematica que deseja efetuar");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Muliplicação");
            Console.WriteLine("4 - Divisão");
            string operacao = Console.ReadLine();

            Random rd = new Random();
            int numero1 = rd.Next(1,100);
            int numero2 = rd.Next(1,100);

            Console.WriteLine($"Primeiro número: {numero1}");
            Console.WriteLine($"Segundo número: {numero2}");

            switch (operacao.ToUpper())
            {
                case "1":
                    resultado += numero1 + numero2;
                    break;
                case "2":
                    resultado += numero1 - numero2;
                    break;
                case "3":
                    resultado += numero1 * numero2;
                    break;
                case "4":
                    resultado += numero1 / numero2;
                    break;
                default:
                    ;
                    break;
            }
            Console.WriteLine(resultado);
            
        }
        static void Exercicio2()
        {
            const string HATCH = "HATCH";
            const string SEDAM = "SEDAM";
            const string MOTOCILCLETA = "MOTOCICLETA";
            const string CAMINHONETE = "CAMINHONETE";

            Console.WriteLine("|***** Revenda de carros ******|\n\n");
            Console.WriteLine("Escolha o veiculo que deseja adquirir");
            Console.WriteLine("Hatch");
            Console.WriteLine("Sedam");
            Console.WriteLine("Motocicleta");
            Console.WriteLine("Caminhonete");
            string tipoCarro = Console.ReadLine();

            switch (tipoCarro.ToUpper())
            {
                case HATCH:
                    Console.WriteLine("Compra efetuava com sucesso");
                    break;
                case SEDAM:
                case MOTOCILCLETA:
                case CAMINHONETE:
                    Console.WriteLine("Tem certeza que não prefere este modelo?");
                    break;   
                default:
                    Console.WriteLine("Não trabalhamos com este tipo de automóvel aqui");
                    break;
            }
        }
        static void Exercicio1()
        {
            Console.WriteLine("|***** Programa da feira *****|\n\n");
            Console.WriteLine("Informe uma fruta: ");
            Console.WriteLine("Maçã");
            Console.WriteLine("Kiwi");
            Console.WriteLine("Melancia");
            string fruta = Console.ReadLine();

            

            switch (fruta.ToUpper())
            {
                case "MAÇÃ":
                    Console.WriteLine("Não vendemos essa fruta aqui");
                    break;
                case "KIWI":
                    Console.WriteLine("Estamos com escassez de kiwis");
                    break;
                case "MELANCIA":
                    Console.WriteLine("Aqui está, são 3 reais o quilo");
                    break;
                default:
                    Console.WriteLine("Produto inválido!");
                    break;
            }
        }
        static void Exemplo1()
        {
            Console.WriteLine("Informe o código");
            Console.WriteLine("- A21");
            Console.WriteLine("- A22");
            Console.WriteLine("- A23");
            Console.WriteLine("- A24");
            Console.WriteLine("- A35");
            Console.WriteLine("- Z16");

            const string A21 = "A21";
            const string A22 = "A22";
            const string A23 = "A23";
            const string A24 = "A24";
            const string A35 = "A35";
            const string Z16 = "Z16";

            string codigo = Console.ReadLine();

            switch (codigo.ToUpper())
            {
                case A21:
                case A22:
                case A23:
                case A24:
                    Console.WriteLine("Materiais");
                    break;
                case A35:
                    Console.WriteLine("Produtos Perecíveis");
                    break;
                case Z16:
                    Console.WriteLine("Produtos Químicos");
                    break;
                default:
                    Console.WriteLine("Produto não cadastrado");
                    break ;
            }

            /*- "A23" : Materiais
              - "A35": Produtos Perecíveis
              - "Z16": Produtos Químicos*/
        }
    }
}

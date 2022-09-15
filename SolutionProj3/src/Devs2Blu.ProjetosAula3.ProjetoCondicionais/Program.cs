using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula3.ProjetoCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            teste2();

            
        }
        static void teste2()
        {
            Console.WriteLine("|*** Programa que informa tipo de triângulo ***|\n\n");

            Console.WriteLine("Informe a medida do lado 1 do triângulo: ");
            string lado1STR = Console.ReadLine();
            Int32.TryParse(lado1STR, out int lado1);

            Console.WriteLine("Informe a medida do lado 2 do triângulo: ");
            string lado2STR = Console.ReadLine();
            Int32.TryParse(lado2STR, out int lado2);

            Console.WriteLine("Informe a medida do lado 3 do triângulo: ");
            string lado3STR = Console.ReadLine();
            Int32.TryParse(lado3STR, out int lado3);

            if ((lado1 == lado2) && (lado2 == lado3)){
                Console.WriteLine("Triângulo Equilátero!");
            }else if((lado2==lado3) || (lado1 == lado3) || (lado1 == lado2)){
                Console.WriteLine("Triângulo Isósceles!");
            }else {
                Console.WriteLine("Triângulo Escaleno!");
            }

        }

        static void teste()
        {
            double maca, preco;

            Console.Write("Quantidade de maçãs compradas: ");
            string macaSTR = Console.ReadLine();
            double.TryParse(macaSTR, out maca);

            if (maca > 12)
            {
                Console.WriteLine("O valor total das maçãs é de "+(maca*0.25)+" reais");
            } else
            {
                Console.WriteLine("O valor total das maçãs é de " + (maca * 0.30) + " reais");
            }




        }
        static void Exercicio2e2()
        {
            int valor1, valor2, valor3, valor4;
            int menorValor = 99999999;

            Console.WriteLine("Programa que verifica qual valor o menor valor entre quatro valores!\n\n");

            Console.WriteLine("Informe o valor 1");
            string vl1STR = Console.ReadLine();
            Int32.TryParse(vl1STR, out valor1);

            Console.WriteLine("Informe o valor 2");
            string vl2STR = Console.ReadLine();
            Int32.TryParse(vl2STR, out valor2);

            Console.WriteLine("Informe o valor 3");
            string vl3STR = Console.ReadLine();
            Int32.TryParse(vl3STR, out valor3);

            Console.WriteLine("Informe o valor 4");
            string vl4STR = Console.ReadLine();
            Int32.TryParse(vl4STR, out valor4);

            if(valor1 < menorValor)
            {
                menorValor = valor1;
            }
            if(valor2 < menorValor)
            {
                menorValor = valor2;
            }
            if (valor3 < menorValor)
            {
                menorValor = valor3;
            }
            if (valor4 < menorValor)
            {
                menorValor = valor4;
            }
            Console.WriteLine($"O menor valor é {menorValor}");

        }
        static void Exercicio2()
        {
            int valor1, valor2, valor3, valor4;

            Console.WriteLine("Programa que verifica qual valor o menor valor entre quatro valores!\n\n");

            Console.WriteLine("Informe o valor 1");
            string vl1STR = Console.ReadLine();
            Int32.TryParse(vl1STR, out valor1);

            Console.WriteLine("Informe o valor 2");
            string vl2STR = Console.ReadLine();
            Int32.TryParse(vl2STR, out valor2);

            Console.WriteLine("Informe o valor 3");
            string vl3STR = Console.ReadLine();
            Int32.TryParse(vl3STR, out valor3);

            Console.WriteLine("Informe o valor 4");
            string vl4STR = Console.ReadLine();
            Int32.TryParse(vl4STR, out valor4);

            if (valor1 < valor2 &&
                valor1 < valor3 &&
                valor1 < valor4)
            {
                Console.WriteLine($"Valor 1 ({valor1}) é o menor");
            }else if(valor2 < valor3 &&
                       valor2<valor4)
            {
                Console.WriteLine($"Valor 2 ({valor2})é o menor");
            }
            else if (valor3 < valor4)
            {
                Console.WriteLine($"Valor 3 ({valor3})é o menor");
            }
            else
            {
                Console.WriteLine($"Valor 4 ({valor4})é o menor");
            }


        }
        static void Exercicio1()
        {

            int numero1, numero2;

            Console.WriteLine("Informe o primeiro número:");
            string numero1STR = Console.ReadLine();
            Int32.TryParse(numero1STR, out numero1);

            Console.WriteLine("Informe o segundo número:");
            string numero2STR = Console.ReadLine();
            Int32.TryParse(numero2STR, out numero2);

            if (numero1 > numero2)
            {
                Console.WriteLine($"O primeiro número é maior: ({numero1})");
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine($"O segundo número é maior: ({numero2})");
            }
            else
            {
                Console.WriteLine("Números iguais");
            }
        }
        static void Exemplo1()
        {
            string textoSaida;
            string nomeCandidato;
            int idadeCandidato, notaCandidato;

            Console.WriteLine("|***** Bem vindo ao programa SysSchool *****|\n\n");

            Console.WriteLine("Informe o nome do Candidato: ");
            nomeCandidato = Console.ReadLine();

            Console.Write("Informe a idade do Candidato: ");
            string idadeSTR = Console.ReadLine();


            if (idadeSTR.Equals(""))
            {
                Console.WriteLine("Valor inválido para Idade!");
                return;
            }
            else
            {
                idadeCandidato = Int16.Parse(idadeSTR);
            }

            Console.Write("Informe a Nota do Candidato: ");
            string notaSTR = Console.ReadLine();


            if (notaSTR.Equals(""))
            {
                Console.WriteLine("Valor inválido para Nota!");
                return;
            }
            else
            {
                notaCandidato = Int16.Parse(notaSTR);
            }

            textoSaida = $"Candidato: {nomeCandidato}\n";
            textoSaida += $"Idade: {idadeCandidato} ";

            if (idadeCandidato > 17)
            {
                textoSaida += "(Maior de idade)\n";
            }
            else
            {
                textoSaida += "(Menor de idade)\n";
            }

            textoSaida += $"Nota Final: {notaCandidato}\n\n";

            if (notaCandidato > 6)
            {
                textoSaida += @"*******************
*** APROVADO!!! ***
*******************";
            }
            else
            {
                textoSaida += "| REPROVADO :( |";
            }

            Console.WriteLine(textoSaida);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.RevisaoCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExercicioSwitch2();

        }

        static void ExercicioSwitch2()
        {
            Console.WriteLine("|*** Contini Lanchonete e Jogo do Bicho ***|");
            Console.WriteLine("Cardápio");
            Console.WriteLine("| Código |       Lanche    | Preço Unítario|");
            Console.WriteLine("|   100  | Cachorro Quente |      1,70     |");
            Console.WriteLine("|   101  |  Bauru Simples  |      2,30     |");
            Console.WriteLine("|   102  |  Bauru com Ovo  |      2,60     |");
            Console.WriteLine("|   103  |   Hamburguer    |      2,40     |");
            Console.WriteLine("|   104  |  Cheeseburguer  |      2,50     |");
            Console.WriteLine("|   105  |  Refrigerante   |      1,00     |");
            Console.WriteLine("Informe o código do lanche desejado");
            Int32.TryParse(Console.ReadLine(), out int codigo);
            Console.WriteLine("Informe a quantidade de lanches desejados");
            Int32.TryParse(Console.ReadLine(), out int quantidade);

            switch (codigo)
            {
                case 100:
                    Console.WriteLine($"O valor da compra é de: R$ {1.70 * quantidade}");
                    break;
                case 101:
                    Console.WriteLine($"O valor da compra é de: R$ {2.30 * quantidade}");
                    break;
                case 102:
                    Console.WriteLine($"O valor da compra é de: R$ {2.60 * quantidade}");
                    break;
                case 103:
                    Console.WriteLine($"O valor da compra é de: R$ {2.40 * quantidade}");
                    break;
                case 104:
                    Console.WriteLine($"O valor da compra é de: R$ {2.50 * quantidade}");
                    break;
                case 105:
                    Console.WriteLine($"O valor da compra é de: R$ {1.00 * quantidade}");
                    break;
                default:
                    break;
            }
        }
        static void ExercicioSwitch()
        {
            Console.WriteLine(@"|------------------------------------|
|************************************|
|****** MERCADINHO DA ESQUINA *******|
|************************************|
|------------------------------------|");
            Console.WriteLine("Informe o tipo de produtos desejado");
            Console.WriteLine("1 - Não-Perecíveis");
            Console.WriteLine("2 - Frutas");
            Console.WriteLine("3 - Bebidas");
            Int32.TryParse(Console.ReadLine(), out int tipoProduto);

            switch (tipoProduto)
            {
                case 1:
                    Console.WriteLine("Não-perecíveis");
                    Console.WriteLine("Escolha o produto desejado");
                    Console.WriteLine("101 - Arroz");
                    Console.WriteLine("102 - Feijão");
                    Console.WriteLine("103 - Café");
                    Int32.TryParse(Console.ReadLine(), out int Produto);

                    switch (Produto)
                    {
                        case 101:
                            Console.WriteLine("Produto escolhido: Arroz");
                            break;
                        case 102:
                            Console.WriteLine("Produto escolhido: Feijão");
                            break;
                        case 103:
                            Console.WriteLine("Produto escolhido: Café");
                            break;
                        default:
                            break;
                    }

                    break;
                case 2:
                    Console.WriteLine("Frutas");
                    Console.WriteLine("Escolha o produto desejado");
                    Console.WriteLine("201 - Manga");
                    Console.WriteLine("202 - Maçã");
                    Console.WriteLine("203 - Banana");
                    Int32.TryParse(Console.ReadLine(), out Produto);
                    

                    switch (Produto)
                    {
                        case 201:
                            Console.WriteLine("Produto escolhido: Manga");
                            break;
                        case 202:
                            Console.WriteLine("Produto escolhido: Maçã");
                            break;
                        case 203:
                            Console.WriteLine("Produto escolhido: Banana");
                            break;
                    }
                    break;

                case 3:
                    Console.WriteLine("Bebidas");
                    Console.WriteLine("Escolha o produto desejado");
                    Console.WriteLine("301 - Leite");
                    Console.WriteLine("302 - Sucos");
                    Console.WriteLine("303 - Refrigerantes");
                    Int32.TryParse(Console.ReadLine(), out Produto);
                    
                    switch (Produto)
                    {
                        case 301:
                            Console.WriteLine("Produto escolhido: Leite");
                            break;
                        case 302:
                            Console.WriteLine("Produto escolhido: Sucos");
                            break;
                        case 303:
                            Console.WriteLine("Produto escolhido: Refrigerantes");
                            break;
                    }
                    break;


                default:
                    Console.WriteLine("Produto não cadastrado");

                    break;
            }


        }

        static void Exemplo5()
        {
            Console.WriteLine("|***** Programa que calcula o peso ideal *****|\n\n");
            Console.WriteLine("Informe seu sexo:");
            Console.WriteLine("[1] Masculino");
            Console.WriteLine("[2] Feminino");

            Random rd = new Random();
            int sexo = rd.Next(1, 3);
            Console.WriteLine(sexo);

            Console.Write("Informe sua altura: ");
            string alturaSTR = Console.ReadLine();
            double.TryParse(alturaSTR, out double altura);

            bool permissao = sexo == 1 ? true : false;
            double pesoIdeal;

            
            if (permissao)
            {
                pesoIdeal = (altura * 72.7) - 58;
            }
            else
            {
                pesoIdeal = (altura * 62.1) - 44.7;
            }
            
            Console.WriteLine(pesoIdeal);


        }
        static void Exemplo4()
        {
            const string SENHA = "1234";
            Console.WriteLine("|*** Programa que verifica a senha ***|");

            Console.WriteLine("Informe a senha: ");
            string senha = Console.ReadLine();

            bool permissao = senha.Equals(SENHA) ? true : false;

            if (permissao)
            {
                Console.WriteLine("Acesso permitido");
            }
            else
            {
                Console.WriteLine("Acesso negado");
            }


        }
        static void Exemplo3()
        {
            Console.WriteLine("|*** Programa que informa se tem permição para votar ***|\n\n");
            Console.WriteLine("Ano de nascimento: ");
            string anoSTR = Console.ReadLine();
            Int32.TryParse(anoSTR, out int ano);

            string permissao = "Cidadão ";

            permissao += (DateTime.Now.Year - ano) < 16  ? "não pode votar" : "pode votar";
            Console.WriteLine(permissao);

            /*if (!permissao)
            {
                Console.WriteLine("Cidadão pode votar");
            }
            else
            {
                Console.WriteLine("Cidadão não pode votar");
            }*/
        }
        static void Exemplo2()
        {
            int numero;

            Random rd = new Random();
            numero = rd.Next(1, 100);
            
            
            if (!(numero - (numero / 2 * 2) == 0))
            {
                Console.WriteLine($"Número ímpar: {numero}");
            }
            else 
            {
                Console.WriteLine($"Número par: {numero}");
            }

        }
        static void Exemplo1()
        {
            string codigo;

            Console.WriteLine("*** Programa de procura de produto por código ***\n\n");
            Console.WriteLine("Informe o código do produto desejado");
            Console.WriteLine("001 - Arroz");
            Console.WriteLine("002 - Feijão");
            Console.WriteLine("003 - Farinha");
            //Console.WriteLine("Outro valor - Diversos");

            codigo = Console.ReadLine();
            

            if (codigo.Equals("001"))
            {
                Console.WriteLine("Produto escolhido foi arroz");
            }else if (codigo.Equals("002"))
            {
                Console.WriteLine("Produto escolhido foi feijão");
            }else if(codigo.Equals("003"))
            {
                Console.WriteLine("Produto escolhido foi farinha");
            }
            else
            {
                Console.WriteLine("Produto diverso");
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis
            string formatacaoDados = "Inicialização de variável...\n";
            string nomeUsuario, cidadeUsuario;
            
            // Entrada de dados
              // - Nome
            Console.Write("Escreva seu nome: ");
            nomeUsuario = Console.ReadLine();

              // - Cidade
            Console.Write("Informe sua cidade: ");
            cidadeUsuario = Console.ReadLine();

            // Processamento
                // - Boas vindas (Nome)
            formatacaoDados += "Seja bem vindo, " + nomeUsuario + "!\n\n";

            // - Cidade do Usuário
            formatacaoDados += $"Localidade: {cidadeUsuario}";

            // Apresentação dos dados
            Console.WriteLine(formatacaoDados);

            // Pausa antes de iniciar
            Console.WriteLine("Pressione qualquer tecla");
            var input = Console.ReadLine();
        }
    }
}

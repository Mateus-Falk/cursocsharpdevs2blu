using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enuns;
using Devs2Blu.ProjetosAula.OOP3.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroRecepcionista : IMenuCadastro
    {
        public CadastroRecepcionista()
        {

        }
        public void ListarRecepcionistas()
        {
            Console.Clear();

            foreach (Recepcionista recepcionista in Program.Mock.ListaRecepcionistas)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine($"Recepcionista: {recepcionista.CodigoRecepcionista}");
                Console.WriteLine($"Nome: {recepcionista.Nome}");
                Console.WriteLine($"CPF: {recepcionista.CGCCPF}");
                Console.WriteLine($"Setor: {recepcionista.Setor}");
                Console.WriteLine("------------------------------------\n");
            }
            Console.WriteLine("Precione 'ENTER' para voltar");
            Console.ReadLine();
        }
        public void CadastrarRecepcionista(Recepcionista novoRecepcionista)
        {
            Program.Mock.ListaRecepcionistas.Add(novoRecepcionista);
        }
        public void AlterarRecepcionista(Recepcionista recepcionista)
        {
            var recp = Program.Mock.ListaRecepcionistas.Find(r => r.CodigoRecepcionista == recepcionista.CodigoRecepcionista);
            int index = Program.Mock.ListaRecepcionistas.IndexOf(recp);
            Program.Mock.ListaRecepcionistas[index] = recepcionista;
        }
        public void ExcluirRecepcionista(Recepcionista recepcionista)
        {
            Program.Mock.ListaRecepcionistas.Remove(recepcionista);
        }
        public void ListarRecepcionistaBycodeAndName()
        {
            foreach (Recepcionista recepcionista in Program.Mock.ListaRecepcionistas)
            {
                Console.WriteLine($"| Código: {recepcionista.CodigoRecepcionista} - Nome: {recepcionista.Nome} |");
            }
            Console.WriteLine("\n");
        }
        #region facade
        public Int32 MenuCadastro()
        {
            Int32 opcao;


            Console.Clear();
            Console.WriteLine("- - - - - Cadastro de Recepcionista - - - - -");
            Console.WriteLine("- - - - - 1 - Lista de Recepcionista - - - - -");
            Console.WriteLine("- - - - - 2 - Cadastro de Recepcionista - - - - -");
            Console.WriteLine("- - - - - 3 - Alterar Recepcionista - - - - -");
            Console.WriteLine("- - - - - 4 - Excluir Recepcionista - - - - -");
            Console.WriteLine("- - - - - - - - - - - - - - - - -");
            Console.WriteLine("- - - - - 0 - Sair - - - - -");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;
        }

        public void Listar()
        {
            ListarRecepcionistas();
        }

        public void Cadastrar()
        {
            Console.Clear();
            Recepcionista recepcionista = new Recepcionista();

            Console.WriteLine("Informe o nome");
            recepcionista.Nome = Console.ReadLine();

            Console.WriteLine("Informe o CPF");
            recepcionista.CGCCPF = Console.ReadLine();

            Console.WriteLine("Informe o setor");
            recepcionista.Setor = Console.ReadLine();

            Random rd = new Random();
            recepcionista.Codigo = rd.Next(1, 100) + DateTime.Now.Second;
            recepcionista.CodigoRecepcionista = Int32.Parse($"{recepcionista.Codigo}{rd.Next(100, 999)}");

            CadastrarRecepcionista(recepcionista);
        }

        public void Alterar()
        {
            Console.Clear();
            Recepcionista recepcionista;
            int codigoRecepcionista;

            Console.WriteLine("Informe o recepcionista que deseja alterar");
            ListarRecepcionistaBycodeAndName();
            Int32.TryParse(Console.ReadLine(),out codigoRecepcionista);

            recepcionista = Program.Mock.ListaRecepcionistas.Find(r => r.CodigoRecepcionista == codigoRecepcionista);

            string opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.WriteLine($"| Recepcionista: {recepcionista.Codigo}/{recepcionista.CodigoRecepcionista} | Nome: {recepcionista.Nome} | CPF: {recepcionista.CGCCPF} | Setor: {recepcionista.Setor} |");
                Console.WriteLine("\nQual campo deseja alterar");
                Console.WriteLine("\n| 01 - Nome | 02 - CPF | 03 - Setor | 00 - Sair |");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.WriteLine("Informe um novo nome");
                        recepcionista.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CPF");
                        recepcionista.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Informe um novo setor");
                        recepcionista.Setor = Console.ReadLine();
                        break;
                    default:
                        alterar = false;
                        break;
                }
                if(alterar)
                {
                    Console.Clear();
                    Console.WriteLine("Dado alterado com sucesso");
                }
            }while(alterar);

            AlterarRecepcionista(recepcionista);
        }

        public void Excluir()
        {
            Console.Clear();
            Recepcionista recepcionista;
            int codigoRecepcionista;

            Console.WriteLine("Informe o recepcionista que deseja excluir");
            ListarRecepcionistaBycodeAndName();
            Int32.TryParse(Console.ReadLine(), out codigoRecepcionista);
            Console.Clear();
            recepcionista = Program.Mock.ListaRecepcionistas.Find(r => r.CodigoRecepcionista == codigoRecepcionista);

            Console.WriteLine($"\nTem certeza de que deseja excluir o recepcionista {recepcionista.CodigoRecepcionista}/{recepcionista.Nome}?");
            Console.WriteLine("\n| 01 - Sim | Enter - Não |");
            string opcao =Console.ReadLine();

            if (opcao.Equals("01")){
                ExcluirRecepcionista(recepcionista);
                Console.WriteLine("Recepcionista excluido com sucesso");
            }
        }
        #endregion
    }
}

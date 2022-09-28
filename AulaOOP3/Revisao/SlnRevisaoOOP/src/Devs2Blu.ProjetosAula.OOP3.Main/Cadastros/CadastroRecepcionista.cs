using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enuns;
using Devs2Blu.ProjetosAula.OOP3.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
            novoRecepcionista = new Recepcionista();
            Console.WriteLine("Informe o código");
            novoRecepcionista.CodigoRecepcionista = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome");
            novoRecepcionista.Nome = Console.ReadLine();
            Console.WriteLine("Informe o CPF");
            novoRecepcionista.CGCCPF = Console.ReadLine();
            Console.WriteLine("Informe o setor");
            novoRecepcionista.Setor = Console.ReadLine();
            Program.Mock.ListaRecepcionistas.Add(novoRecepcionista);
        }
        public void AlterarRecepcionista(Recepcionista novoRecepcionista)
        {

        }
        public void ExcluirRecepcionista(Recepcionista novoRecepcionista)
        {

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
            Recepcionista recepcionista = new Recepcionista();
            CadastrarRecepcionista(recepcionista);
        }

        public void Alterar()
        {
            Recepcionista recepcionista = new Recepcionista();
            AlterarRecepcionista(recepcionista);
        }

        public void Excluir()
        {
            Recepcionista recepcionista = new Recepcionista();
            ExcluirRecepcionista(recepcionista);
        }
        #endregion
    }
}

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
    public class CadastroFornecedor : IMenuCadastro
    {
        public CadastroFornecedor()
        {

        }
       
        public void ListarFornecedores()
        {
            Console.Clear();

            foreach (Fornecedor fornecedor in Program.Mock.ListaFornecedor)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine($"Fornecedor: {fornecedor.CodigoFornecedor}");
                Console.WriteLine($"Nome: {fornecedor.Nome}");
                Console.WriteLine($"CPF: {fornecedor.CGCCPF}");
                Console.WriteLine($"Tipo Fornecedor: {fornecedor.TipoFornecedor}");
                Console.WriteLine("------------------------------------\n");
            }
            Console.WriteLine("Precione 'ENTER' para voltar");
            Console.ReadLine();
        }
        public void CadastrarFornecedor(Fornecedor novoFornecedor)
        {
            Program.Mock.ListaFornecedor.Add(novoFornecedor);
        }
        public void AlterarFornecedor(Fornecedor fornecedor)
        {
            var forn = Program.Mock.ListaFornecedor.Find(f => f.CodigoFornecedor == fornecedor.CodigoFornecedor);
            int index = Program.Mock.ListaFornecedor.IndexOf(forn);
            Program.Mock.ListaFornecedor[index] = fornecedor;
        }
        public void ExcluirFornecedor(Fornecedor fornecedor)
        {
            Program.Mock.ListaFornecedor.Remove(fornecedor);
        }

        public void ListarFornecedorByCodeAndName()
        {
            Console.Clear();

            foreach (Fornecedor fornecedor in Program.Mock.ListaFornecedor)
            {
                Console.WriteLine($"| Código: {fornecedor.CodigoFornecedor} | Nome: {fornecedor.Nome} |");
            }
            Console.WriteLine("\n");
        }
        #region facede
        public Int32 MenuCadastro()
        {
            Int32 opcao;

            Console.Clear();
            Console.WriteLine("- - - - - Cadastro de Fornecedor - - - - -");
            Console.WriteLine("- - - - - 1 - Lista de Fornecedor - - - - -");
            Console.WriteLine("- - - - - 2 - Cadastro de Fornecedor - - - - -");
            Console.WriteLine("- - - - - 3 - Alterar Fornecedor - - - - -");
            Console.WriteLine("- - - - - 4 - Excluir Fornecedor - - - - -");
            Console.WriteLine("- - - - - - - - - - - - - - - - -");
            Console.WriteLine("- - - - - 0 - Sair - - - - -");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;

        }
        public void Listar()
        {
            ListarFornecedores();
        }
        public void Cadastrar()
        {
            Console.Clear();
            Fornecedor fornecedor = new Fornecedor();

            Console.WriteLine("Informe o nome");
            fornecedor.Nome = Console.ReadLine();

            Console.WriteLine("Informe o CNPJ");
            fornecedor.CGCCPF = Console.ReadLine();

            Console.WriteLine("Informe o tipo do fornecedor");
            fornecedor.TipoFornecedor = Console.ReadLine();

            Random rd = new Random();

            fornecedor.Codigo = rd.Next(1, 100) + DateTime.Now.Second;
            fornecedor.CodigoFornecedor = Int32.Parse($"{fornecedor.Codigo}{rd.Next(100, 999)}");

            CadastrarFornecedor(fornecedor);
        }
        public void Alterar()
        {
            Console.Clear();
            int codigoFornecedor;
            Fornecedor fornecedor;

            Console.WriteLine("Informe o fornecedor que deseja alterar");
            ListarFornecedorByCodeAndName();
            Int32.TryParse(Console.ReadLine(), out codigoFornecedor);

            Console.Clear();
            fornecedor = Program.Mock.ListaFornecedor.Find(f => f.CodigoFornecedor == codigoFornecedor);

            string opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.WriteLine($"| Fornecedor: {fornecedor.Codigo}/{fornecedor.CodigoFornecedor} | Nome: {fornecedor.Nome} | CNPJ: {fornecedor.CGCCPF} | Tipo Fornecedor: {fornecedor.TipoFornecedor}");
                Console.WriteLine("\nQual campo deseja alterar");
                Console.WriteLine($"\n| 01 - Nome | 02 - CNPJ | 03 - Tipo Fornecedor | 00 - Sair |");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.WriteLine("Informe um novo nome");
                        fornecedor.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CNPJ");
                        fornecedor.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Informe um novo tipo de Fornecedor");
                        fornecedor.TipoFornecedor = Console.ReadLine();
                        break;
                    default:
                        alterar = false;
                        break;
                }
                if (alterar)
                {
                    Console.Clear();
                    Console.WriteLine("Dado alterado com sucesso");
                }
            }while (alterar);

            AlterarFornecedor(fornecedor);
        
        }
        public void Excluir()
        {
            Console.Clear();
            Fornecedor fornecedor;
            int codigoFornecedor;

            Console.WriteLine("Informe o fornecedor que deseja excluir");
            ListarFornecedorByCodeAndName();
            Int32.TryParse(Console.ReadLine(), out codigoFornecedor);
            Console.Clear();
            fornecedor = Program.Mock.ListaFornecedor.Find(f => f.CodigoFornecedor == codigoFornecedor);

            Console.WriteLine($"Tem certeza de que deseja excluir o fornecedor {fornecedor.CodigoFornecedor}/{fornecedor.Nome}?");
            Console.WriteLine("| 01 - Sim | Enter - Não |");
            string opcao = Console.ReadLine();

            if (opcao.Equals("01"))
            {
                ExcluirFornecedor(fornecedor);
                Console.WriteLine("Dado excluido com sucesso");
            }
        }
        #endregion
    }
}

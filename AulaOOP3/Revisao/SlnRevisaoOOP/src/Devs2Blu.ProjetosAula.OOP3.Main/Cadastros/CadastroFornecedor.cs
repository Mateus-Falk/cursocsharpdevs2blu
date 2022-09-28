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
            novoFornecedor = new Fornecedor();
            Console.WriteLine("Informe o código");
            novoFornecedor.CodigoFornecedor = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome");
            novoFornecedor.Nome = Console.ReadLine();
            Console.WriteLine("Informe o CNPJ");
            novoFornecedor.CGCCPF = Console.ReadLine();
            Console.WriteLine("Informe o tipo do fornecedor");
            novoFornecedor.TipoFornecedor = Console.ReadLine();
            Program.Mock.ListaFornecedor.Add(novoFornecedor);
        }
        public void AlterarFornecedor(Fornecedor novoFornecedor)
        {

        }
        public void ExcluirFornecedor(Fornecedor novoFornecedor)
        {

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
            Fornecedor fornecedor = new Fornecedor();
            CadastrarFornecedor(fornecedor);
        }

        public void Alterar()
        {
            Fornecedor fornecedor = new Fornecedor();
            AlterarFornecedor(fornecedor);
        }

        public void Excluir()
        {
            Fornecedor fornecedor = new Fornecedor();
            ExcluirFornecedor(fornecedor);
        }
        #endregion
    }
}

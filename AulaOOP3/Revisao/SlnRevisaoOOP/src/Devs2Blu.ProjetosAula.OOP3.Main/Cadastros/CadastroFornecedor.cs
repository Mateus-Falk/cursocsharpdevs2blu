using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enuns;
using Devs2Blu.ProjetosAula.OOP3.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroFornecedor
    {
        public CadastroFornecedor()
        {

        }
        public void MenuCadastro()
        {
            Int32 opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("- - - - - Cadastro de Fornecedor - - - - -");
                Console.WriteLine("- - - - - 1 - Lista de Fornecedor - - - - -");
                Console.WriteLine("- - - - - 2 - Cadastro de Fornecedor - - - - -");
                Console.WriteLine("- - - - - 3 - Alterar Fornecedor - - - - -");
                Console.WriteLine("- - - - - - - - - - - - - - - - -");
                Console.WriteLine("- - - - - 0 - Sair - - - - -");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnums.LISTAR:
                        ListarFornecedores();
                        break;
                    case (int)MenuEnums.CADASTRAR:
                        CadastrarFornecedor();
                        break;
                    default:
                        break;
                }

            } while (!opcao.Equals((int)MenuEnums.SAIR));
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
            Console.WriteLine("Precione \"ENTER\" para continuar");
            Console.ReadLine();
        }
        public void CadastrarFornecedor()
        {
            Random rd = new Random();
            Fornecedor novoFornecedor = new Fornecedor(rd.Next(11,79), $"Fornecedor {rd.Next(11,97)}", $"1451{rd.Next(1549,7595)}212", "Pessoa Jurídica");
            Program.Mock.ListaFornecedor.Add(novoFornecedor);
        }
        public void AlterarFornecedor()
        {

        }
        public void ExcluirFornecedor()
        {

        }

    }
}

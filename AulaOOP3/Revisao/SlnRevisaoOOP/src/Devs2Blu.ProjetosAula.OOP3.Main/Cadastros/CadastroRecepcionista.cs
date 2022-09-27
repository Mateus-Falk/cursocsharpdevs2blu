using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enuns;
using Devs2Blu.ProjetosAula.OOP3.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroRecepcionista
    {
        public CadastroRecepcionista()
        {

        }
        public void MenuCadastro()
        {
            Int32 opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("- - - - - Cadastro de Recepcionista - - - - -");
                Console.WriteLine("- - - - - 1 - Lista de Recepcionista - - - - -");
                Console.WriteLine("- - - - - 2 - Cadastro de Recepcionista - - - - -");
                Console.WriteLine("- - - - - 3 - Alterar Recepcionista - - - - -");
                Console.WriteLine("- - - - - - - - - - - - - - - - -");
                Console.WriteLine("- - - - - 0 - Sair - - - - -");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnums.LISTAR:
                        ListarRecepcionistas();
                        break;
                    case (int)MenuEnums.CADASTRAR:
                        CadastrarRecepcionista();
                        break;
                    default:
                        break;
                }

            } while (!opcao.Equals((int)MenuEnums.SAIR));
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
            Console.WriteLine("Precione \"ENTER\" para continuar");
            Console.ReadLine();
        }
        public void CadastrarRecepcionista()
        {
            string[] setor = { "Neurologia", "Ortologia", "Cardiologia", "Clínica Geral" };

            Random rd = new Random();
            Recepcionista novoRecepcionista = new Recepcionista(rd.Next(11, 45), $"Paciente {rd.Next(11, 45)}", $"32{rd.Next(10, 45)}6489141", setor[rd.Next(0, setor.Length)]);
            Program.Mock.ListaRecepcionistas.Add(novoRecepcionista);
        }
        public void AlterarRecepcionista()
        {

        }
        public void ExcluirRecepcionista()
        {

        }
    }
}

using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enuns;
using Devs2Blu.ProjetosAula.OOP3.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroMedico
    {
        public CadastroMedico()
        {

        }
        public void MenuCadastro()
        {
            Int32 opcao;

            do
            {
                Console.WriteLine("- - - - - Cadastro de Médicos - - - - -");
                Console.WriteLine("- - - - - 1 - Lista de Médicos - - - - -");
                Console.WriteLine("- - - - - 2 - Cadastro de Médicos - - - - -");
                Console.WriteLine("- - - - - 3 - Alterar Médicos - - - - -");
                Console.WriteLine("- - - - - - - - - - - - - - - - -");
                Console.WriteLine("- - - - - 0 - Sair - - - - -");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnums.LISTAR:
                        ListarMedicos();
                        break;
                    default:
                        break;
                }

            } while (!opcao.Equals((int)MenuEnums.SAIR));
        }
        public void ListarMedicos()
        {
            Console.Clear();

            foreach (Medico medico  in Program.Mock.ListaMedicos)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine($"Medico: {medico.CodigoMedico}");
                Console.WriteLine($"Nome: {medico.Nome}");
                Console.WriteLine($"CPF: {medico.CGCCPF}");
                Console.WriteLine($"CRM: {medico.CRM}");
                Console.WriteLine($"Especialidade: {medico.Especialidade}");
                Console.WriteLine("------------------------------------\n");
            }
        }
        public void CadastrarMedico()
        {

        }
        public void AlterarMedico()
        {

        }
        public void ExcluirMedico()
        {

        }
    }
}

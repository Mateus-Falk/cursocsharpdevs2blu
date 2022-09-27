using System;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enuns;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Models.Models;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroPaciente
    {
        public CadastroPaciente()
        {
                
        }

        public void MenuCadastro()
        {
            Int32 opcao;
            
            do 
            {
                Console.Clear();
                Console.WriteLine("- - - - - Cadastro de Pacientes - - - - -");
                Console.WriteLine("- - - - - 1 - Lista de Pacientes - - - - -");
                Console.WriteLine("- - - - - 2 - Cadastro de Pacientes - - - - -");
                Console.WriteLine("- - - - - 3 - Alterar Pacientes - - - - -");
                Console.WriteLine("- - - - - - - - - - - - - - - - -");
                Console.WriteLine("- - - - - 0 - Sair - - - - -");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnums.LISTAR:
                        ListarPacientes();
                        break;
                    case (int)MenuEnums.CADASTRAR:
                        CadastrarPaciente();
                        break;
                    default :
                        break;
                }

            }while (!opcao.Equals((int)MenuEnums.SAIR));
        }

        public void ListarPacientes()
        {
            Console.Clear();

            foreach (Paciente paciente in Program.Mock.ListaPacientes)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine($"Paciente: {paciente.CodigoPaciente}");
                Console.WriteLine($"Nome: {paciente.Nome}");
                Console.WriteLine($"CPF: {paciente.CGCCPF}");
                Console.WriteLine($"Convenio: {paciente.Convenio}");
                Console.WriteLine("------------------------------------\n");
            }
            Console.WriteLine("Precione \"ENTER\" para continuar");
            Console.ReadLine();
        }

        public void CadastrarPaciente()
        {
            Random rd = new Random();
            Paciente novoPaciente = new Paciente(rd.Next(11,45), $"Paciente {rd.Next(11, 45)}", $"32{rd.Next(10, 45)}6489141", "Unimed");
            Program.Mock.ListaPacientes.Add(novoPaciente);


        }
        public void AlterarPaciente()
        {

        }
        public void ExcluirPaciente()
        {

        }
    }
}

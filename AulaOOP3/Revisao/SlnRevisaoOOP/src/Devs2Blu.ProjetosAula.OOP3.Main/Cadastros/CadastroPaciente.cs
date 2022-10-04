using System;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enuns;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Models.Models;
using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroPaciente : IMenuCadastro
    {
        public CadastroPaciente()
        {
                
        }
        private void ListarPacientes()
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
            Console.WriteLine("Precione 'ENTER' para voltar");
            Console.ReadLine();
        }
        private void CadastrarPaciente(Paciente novoPaciente)
        {
            Program.Mock.ListaPacientes.Add(novoPaciente);
        }
        private void AlterarPaciente(Paciente paciente)
        {
            var pact = Program.Mock.ListaPacientes.Find(p => p.CodigoPaciente == paciente.CodigoPaciente);
            int index = Program.Mock.ListaPacientes.IndexOf(pact);
            Program.Mock.ListaPacientes[index] = paciente;

        }
        private void ExcluirPaciente(Paciente paciente)
        {
            Program.Mock.ListaPacientes.Remove(paciente);
        }
        private void ListarPacienteByCodeAndName()
        {
            foreach (Paciente paciente in Program.Mock.ListaPacientes)
            {

                Console.WriteLine($"| Código: {paciente.CodigoPaciente} - Nome: {paciente.Nome} |");
            }
            Console.WriteLine("\n");
        }
        #region facade
        public Int32 MenuCadastro()
        {
            Int32 opcao;
            Console.Clear();
            Console.WriteLine("- - - - - Cadastro de Pacientes - - - - -");
            Console.WriteLine("- - - - - 1 - Lista de Pacientes - - - - -");
            Console.WriteLine("- - - - - 2 - Cadastro de Pacientes - - - - -");
            Console.WriteLine("- - - - - 3 - Alterar Pacientes - - - - -");
            Console.WriteLine("- - - - - 4 - Excluir Pacientes - - - - -");
            Console.WriteLine("- - - - - - - - - - - - - - - - -");
            Console.WriteLine("- - - - - 0 - Sair - - - - -");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;
        }
        public void Listar()
        {
            ListarPacientes();
        }
        public void Cadastrar()
        {
            Console.Clear();
            Paciente paciente = new Paciente();
            Console.WriteLine("Informe o nome do Paciente");
            paciente.Nome = Console.ReadLine();

            Console.WriteLine("Informe o CPF");
            paciente.CGCCPF = Console.ReadLine();

            Console.WriteLine("Informe o Convênio do Paciente");
            paciente.Convenio = Console.ReadLine();

            Random rd = new Random();
            paciente.Codigo = rd.Next(1, 100) + DateTime.Now.Second;
            paciente.CodigoPaciente = Int32.Parse($"{paciente.Codigo}{rd.Next(100, 900)}");

            CadastrarPaciente(paciente);
        }
        public void Alterar()
        {
            Console.Clear();
            Paciente paciente;
            int codigoPaciente;

            Console.WriteLine("Informe o paciente que deseja alterar:\n");
            ListarPacienteByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out  codigoPaciente);

            paciente = Program.Mock.ListaPacientes.Find(p => p.CodigoPaciente == codigoPaciente);

            string opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.WriteLine($"Paciente: {paciente.Codigo}/{paciente.CodigoPaciente} | Nome: {paciente.Nome} | CPF: {paciente.CGCCPF} | Convênio: {paciente.Convenio}");
                Console.WriteLine("Qual campo deseja alterar");            
                Console.WriteLine("|01 - Nome | 02 - CPF | 03 Convênio | 00 Sair |");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.WriteLine("Informe um novo nome: ");
                        paciente.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CPF: ");
                        paciente.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Informe um novo convênio: ");
                        paciente.Convenio = Console.ReadLine();
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

            AlterarPaciente(paciente);
        }
        public void Excluir()
        {
            Console.Clear();
            Paciente paciente;
            int codigoPaciente;

            Console.WriteLine("Informe o paciente que deseja excluir");
            ListarPacienteByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoPaciente);
            Console.Clear();
            paciente = Program.Mock.ListaPacientes.Find(p => p.CodigoPaciente == codigoPaciente);

            Console.WriteLine($"\nTem certeza de que deseja excluir o paciente {paciente.CodigoPaciente}/{paciente.Nome}?");
            Console.WriteLine("\n| 01 - Sim | Enter - Não|");

            String opcao = Console.ReadLine();

            if (opcao == "01")
            {
                ExcluirPaciente(paciente);
                Console.WriteLine("Paciente excluido com sucesso");
            }
            
        }
        #endregion    
    }
}

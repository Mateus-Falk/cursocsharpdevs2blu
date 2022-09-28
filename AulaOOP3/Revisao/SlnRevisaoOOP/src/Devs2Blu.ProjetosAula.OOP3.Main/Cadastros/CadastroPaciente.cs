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

            novoPaciente = new Paciente();
            Console.WriteLine("Informe o código");
            novoPaciente.CodigoPaciente = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome");
            novoPaciente.Nome = Console.ReadLine();
            Console.WriteLine("Informe o CPF");
            novoPaciente.CGCCPF = Console.ReadLine();
            Console.WriteLine("Informe o convenio");
            novoPaciente.Convenio = Console.ReadLine();
            Program.Mock.ListaPacientes.Add(novoPaciente);
        }
        private void AlterarPaciente(Paciente novoPaciente)
        {

        }
        private void ExcluirPaciente(Paciente novoPaciente)
        {

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
            Paciente paciente = new Paciente();
            CadastrarPaciente(paciente);
        }
        public void Alterar()
        {
            Paciente paciente = new Paciente();
            AlterarPaciente(paciente);
        }
        public void Excluir()
        {
            Paciente paciente = new Paciente();
            ExcluirPaciente(paciente);
        }
        #endregion    
    }
}

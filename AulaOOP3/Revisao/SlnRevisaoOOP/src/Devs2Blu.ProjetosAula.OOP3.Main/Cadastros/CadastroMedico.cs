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
    public class CadastroMedico : IMenuCadastro  
    {
        public CadastroMedico()
        {

        }
        
        public void ListarMedicos()
        {
            Console.Clear();

            foreach (Medico medico in Program.Mock.ListaMedicos)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine($"Medico: {medico.CodigoMedico}");
                Console.WriteLine($"Nome: {medico.Nome}");
                Console.WriteLine($"CPF: {medico.CGCCPF}");
                Console.WriteLine($"CRM: {medico.CRM}");
                Console.WriteLine($"Especialidade: {medico.Especialidade}");
                Console.WriteLine("------------------------------------\n");
            }
            Console.WriteLine("Precione 'ENTER' para voltar");
            Console.ReadLine();
        }

        public void CadastrarMedico(Medico novoMedico)
        {
            Console.WriteLine("Informe o código");
            novoMedico.CodigoMedico = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome");
            novoMedico.Nome = Console.ReadLine();
            Console.WriteLine("Informe o CPF");
            novoMedico.CGCCPF = Console.ReadLine();
            Console.WriteLine("Informe o CRM");
            novoMedico.CRM = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Informe a especialidade");
            novoMedico.Especialidade = Console.ReadLine();
            Program.Mock.ListaMedicos.Add(novoMedico);
        }
        public void AlterarMedico(Medico novoMedico)
        {

        }
        public void ExcluirMedico(Medico novoMedico)
        {

        }
        #region facede
        public Int32 MenuCadastro()
        {
            Int32 opcao;

            Console.Clear();
            Console.WriteLine("- - - - - Cadastro de Médicos - - - - -");
            Console.WriteLine("- - - - - 1 - Lista de Médicos - - - - -");
            Console.WriteLine("- - - - - 2 - Cadastro de Médicos - - - - -");
            Console.WriteLine("- - - - - 3 - Alterar Médicos - - - - -");
            Console.WriteLine("- - - - - 4 - Excluir Médicos - - - - -");
            Console.WriteLine("- - - - - - - - - - - - - - - - -");
            Console.WriteLine("- - - - - 0 - Sair - - - - -");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;
        }
        public void Listar()
        {
            ListarMedicos();
        }

        public void Cadastrar()
        {
            Medico medico = new Medico();
            CadastrarMedico(medico);
        }

        public void Alterar()
        {
            Medico medico = new Medico();
            AlterarMedico(medico);
        }

        public void Excluir()
        {
            Medico medico = new Medico();
            ExcluirMedico(medico);
        }
        #endregion
    }
}

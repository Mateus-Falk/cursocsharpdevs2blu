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
            Program.Mock.ListaMedicos.Add(novoMedico);
        }
        public void AlterarMedico(Medico medico)
        {
            var medc = Program.Mock.ListaMedicos.Find(m => m.CodigoMedico == medico.CodigoMedico);
            int index = Program.Mock.ListaMedicos.IndexOf(medc);
            Program.Mock.ListaMedicos[index] = medico;
        }
        public void ExcluirMedico(Medico medico)
        {
            Program.Mock.ListaMedicos.Remove(medico);
        }
        public void ListarMedicosByCodeAndName()
        {
            Console.Clear();

            foreach (Medico medico in Program.Mock.ListaMedicos)
            {
                Console.WriteLine($"| Código: {medico.CodigoMedico} | Nome: {medico.Nome} |");
            }
            Console.WriteLine("\n");
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
            Console.Clear();
            Medico medico = new Medico();

            Console.WriteLine("Informe o nome");
            medico.Nome = Console.ReadLine();

            Console.WriteLine("Informe o CPF");
            medico.CGCCPF = Console.ReadLine();

            Console.WriteLine("Informe o CRM");
            medico.CRM = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe a especialidade");
            medico.Especialidade = Console.ReadLine();

            Random rd = new Random();
            medico.Codigo = rd.Next(1, 100) + DateTime.Now.Second;
            medico.CodigoMedico = Int32.Parse($"{medico.Codigo}{rd.Next(100, 999)}");

            CadastrarMedico(medico);
        }

        public void Alterar()
        {
            Console.Clear();
            int codigoMedico;
            Medico medico;

            Console.WriteLine("Informe o médico que deseja alterar");
            ListarMedicosByCodeAndName();
            codigoMedico = Int32.Parse(Console.ReadLine());

            Console.Clear();
            medico = Program.Mock.ListaMedicos.Find(m => m.CodigoMedico == codigoMedico);

            string opcaoAlterar;
            bool alterar = true;

            do {
                Console.WriteLine($"\n| Médico: {medico.Codigo}/{medico.CodigoMedico} | Nome: {medico.Nome} | CPF: {medico.CGCCPF} | CRM: {medico.CRM} | Especialidade: {medico.Especialidade} |");
                Console.WriteLine("\nQual campo deseja alterar?");
                Console.WriteLine("| 01 - Nome | 02 - CPF | 03 - CRM | 04 - Especialidade | 00 - Sair |");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.WriteLine("Informe um novo nome");
                        medico.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CPF");
                        medico.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Informe um novo CRM");
                        medico.CRM = Int32.Parse(Console.ReadLine());
                        break;
                    case "04":
                        Console.WriteLine("Informe uma nova especialidade");
                        medico.Especialidade = Console.ReadLine();
                        break;
                    default:
                        alterar = false;
                        break;
                }

                if (alterar)
                {
                    Console.Clear();
                    Console.WriteLine("Cadastro alterado com sucesso");
                }
            }while (alterar);

            AlterarMedico(medico);
        }

        public void Excluir()
        {
            Console.Clear();
            Medico medico;
            int codigoMedigo;

            Console.WriteLine("Informe o médico que deseja excluir");
            ListarMedicosByCodeAndName();
            codigoMedigo = Int32.Parse(Console.ReadLine());

            medico = Program.Mock.ListaMedicos.Find(m => m.CodigoMedico == codigoMedigo);

            Console.WriteLine($"Tem certeza que que deseja excluir o médico {medico.CodigoMedico}/{medico.Nome}");
            Console.WriteLine("| 01 - Sim | Enter - Não |");
            string opcao = Console.ReadLine();

            if (opcao.Equals("01"))
            {
                ExcluirMedico(medico);
                Console.WriteLine("Dado excluido com sucesso");
            }
        }
        #endregion
    }
}

using Devs2Blu.ProjetosAula.OOP3.Main.Cadastros;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enuns;
using Devs2Blu.ProjetosAula.OOP3.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main
{
    internal class Program
    {
        public static Mocks Mock { get; set; }
        public static CadastroPaciente ModuloCadastroPacientes { get; set; }
        public static CadastroMedico ModuloCadastroMedicos { get; set; }
        public static CadastroRecepcionista ModuloCadastroRecepcionistas { get; set; }
        public static CadastroFornecedor ModuloCadastroFornecedores { get; set; }
        static void Main(string[] args)
        {
            int opcao;
            Mock = new Mocks();

            do { 
            Console.WriteLine("- - - - - Sistema de Gerenciamento de Clínicas - - - - -");
            Console.WriteLine("- - - - - 10- Cadastro de Pacientes - - - - -");
            Console.WriteLine("- - - - - 20- Cadastro de Médicos - - - - -");
            Console.WriteLine("- - - - - 30- Cadastro de Recepcionistas - - - - -");
            Console.WriteLine("- - - - - 40- Cadastro de Fornecedores - - - - -");
            Console.WriteLine("- - - - - 50- Agenda - - - - -");
            Console.WriteLine("- - - - - 60- Prontuário - - - - -");
            Console.WriteLine("- - - - - 70- Financeiro- - - - -");
            Console.WriteLine("- - - - - - - - - - - - - - - - -");
            Console.WriteLine("- - - - - 0 - Sair - - - - -");
            Int32.TryParse(Console.ReadLine(), out opcao);
            
            switch (opcao)
            {
                case (int)MenuEnums.CAD_PAC:
                        ModuloCadastroPacientes = new CadastroPaciente();
                        ModuloCadastroPacientes.MenuCadastro();
                        break;
                    case (int)MenuEnums.CAD_MED:
                        ModuloCadastroMedicos = new CadastroMedico();
                        ModuloCadastroMedicos.MenuCadastro();
                        break;
                    case (int)MenuEnums.CAD_REC:
                        ModuloCadastroRecepcionistas = new CadastroRecepcionista();
                        ModuloCadastroRecepcionistas.MenuCadastro();
                        break;
                    case (int)MenuEnums.CAD_FOR:
                        ModuloCadastroFornecedores = new CadastroFornecedor();
                        ModuloCadastroFornecedores.MenuCadastro();
                        break;
                    default:
                    break;
            }

        }while (!opcao.Equals((int)MenuEnums.SAIR));      
        }   
    }
}

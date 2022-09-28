using Devs2Blu.ProjetosAula.OOP3.Main.Cadastros;
using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
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
            Int32 opcao = 0, opcaoMenuCadastros = 0;
            Mock = new Mocks();
            IMenuCadastro menuCadastro;

            do
            {
                if (opcaoMenuCadastros.Equals((int)MenuEnums.SAIR))
                {

                    Console.Clear();
                    Console.WriteLine("- - - - - Sistema de Gerenciamento de Clínicas - - - - -");
                    Console.WriteLine("- - - - - 10 - Cadastro de Pacientes - - - - -");
                    Console.WriteLine("- - - - - 20 - Cadastro de Médicos - - - - -");
                    Console.WriteLine("- - - - - 30 - Cadastro de Recepcionistas - - - - -");
                    Console.WriteLine("- - - - - 40 - Cadastro de Fornecedores - - - - -");
                    Console.WriteLine("- - - - - 50 - Agenda - - - - -");
                    Console.WriteLine("- - - - - 60 - Prontuário - - - - -");
                    Console.WriteLine("- - - - - 70 - Financeiro- - - - -");
                    Console.WriteLine("- - - - - - - - - - - - - - - - -");
                    Console.WriteLine("- - - - - 0 - Sair - - - - -");
                    Int32.TryParse(Console.ReadLine(), out opcao);

                }
                switch (opcao)
                {
                    case (int)MenuEnums.CAD_PAC:
                        menuCadastro = new CadastroPaciente();
                        opcaoMenuCadastros = menuCadastro.MenuCadastro();
                        break;
                    case (int)MenuEnums.CAD_MED:
                        menuCadastro = new CadastroMedico();
                        opcaoMenuCadastros = menuCadastro.MenuCadastro();
                        break;
                    /*case (int)MenuEnums.CAD_REC:
                        CadastroRecepcionista moduloCadastroRecepcionistas = new CadastroRecepcionista();
                        moduloCadastroRecepcionistas.MenuCadastro();
                        break;*/
                    /*case (int)MenuEnums.CAD_FOR:
                        CadastroFornecedor moduloCadastroFornecedores = new CadastroFornecedor();
                        moduloCadastroFornecedores.MenuCadastro();
                        break;*/
                    default:
                        menuCadastro = new CadastroPadrao();
                        opcaoMenuCadastros = (int)MenuEnums.SAIR;
                        break;
                }


                switch (opcaoMenuCadastros)
                {
                    case (int)MenuEnums.LISTAR:
                        menuCadastro.Listar();
                        break;
                    case (int)MenuEnums.CADASTRAR:
                        menuCadastro.Cadastrar();
                        break;
                    case (int)MenuEnums.ALTERAR:
                        menuCadastro.Alterar();
                        break;
                    case (int)MenuEnums.EXCLUIR:
                        menuCadastro.Excluir();
                        break;
                    default:
                        menuCadastro = new CadastroPadrao();
                        opcaoMenuCadastros = (int)MenuEnums.SAIR;
                        break;
                }


            } while (!opcao.Equals((int)MenuEnums.SAIR));
        }
    }
}

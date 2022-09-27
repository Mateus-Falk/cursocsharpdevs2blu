using Devs2Blu.ProjetosAula.OOP3.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Utils
{
    public class Mocks
    {
        public List<Paciente> ListaPacientes { get; set; }
        public List<Medico> ListaMedicos { get; set; }
        public  List<Recepcionista> ListaRecepcionistas { get; set; }
        public List<Fornecedor> ListaFornecedor { get; set; }

        public Mocks ()
        {
            ListaPacientes = new List<Paciente>();
            ListaMedicos = new List<Medico>();
            ListaRecepcionistas = new List<Recepcionista>();
            ListaFornecedor = new List<Fornecedor>();
            
            CargaMock();


        }
        public void CargaMock()
        {
            CargaPacientes();
            CargaMedicos();
            CargaRecepcionista();
            CargaFornecedor();
        }

        public void CargaPacientes()
        {
            for (int i = 0; i < 10; i++)
            {
                Paciente paciente = new Paciente(i, $"Paciente {i+1}",$"{i}23{i}56{i}891{i}","Unimed" );
                ListaPacientes.Add(paciente);
            }
        }
        public void CargaMedicos()
        {
            string[] especialidade = { "Neurologista", "Ortologista", "Cardiologista", "Clínico Geral" };
            
            Random rd = new Random();

            for (int i = 0; i < 10; i++) 
            {
                Medico medico = new Medico(i, $"Médico {i + 1}", $"{i}54{i}45{i}751{i}", rd.Next(1, 50000), especialidade[rd.Next(0, especialidade.Length)]);
                ListaMedicos.Add(medico);
            }
        }
        public void CargaRecepcionista()
        {
            string[] setor = { "Neurologia", "Ortologia", "Cardiologia", "Clínica Geral" };

            Random rd = new Random();

            for (int i = 0; i < 10; i++)
            {
                Recepcionista recepcionista = new Recepcionista(i, $"Recepcionista {i+1}", $"{i}15{i}45{i}789{i}", setor[rd.Next(0, setor.Length)]);   
                ListaRecepcionistas.Add(recepcionista);
            }
        }
        public void CargaFornecedor()
        {
            for(int i = 0; i < 10; i++)
            {
                Fornecedor fornecedor = new Fornecedor(i, $"Fornecedor {i+1}", $"{i}456{i}12{i}12{i}", "Pessoa Jurídica");
                ListaFornecedor.Add(fornecedor);
            }
        }
    }
}

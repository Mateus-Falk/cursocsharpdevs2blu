﻿namespace ProjetoContatos.API.Entities
{
	public class Contato
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Telefone { get; set; }
		public string Estado { get; set; }
		public string Cidade { get; set; }
		public string Bairro{ get; set; }
	}
}

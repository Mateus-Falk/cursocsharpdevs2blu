using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Devs2Blu.ProjetosAula.MVCSQLServerApp2.Web.Models.Entities
{
	[Table("marca")]
	public class Marca
	{
		[Column("id")]
		[Display(Name = "Código")]
		public int Id { get; set; }

		[Column("nome")]
		[Display(Name = "Nome")]
		public string Nome { get; set; }

		public ICollection<Produto>? Produtos { get; set; }
	}
}

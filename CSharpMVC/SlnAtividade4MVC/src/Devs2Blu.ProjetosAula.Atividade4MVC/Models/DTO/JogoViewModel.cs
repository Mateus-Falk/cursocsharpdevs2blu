using Devs2Blu.ProjetosAula.Atividade4MVC.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace Devs2Blu.ProjetosAula.Atividade4MVC.Models.DTO
{
	public class JogoViewModel
	{
		[Display(Name = "Código")]
		public int id { get; set; }

		[Display(Name = "Nome")]
		public string nome { get; set; }

		[Display(Name = "Personagem")]
		public string personagem { get; set; }
		
		[Display(Name = "Review")]
		public string review { get; set; }
		
		[Display(Name = "Nota")]
		public double nota { get; set; }

		[Display(Name = "Genero")]
		public int generoid { get; set;}

		public Jogo ToEntity()
		{
			return new Jogo
			{
				Id = id,
				Nome = nome,
				Personagem = personagem,
				Review = review,
				Nota = nota,
				GeneroId = generoid
			};

		}
	}
}

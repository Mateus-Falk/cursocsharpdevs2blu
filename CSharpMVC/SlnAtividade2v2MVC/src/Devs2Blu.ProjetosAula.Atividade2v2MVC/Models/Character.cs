namespace Devs2Blu.ProjetosAula.Atividade2v2MVC.Models
{
	public class Character
	{
		public List<ResultsCharacter> results { get; set; }
	}

	public class ResultsCharacter
	{
		public int id { get; set; }
		public string name { get; set; }
		public string status { get; set; }
		public string species { get; set; }
		public string image { get; set; }
	}
}

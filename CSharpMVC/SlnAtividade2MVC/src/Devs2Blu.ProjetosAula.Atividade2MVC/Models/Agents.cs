namespace Devs2Blu.ProjetosAula.Atividade2MVC.Models
{
	public class Agents
	{
		public int status { get; set; }
		public List<DataAgents> data { get; set; }
	}

	public class DataAgents
	{
		public string displayName{ get; set; }
		public string description { get; set; }
		public string displayIcon { get; set; }
		public string bustPortrait { get; set; }
		public Role role { get; set; }
	}

	public class Role
	{
		public string displayName { get; set; }
		public string description { get; set; }
		public string displayIcon { get; set; }
	}
}

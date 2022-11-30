namespace Devs2Blu.ProjetosAula.Atividade2MVC.Models
{
	public class Maps
	{
		public int status { get; set; }
		public List<DataMaps> data { get; set; }
	}

	public class DataMaps
	{
		public string displayName { get; set; }
		public string coordinates { get; set; }
		public string splash { get; set; }
	}
}

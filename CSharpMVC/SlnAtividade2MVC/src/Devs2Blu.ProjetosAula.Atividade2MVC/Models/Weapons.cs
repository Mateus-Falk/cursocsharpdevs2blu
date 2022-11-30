namespace Devs2Blu.ProjetosAula.Atividade2MVC.Models
{
	public class Weapons
	{
		public int status { get; set; }
		public List<DataWeapons> data { get; set; }
	}

	public class DataWeapons
	{
		public string displayName { get; set; }
		public string displayIcon { get; set; }

		public ShopWeapons shopData { get; set; }

	}

	public class ShopWeapons
	{
		public string category { get; set; }
		public string categoryText { get; set; }
	}


}

using Devs2Blu.ProjetosAula.Atividade2MVC.Models;

namespace Devs2Blu.ProjetosAula.Atividade2MVC.Services
{
	public class APIService
	{
		private readonly HttpClient _httpClient;
		private const string URL_API_AGENTS = "https://valorant-api.com/v1/agents?isPlayableCharacter=true";
		private const string URL_API_MAPS = "https://valorant-api.com/v1/maps";
		private const string URL_API_WEAPONS = "https://valorant-api.com/v1/weapons";

		public APIService()
		{
			_httpClient = new HttpClient();
		}

		public async Task<Agents> GetAgents()
		{
			return await Get<Agents>(URL_API_AGENTS);
		}
		public async Task<Maps> GetMaps()
		{
			return await Get<Maps>(URL_API_MAPS);
		}
		public async Task<Weapons> GetWeapons()
		{
			return await Get<Weapons>(URL_API_WEAPONS);
		}

		public async Task<List<T>> GetList<T>(string url)
		{
			var listHttp = await GetAsync(url);

			if (!listHttp.IsSuccessStatusCode)
				return new List<T>();

			return await listHttp.Content.ReadFromJsonAsync<List<T>>();
		}

		public async Task<T> Get<T>(string url)
		{
			var listHttp = await GetAsync(url);

			if (!listHttp.IsSuccessStatusCode)
				return (T)(object)url;

			return await listHttp.Content.ReadFromJsonAsync<T>();
		}

		public async Task<HttpResponseMessage> GetAsync(string url)
		{
			var getRequest = new HttpRequestMessage()
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri(url)
			};
			return await _httpClient.SendAsync(getRequest);
		}
	}
}

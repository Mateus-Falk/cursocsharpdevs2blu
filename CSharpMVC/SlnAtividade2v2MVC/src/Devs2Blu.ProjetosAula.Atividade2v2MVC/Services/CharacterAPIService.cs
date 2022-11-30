using Devs2Blu.ProjetosAula.Atividade2v2MVC.Models;

namespace Devs2Blu.ProjetosAula.Atividade2v2MVC.Services
{
	public class CharacterAPIService
	{
		private readonly HttpClient _httpClient;
		private const string URL_API_CHARACTER = "https://rickandmortyapi.com/api/character";
	
		public CharacterAPIService() 
		{
			_httpClient= new HttpClient();
		}

		public async Task<Character> GetCharacter()
		{
			return await Get<Character>(URL_API_CHARACTER);
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

using Devs2blu.ProjetosAula.Ativiade3MVC.Models.DTOAPI;
using System.Net.Http;

namespace Devs2blu.ProjetosAula.Ativiade3MVC.Services
{
    public class ServiceAPI
    {
        private readonly HttpClient _httpClient;
        public ServiceAPI() 
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<DigimonDTO>> GetDigimon()
        {
            var objJSONResponse = await GetList<DigimonDTO>(URL_API);
            return objJSONResponse;
        }

        public async Task<List<DigimonDTO>> GetDigimonByName(string name)
        {
            var urlSearch = $"{URL_API}/name/{name}";
            var objJSONResponse = await GetList<DigimonDTO>(urlSearch);
            return objJSONResponse;
        }

        #region BaseMethods
        public async Task<T> Get<T>(string url)
        {
            var objHttp = await GetAsync(url);
            if (!objHttp.IsSuccessStatusCode)
                return (T)(object)url;
            return await objHttp.Content.ReadFromJsonAsync<T>();
        }

        public async Task<List<T>> GetList<T>(string url)
        {
            var listHttp = await GetAsync(url);
            if (!listHttp.IsSuccessStatusCode)
                return new List<T>();
            return await listHttp.Content.ReadFromJsonAsync<List<T>>();
        }

        public async Task<HttpResponseMessage> GetAsync(string url)
        {
            var getRequest = new HttpRequestMessage()
            {
                Method = HttpMethod.Get,
                RequestUri= new Uri(url)
            };
            return await _httpClient.SendAsync(getRequest);
        }
        #endregion

        #region CONSTS

        private const string URL_API = "https://digimon-api.vercel.app/api/digimon";

        #endregion

    }
}

using Devs2Blu.ProjetosAula.Atividade3v2MVC.Models.DTOAPI;

namespace Devs2Blu.ProjetosAula.Atividade3v2MVC.Services
{
    public class ServiceAPI
    {
        private readonly HttpClient _httpClient;
        public ServiceAPI()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<CharacterDTO>> GetListCharacters()
        {
            var objJSONResponse = await Get<GetListDataCharactersDTO>(URL_API);
            var listCharacters = objJSONResponse.data;
            return listCharacters;
        }
        public async Task<List<CharacterDTO>> GetCharacterByName(string name)
        {
            var urlSearch = $"{URL_API}?name={name}";
            var objJSONResponse = await Get<GetListDataCharactersDTO>(urlSearch);
            var listCharacters = objJSONResponse.data;
            return listCharacters;
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
        private const string URL_API= "https://zelda.fanapis.com/api/characters";
        #endregion
    }
}

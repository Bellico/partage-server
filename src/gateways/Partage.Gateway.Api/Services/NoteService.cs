using System.Net.Http;
using System.Threading.Tasks;
using Partage.Gateway.Api.Application;

namespace Partage.Gateway.Api
{
    public class NoteService : INoteService
    {
        private readonly HttpClient _httpClient;

        public NoteService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetAsync()
        {
            var response = await _httpClient.GetAsync("/");

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
    }
}

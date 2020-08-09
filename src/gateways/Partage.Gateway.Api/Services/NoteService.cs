using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Partage.Gateway.Api.Application;

namespace Partage.Gateway.Api
{
    public class NoteService : INoteService
    {
        private readonly IHttpClientFactory clientFactory;
        private readonly HttpClient httpClient;

        public NoteService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<string> GetAsync()
        {
            var response = await httpClient.GetAsync("/");

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
    }
}

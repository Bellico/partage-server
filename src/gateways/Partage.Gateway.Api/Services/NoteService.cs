using System;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Newtonsoft.Json;
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

        public async Task<NoteModel> GetNoteAsync()
        {
            // var response = await _httpClient.GetAsync("/note");
            // response.EnsureSuccessStatusCode();

            //string repsonse = await response.Content.ReadAsStringAsync();

            HttpClientHandler clientHandler = new HttpClientHandler();
           // clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

        var cert = new X509Certificate2("E:\\PartageLab\\secure\\ca-cert.pem");
        var handler = new HttpClientHandler();
        handler.ClientCertificates.Add(cert);

        var httpClientHandler = new HttpClientHandler
        {
            ClientCertificateOptions = ClientCertificateOption.Manual,
            ClientCertificates =
            {
                cert
            },
        };

            var res = string.Empty;
            foreach (var d in new string[]{
                "https://www.partage.com:5001/link",
            })
            {
                try
                {
                    res += "SUCCESS: " + await new HttpClient(httpClientHandler)
                    {
                        DefaultRequestVersion = new Version(2, 0)
                    }.GetStringAsync(d);
                }
                catch (Exception ex)
                {
                    res += "FAIL " + d + "#" + ex.Message;
                    continue;
                }
            }

            //var note = JsonConvert.DeserializeObject<NoteModel>(repsonse);

            //note.Content = res;

            var note = new NoteModel{
                Content = res
            };

            return note;
        }
    }
}

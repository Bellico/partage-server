using System;
using System.Net.Http;
using System.Threading.Tasks;
using Grpc.Net.Client;
using Microsoft.Extensions.Options;
using Partage.Gateway.Api.Application;
using Partage.Link.Api;
using static Partage.Link.Api.LinkService;

namespace Partage.Gateway.Api
{
    public class LinkService : ILinkService
    {
        private readonly PartageServicesOptions partageServicesOptions;

        public LinkService(IOptions<PartageServicesOptions> partageServicesOptions)
        {
            this.partageServicesOptions = partageServicesOptions.Value;
        }

        public async Task<GetLinkResponse> GetLinkAsync()
        {
            //AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);

            var httpHandler = new HttpClientHandler();
            // Return `true` to allow certificates that are untrusted/invalid
            // httpHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            using var channel = GrpcChannel.ForAddress(partageServicesOptions.LinkEndpoint, new GrpcChannelOptions
            {
                HttpClient = new HttpClient(httpHandler)
                {
                    DefaultRequestVersion = new Version(2, 0)
                }
            });
            var client = new LinkServiceClient(channel);

            var reply = await client.GetLinkAsync(new GetLinkRequest { Id = "1" });

            return reply;
        }
    }
}

using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace Partage.Link.Api
{
    public class LinkGrpcService : LinkService.LinkServiceBase
    {
        private readonly ILogger<LinkGrpcService> _logger;
        public LinkGrpcService(ILogger<LinkGrpcService> logger)
        {
            _logger = logger;
        }

        public override Task<GetLinkResponse> GetLink(GetLinkRequest request, ServerCallContext context)
        {
            return Task.FromResult(new GetLinkResponse
            {
                Link = "Link" + request.Id
            });
        }
    }
}

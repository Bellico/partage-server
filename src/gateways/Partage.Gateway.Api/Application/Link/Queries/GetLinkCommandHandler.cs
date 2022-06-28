
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Partage.Link.Api;

namespace Partage.Gateway.Api.Application
{
    public class GetLinkCommandCommandHandler : IRequestHandler<GetLinkCommand, GetLinkResponse>
    {
        private readonly ILinkService linkService;

        public GetLinkCommandCommandHandler(ILinkService linkService)
        {
            this.linkService = linkService;
        }

        public async Task<GetLinkResponse> Handle(GetLinkCommand request, CancellationToken cancellationToken)
        {
            return await linkService.GetLinkAsync();
        }
    }
}

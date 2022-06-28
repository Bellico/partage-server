using System.Threading.Tasks;
using Partage.Link.Api;

namespace Partage.Gateway.Api.Application
{
    public interface ILinkService
    {
        Task<GetLinkResponse> GetLinkAsync();
    }
}

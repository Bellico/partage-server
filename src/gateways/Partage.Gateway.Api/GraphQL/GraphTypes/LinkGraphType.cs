using GraphQL.Types;
using Partage.Link.Api;

namespace Partage.Gateway.Api.GraphQL
{
    public class LinkGraphType : ObjectGraphType<GetLinkResponse>
    {
        public LinkGraphType()
        {
            Name = "Link";
            Description = "A Link";
            Field(x => x.Link).Description("The link");
        }
    }
}

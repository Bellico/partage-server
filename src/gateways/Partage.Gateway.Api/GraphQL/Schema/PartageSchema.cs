using GraphQL;
using GraphQL.Types;

namespace Partage.Gateway.Api.GraphQL
{
    public class PartageSchema : Schema
    {
        public PartageSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<PartageQuery>();
            Mutation = resolver.Resolve<PartageMutation>();
        }
    }
}

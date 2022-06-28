using GraphQL;
using GraphQL.Server;
using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using Partage.Gateway.Api.GraphQL;

namespace Partage.Gateway.Api
{
    public static class GraphQLConfiguration
    {
        public static void ConfigureGraphQL(this IServiceCollection services)
        {
            services.AddGraphQL(new GraphQLOptions
            {
                EnableMetrics = true,
                ExposeExceptions = true,
            }).AddGraphTypes(ServiceLifetime.Transient);

            services.AddScoped<IDependencyResolver>(x => new FuncDependencyResolver(x.GetRequiredService));
            services.AddScoped<ISchema, PartageSchema>();
            services.AddScoped<PartageQuery>();
            services.AddScoped<NoteGraphType>();
        }
    }
}

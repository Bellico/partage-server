using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using MediatR;

namespace Partage.Gateway.Api
{
    public static class MediatRConfiguration
    {
        public static void ConfigureMediatR(this IServiceCollection services)
        {
            //services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            // services.AddTransient(typeof(IPipelineBehavior<,>), typeof(PerformanceBehaviour<,>));
            // services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
            // services.AddTransient(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));
        }
    }
}

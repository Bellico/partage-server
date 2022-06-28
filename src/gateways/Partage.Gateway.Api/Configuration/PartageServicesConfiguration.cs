using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Partage.Gateway.Api.Application;
using System;

namespace Partage.Gateway.Api
{
    public static class PartageServicesConfiguration
    {
        public static void ConfigurePartageServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Partage Services Options
            services.Configure<PartageServicesOptions>(partageServicesOptions => {
                partageServicesOptions.NoteEndpoint = configuration.GetEnvironmentVariableOrConfigurationOption(nameof(PartageServicesOptions.NoteEndpoint));
                partageServicesOptions.LinkEndpoint = configuration.GetEnvironmentVariableOrConfigurationOption(nameof(PartageServicesOptions.LinkEndpoint));
            });

            // Note Service
            services.AddHttpClient<INoteService, NoteService>(c =>
            {
                c.BaseAddress = new Uri(configuration.GetEnvironmentVariableOrConfigurationOption(nameof(PartageServicesOptions.NoteEndpoint)));
            });

            // Link Service
            services.AddScoped<ILinkService, LinkService>();
        }
    }
}

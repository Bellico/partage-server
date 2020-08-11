using System;
using Microsoft.Extensions.DependencyInjection;
using Partage.Gateway.Api.Application;

namespace Partage.Gateway.Api.Configuration
{
    public static class ServicesClientConfiguration
    {
        public static void ConfigureServicesClient(this IServiceCollection services)
        {
            services.AddHttpClient<INoteService, NoteService>(c =>
            {
                c.BaseAddress = new Uri("http://note/");
            });
        }
    }
}

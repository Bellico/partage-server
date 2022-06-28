using System;
using Microsoft.Extensions.Configuration;

namespace Partage.Gateway.Api
{
    public static class ConfigurationExtensions
    {
        public static string GetEnvironmentVariableOrConfigurationOption(this IConfiguration configuration, string optionName)
          => Environment.GetEnvironmentVariable(optionName) ?? configuration[$"PartageServices:{optionName}"];
    }
}

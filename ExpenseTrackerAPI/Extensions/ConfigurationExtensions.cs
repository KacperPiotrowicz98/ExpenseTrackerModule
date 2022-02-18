using System.Diagnostics.CodeAnalysis;

namespace ExpenseTrackerAPI.Extensions
{
    [ExcludeFromCodeCoverage]
    public static class ConfigurationExtensions
    {
        public static IConfigurationBuilder SetDefaultConfig(this IConfigurationBuilder builder)
        {
            _ = builder
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .AddJsonFile("appsettings.Local.json", optional: true)
                .AddJsonFile("DisplayMessages.json")
                .AddEnvironmentVariables();

            return builder;
        }
    }
}

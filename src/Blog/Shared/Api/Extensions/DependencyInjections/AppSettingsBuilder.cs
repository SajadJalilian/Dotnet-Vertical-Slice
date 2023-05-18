namespace Blog.Shared.Api.Extensions.DependencyInjections;

public static class AppSettingsBuilder
{
    public static IHostBuilder ConfigureAppSettings(this IHostBuilder host)
    {
        var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

        host.ConfigureAppConfiguration((ctx, builder) =>
        {
            builder.AddJsonFile("appsettings.json", false, true);
            builder.AddJsonFile($"appsettings.{environment}.json", true, true);
            builder.AddEnvironmentVariables();
        });

        return host;
    }
}
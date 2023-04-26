using Ecommerce.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Api.Extensions.DependencyInjections;

public static class DatabaseInjection
{
    public static IServiceCollection AddConfiguredDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("DbConnection")));

        return services;
    }
}
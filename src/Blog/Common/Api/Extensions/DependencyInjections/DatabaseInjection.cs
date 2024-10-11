using Blog.Common.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Blog.Common.Api.Extensions.DependencyInjections;

public static class DatabaseInjection
{
    public static IServiceCollection AddConfiguredDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlite(configuration.GetConnectionString("DbConnection")));

        return services;
    }
}
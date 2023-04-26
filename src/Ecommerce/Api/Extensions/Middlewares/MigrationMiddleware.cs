using Ecommerce.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Api.Extensions.Middlewares;

public static class MigrationMiddleware
{
    public static IApplicationBuilder UseConfiguredMigration(this IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        context.Database.Migrate();

        return app;
    }
}
using Ecommerce.Features.Products.GetPostBtId;
using Ecommerce.Features.Products.GetPostsByFilter;
using Ecommerce.Persistence;

namespace Ecommerce.Api.Extensions.DependencyInjections;

public static class ServiceInjection
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        services.AddScoped<IGetProductByIdService, GetProductByIdService>();
        services.AddScoped<IGetPostsByFilterService, GetPostsByFilterService>();

        return services;
    }
}
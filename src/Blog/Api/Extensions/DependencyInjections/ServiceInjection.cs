using Blog.Feature.Posts.GetPostBtId;
using Blog.Feature.Posts.GetPostsByFilter;

namespace Blog.Api.Extensions.DependencyInjections;

public static class ServiceInjection
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        // services.AddScoped<IUnitOfWork, UnitOfWork>();

        services.AddScoped<IGetPostByIdService, GetPostByIdService>();
        services.AddScoped<IGetPostsByFilterService, GetPostsByFilterService>();

        return services;
    }
}
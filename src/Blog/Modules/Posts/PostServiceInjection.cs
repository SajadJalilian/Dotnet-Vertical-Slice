using Blog.Modules.Posts.GetPostBtId;
using Blog.Modules.Posts.GetPostsByFilter;

namespace Blog.Modules.Posts;

public static class PostServiceInjection
{
    public static IServiceCollection AddPostServices(this IServiceCollection services)
    {
        services.AddScoped<IGetPostByIdService, GetPostByIdService>();
        services.AddScoped<IGetPostsByFilterService, GetPostsByFilterService>();

        return services;
    }
}
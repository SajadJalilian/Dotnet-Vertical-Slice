using Blog.Modules.Post.GetPostBtId;
using Blog.Modules.Post.GetPostsByFilter;

namespace Blog.Modules.Post;

public static class PostServiceInjection
{
    public static IServiceCollection AddPostServices(this IServiceCollection services)
    {
        services.AddScoped<IGetPostByIdHandler, GetPostByIdHandler>();
        services.AddScoped<IGetPostsByFilterHandler, GetPostsByFilterHandler>();

        return services;
    }
}
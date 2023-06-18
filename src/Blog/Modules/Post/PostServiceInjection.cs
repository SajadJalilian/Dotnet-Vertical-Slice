using Blog.Modules.Post.CreatePost;
using Blog.Modules.Post.GetPostBtId;
using Blog.Modules.Post.GetPostsByFilter;

namespace Blog.Modules.Post;

public static class PostServiceInjection
{
    public static IServiceCollection AddPostServices(this IServiceCollection services)
    {
        services.AddScoped<ICreatePostHandler, CreatePostHandler>();
        services.AddScoped<IGetPostByIdHandler, GetPostByIdHandler>();
        services.AddScoped<IGetPostsByFilterHandler, GetPostsByFilterHandler>();

        return services;
    }
}
using Blog.Modules.Post.CreatePost;
using Blog.Modules.Post.GetPostBtId;
using Blog.Modules.Post.GetPostsByFilter;
using Blog.Modules.Post.UpdatePost;

namespace Blog.Modules.Post;

public static class PostServiceInjection
{
    public static IServiceCollection AddPostServices(this IServiceCollection services)
    {
        services.AddScoped<ICreatePostHandler, CreatePostHandler>();
        services.AddScoped<IUpdatePostHandler, UpdatePostHandler>();
        services.AddScoped<IGetPostByIdHandler, GetPostByIdHandler>();
        services.AddScoped<IGetPostsByFilterHandler, GetPostsByFilterHandler>();

        return services;
    }
}
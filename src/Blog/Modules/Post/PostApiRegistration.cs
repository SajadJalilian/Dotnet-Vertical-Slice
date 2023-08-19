using Blog.Modules.Post.CreatePost;
using Blog.Modules.Post.GetPostBtId;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Modules.Post;

public static class PostApiRegistration
{
    private const string Route = "posts-minimal/";

    public static WebApplication RegisterPostApis(this WebApplication app)
    {
        app.MapPost(Route, async (ICreatePostHandler createPostHandler, [FromBody] CreatePostRequest request) =>
        {
            var result = await createPostHandler.CreatePost(new CreatePostCommand(request.Title, request.Body));
            return Results.Ok(result);
        });

        app.MapGet(Route, async (IGetPostByIdHandler getPostByIdHandler, [FromRoute] int id) =>
        {
            var result = await getPostByIdHandler.GetPostById(id);
            return Results.Ok(result);
        });

        return app;
    }
}
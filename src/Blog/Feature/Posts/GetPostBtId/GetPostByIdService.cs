using Blog.Domain.Models;

namespace Blog.Feature.Posts.GetPostBtId;

public interface IGetPostByIdService
{
    Task<Post> GetPostById();
}

public class GetPostByIdService : IGetPostByIdService
{
    public async Task<Post> GetPostById()
    {
        var post = new Post
        {
            Id = 1,
            Title = "test",
            Body = "test body"
        };

        return post;
    }
}
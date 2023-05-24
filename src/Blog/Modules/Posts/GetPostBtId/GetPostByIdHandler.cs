namespace Blog.Modules.Posts.GetPostBtId;

public class GetPostByIdHandler : IGetPostByIdHandler
{
    public Task<Post> GetPostById()
    {
        var post = new Post
        {
            Id = 1,
            Title = "test",
            Body = "test body"
        };

        return Task.FromResult(post);
    }
}
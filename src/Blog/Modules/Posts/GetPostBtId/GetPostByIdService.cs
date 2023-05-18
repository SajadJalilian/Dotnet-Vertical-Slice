namespace Blog.Modules.Posts.GetPostBtId;

public interface IGetPostByIdService
{
    Task<Post> GetPostById();
}

public class GetPostByIdService : IGetPostByIdService
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
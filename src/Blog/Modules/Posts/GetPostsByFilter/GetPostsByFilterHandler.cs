namespace Blog.Modules.Posts.GetPostsByFilter;

public class GetPostsByFilterHandler : IGetPostsByFilterHandler
{
    public Task<IEnumerable<Post>> GetPostByFilter()
    {
        var post = new List<Post>()
        {
            new ()
            {
                Id = 1,
                Title = "test",
                Body = "test body"
            },
            new ()
            {
                Id = 2,
                Title = "test2",
                Body = "test body2"
            },
            new ()
            {
                Id = 3,
                Title = "test3",
                Body = "test body3"
            },
        };

        return Task.FromResult<IEnumerable<Post>>(post);
    }
}
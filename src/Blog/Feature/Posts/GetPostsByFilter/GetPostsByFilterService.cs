using Blog.Domain.Models;

namespace Blog.Feature.Posts.GetPostsByFilter;

public interface IGetPostsByFilterService
{
    Task<IEnumerable<Post>> GetPostByFilter();
}

public class GetPostsByFilterService : IGetPostsByFilterService
{
    public async Task<IEnumerable<Post>> GetPostByFilter()
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

        return post;
    }
}
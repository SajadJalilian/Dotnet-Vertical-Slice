namespace Blog.Modules.Posts.GetPostsByFilter;

public interface IGetPostsByFilterHandler
{
    Task<IEnumerable<Post>> GetPostByFilter();
}
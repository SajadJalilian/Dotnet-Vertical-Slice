namespace Blog.Modules.Post.GetPostsByFilter;

public interface IGetPostsByFilterHandler
{
    Task<IEnumerable<Post>> GetPostByFilter();
}
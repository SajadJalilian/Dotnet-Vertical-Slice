namespace Blog.Modules.Posts.GetPostBtId;

public interface IGetPostByIdHandler
{
    Task<Post> GetPostById();
}
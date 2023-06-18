namespace Blog.Modules.Post.GetPostBtId;

public interface IGetPostByIdHandler
{
    Task<Post> GetPostById();
}
namespace Blog.Modules.Post.GetPostBtId;

public interface IGetPostByIdHandler
{
    Task<PostEntity> GetPostById(int id);
}
namespace Blog.Modules.Post.UpdatePost;

public interface IUpdatePostHandler
{
    Task<Post> UpdatePost(UpdatePostCommand command);
}
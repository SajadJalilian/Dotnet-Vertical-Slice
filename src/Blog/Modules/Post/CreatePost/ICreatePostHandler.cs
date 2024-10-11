namespace Blog.Modules.Post.CreatePost;

public interface ICreatePostHandler
{
    Task<PostEntity> CreatePost(CreatePostCommand command);
}
namespace Blog.Modules.Post.CreatePost;

public interface ICreatePostHandler
{
    Task<Post> CreatePost(CreatePostCommand command);
}
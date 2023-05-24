namespace Blog.Modules.Posts.CreatePost;

public interface ICreatePostHandler
{
    Task<Post> CreatePost(CreatePostCommand command);
}
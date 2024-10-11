using ErrorOr;

namespace Blog.Modules.Post.UpdatePost;

public interface IUpdatePostHandler
{
    Task<ErrorOr<PostEntity>> UpdatePost(UpdatePostCommand command);
}
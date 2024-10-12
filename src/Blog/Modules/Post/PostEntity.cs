namespace Blog.Modules.Post;

public class PostEntity
{
    public int Id { get; private set; }
    public string Title { get; private set; } = "Title";
    public string Body { get; private set; } = default!;

    // relations
    public ICollection<Comment.CommentEntity> Comments { get; private set; }

    public static PostEntity Create(string title, string body)
    {
        ArgumentException.ThrowIfNullOrEmpty("Post title is empty", title);
        ArgumentException.ThrowIfNullOrEmpty("Post body is empty", body);
        return new PostEntity
        {
            Title = title,
            Body = body
        };
    }

    public void UpdateTitle(string title)
    {
        ArgumentException.ThrowIfNullOrEmpty("Post title is empty", title);
        Title = title;
    }

    public void UpdateBody(string body)
    {
        ArgumentException.ThrowIfNullOrEmpty("Post body is empty", body);
        Body = body;
    }
}
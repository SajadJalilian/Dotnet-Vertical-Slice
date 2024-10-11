namespace Blog.Modules.Post;

public class PostEntity
{
    public int Id { get; private set; }
    public string Title { get; private set; } = "Post Title";
    public string Body { get; private set; }

    // relations
    public ICollection<Comment.CommentEntity> Comments { get; private set; }


    public static PostEntity Create(string title, string body)
    {
        return new PostEntity
        {
            Title = title,
            Body = body
        };
    }

    public void UpdateTitle(string title)
    {
        Title = title;
    }

    public void UpdateBody(string body)
    {
        Body = body;
    }
}
using Blog.Modules.Post;

namespace Blog.Modules.Comment;

public class CommentEntity
{
    public int Id { get; private set; }
    public string Text { get; private set; }

    // relations
    public int PostId { get; private set; }
    public PostEntity PostEntity { get; private set; } = null!;

    public int? ParentId { get; private set; }
    public CommentEntity? Parent { get; private set; }
    public ICollection<CommentEntity> Children { get; private set; } = default!;

    public static CommentEntity Created(int postId, string title, string text, int? parentId)
    {
        return new CommentEntity
        {
            PostId = postId,
            Text = text,
            ParentId = parentId
        };
    }

    public void UpdateTitle(string text)
    {
        Text = text;
    }
}
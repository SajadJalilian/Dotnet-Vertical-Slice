namespace Blog.Modules.Comment;

public class Comment
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }

    // relations
    public int? PostId { get; set; }
    public Post.Post Post { get; set; }
    
    public int? ParentId { get; set; }
    public Comment Parent { get; set; }
    public ICollection<Comment> Children { get; set; }
}
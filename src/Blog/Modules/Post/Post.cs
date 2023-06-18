namespace Blog.Modules.Post;

public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    
    // relations
    public ICollection<Comment.Comment> Comments { get; set; }
}
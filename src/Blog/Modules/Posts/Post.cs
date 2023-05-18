using Blog.Modules.Comments;

namespace Blog.Modules.Posts;

public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    
    // relations
    public ICollection<Comment> Comments { get; set; }
}
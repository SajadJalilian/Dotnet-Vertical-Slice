namespace Blog.Domain.Models;

public class Post: IEntity
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    
    // relations
    public ICollection<Comment> Comments { get; set; }
}
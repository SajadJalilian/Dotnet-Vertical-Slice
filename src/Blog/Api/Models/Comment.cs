using Blog.Domain;

namespace Blog.Api.Models;

public class Comment: IEntity
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }

    // relations
    public int? PostId { get; set; }
    public Post Post { get; set; }
    
    public Comment Parent { get; set; }
    public int? ParentId { get; set; }
    public ICollection<Comment> Children { get; set; }
}
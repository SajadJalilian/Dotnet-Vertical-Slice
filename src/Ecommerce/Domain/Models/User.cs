namespace Ecommerce.Domain.Models;

public class User: IEntity
{
    public int Id { get; set; }
    public DateTime CreateAt { get; set; }
    public DateTime UpdateAt { get; set; }
}
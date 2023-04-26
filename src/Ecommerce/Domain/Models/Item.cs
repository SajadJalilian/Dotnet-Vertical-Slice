namespace Ecommerce.Domain.Models;

public class Item: IEntity
{
    public int Id { get; set; }

    public DateTime CreateAt { get; set; }
    public DateTime UpdateAt { get; set; }
}
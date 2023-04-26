namespace Ecommerce.Domain.Models;

public class Inventory: IEntity
{
    public int Id { get; set; }
    public int Quantity { get; set; }

    public DateTime CreateAt { get; set; }
    public DateTime UpdateAt { get; set; }
}
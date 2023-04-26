namespace Ecommerce.Domain.Models;

public class Order: IEntity
{
    public int Id { get; set; }
    public double Total { get; set; }

    public DateTime CreateAt { get; set; }
    public DateTime UpdateAt { get; set; }
}
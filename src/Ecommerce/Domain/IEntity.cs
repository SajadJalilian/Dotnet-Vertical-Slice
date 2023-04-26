namespace Ecommerce.Domain;

public interface IEntity
{
    int Id { get; set; }
    public DateTime CreateAt { get; set; }
    public DateTime UpdateAt { get; set; }
}
using Ecommerce.Domain.Models;

namespace Ecommerce.Features.Products.GetPostBtId;

public interface IGetProductByIdService
{
    Task<Product> GetProductById();
}

public class GetProductByIdService : IGetProductByIdService
{
    public Task<Product> GetProductById()
    {
        var post = new Product
        {
            Id = 1,
            Name = "test 1",
            Description = "desc 1",
            Price = 1.3,
            CreateAt = DateTime.Now,
            UpdateAt = DateTime.Now
        };

        return Task.FromResult(post);
    }
}
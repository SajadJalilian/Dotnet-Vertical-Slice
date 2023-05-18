using Ecommerce.Domain.Models;

namespace Ecommerce.Features.Products.GetPostsByFilter;

public interface IGetPostsByFilterService
{
    Task<IEnumerable<Product>> GetPostByFilter();
}

public class GetPostsByFilterService : IGetPostsByFilterService
{
    public Task<IEnumerable<Product>> GetPostByFilter()
    {
        var post = new List<Product>()
        {
            new ()
            {
                Id = 1,
                Name = "test 1",
                Description = "desc 1",
                Price = 1.3,
                CreateAt = DateTime.Now,
                UpdateAt = DateTime.Now
            },
            new ()
            {
                Id = 2,
                Name = "test 2",
                Description = "desc 2",
                Price = 2.3,
                CreateAt = DateTime.Now,
                UpdateAt = DateTime.Now
            },
            new ()
            {
                Id = 3,
                Name = "test 3",
                Description = "desc 3",
                Price = 3.3,
                CreateAt = DateTime.Now,
                UpdateAt = DateTime.Now
            },
        };

        return Task.FromResult<IEnumerable<Product>>(post);
    }
}
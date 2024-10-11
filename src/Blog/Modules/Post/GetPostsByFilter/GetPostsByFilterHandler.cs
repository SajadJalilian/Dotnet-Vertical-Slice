using Blog.Common.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Blog.Modules.Post.GetPostsByFilter;

public class GetPostsByFilterHandler : IGetPostsByFilterHandler
{
    private readonly AppDbContext _context;
    private readonly DbSet<PostEntity> _posts;

    public GetPostsByFilterHandler(AppDbContext context)
    {
        _context = context;
        _posts = context.Set<PostEntity>();
    }

    public async Task<IEnumerable<PostEntity>> GetPostByFilter()
    {
        return await _posts.ToArrayAsync();
    }
}
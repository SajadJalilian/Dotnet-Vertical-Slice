using Blog.Shared.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Blog.Modules.Post.GetPostsByFilter;

public class GetPostsByFilterHandler : IGetPostsByFilterHandler
{
    private readonly AppDbContext _context;
    private readonly DbSet<Post> _posts;

    public GetPostsByFilterHandler(AppDbContext context)
    {
        _context = context;
        _posts = context.Set<Post>();
    }

    public async Task<IEnumerable<Post>> GetPostByFilter()
    {
        return await _posts.ToArrayAsync();
    }
}
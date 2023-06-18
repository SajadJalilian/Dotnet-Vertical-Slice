using Blog.Shared.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Blog.Modules.Post.GetPostBtId;

public class GetPostByIdHandler : IGetPostByIdHandler
{

    private readonly AppDbContext _context;
    private readonly DbSet<Post> _posts;

    public GetPostByIdHandler(AppDbContext context)
    {
        _context = context;
        _posts = context.Set<Post>();
    }
    public async Task<Post> GetPostById(int id)
    {
        return await _posts.FirstOrDefaultAsync(x => x.Id == id);
    }
}
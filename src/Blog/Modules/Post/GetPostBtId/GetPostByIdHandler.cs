using Blog.Common.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Blog.Modules.Post.GetPostBtId;

public class GetPostByIdHandler : IGetPostByIdHandler
{

    private readonly AppDbContext _context;
    private readonly DbSet<PostEntity> _posts;

    public GetPostByIdHandler(AppDbContext context)
    {
        _context = context;
        _posts = context.Set<PostEntity>();
    }
    public async Task<PostEntity> GetPostById(int id)
    {
        return await _posts.FirstOrDefaultAsync(x => x.Id == id);
    }
}
using Blog.Shared.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Blog.Modules.Post.UpdatePost;

public class UpdatePostHandler : IUpdatePostHandler
{
    private readonly AppDbContext _context;
    private readonly DbSet<Post> _posts;

    public UpdatePostHandler(AppDbContext context)
    {
        _context = context;
        _posts = context.Set<Post>();
    }

    public async Task<Post> UpdatePost(UpdatePostCommand command)
    {
        // Validation
        var validator = new UpdatePostValidator();
        var validationResult = await validator.ValidateAsync(command);

        if (!validationResult.IsValid)
        {
            foreach (var error in validationResult.Errors)
            {
            }
        }

        var post = await _posts.FirstOrDefaultAsync(x => x.Id == command.Id);
        post.Body = command.Body;
        post.Title = command.Title;

        _posts.Update(post);
        await _context.SaveChangesAsync();

        return post;
    }
}
using Blog.Common.Persistence;
using ErrorOr;
using Microsoft.EntityFrameworkCore;

namespace Blog.Modules.Post.UpdatePost;

public class UpdatePostHandler : IUpdatePostHandler
{
    private readonly AppDbContext _context;
    private readonly DbSet<PostEntity> _posts;

    public UpdatePostHandler(AppDbContext context)
    {
        _context = context;
        _posts = context.Set<PostEntity>();
    }

    public async Task<ErrorOr<PostEntity>> UpdatePost(UpdatePostCommand command)
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
        if (post is null) return Error.NotFound();
        post.UpdateBody(command.Body);
        post.UpdateTitle(command.Title);

        _posts.Update(post);
        await _context.SaveChangesAsync();

        return post;
    }
}
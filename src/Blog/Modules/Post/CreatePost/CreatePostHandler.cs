using Blog.Common.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Blog.Modules.Post.CreatePost;

public class CreatePostHandler : ICreatePostHandler
{
    private readonly AppDbContext _context;
    private readonly DbSet<PostEntity> _posts;

    public CreatePostHandler(AppDbContext context)
    {
        _context = context;
        _posts = context.Set<PostEntity>();
    }

    public async Task<PostEntity> CreatePost(CreatePostCommand command)
    {
        // Validation
        var validator = new CreatePostValidator();
        var validationResult = await validator.ValidateAsync(command);

        if (!validationResult.IsValid)
        {
            foreach (var error in validationResult.Errors)
            {
            }
        }

        var post = PostEntity.Create(title: command.Title, body: command.Body);

        _posts.Add(post);
        await _context.SaveChangesAsync();

        return post;
    }
}
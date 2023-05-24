using FluentValidation;

namespace Blog.Modules.Posts.CreatePost;

public class CreatePostValidator: AbstractValidator<CreatePostCommand>
{
    public CreatePostValidator()
    {
        RuleFor(x => x.Body)
            .Length(2, 99999)
            .WithMessage("Body length must be between 2 and 99999");

        RuleFor(x => x.Title)
            .Length(2, 200)
            .WithMessage("Title length must be between 2 and 200");
    }
}
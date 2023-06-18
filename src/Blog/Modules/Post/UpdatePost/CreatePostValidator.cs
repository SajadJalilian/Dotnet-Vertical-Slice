using FluentValidation;

namespace Blog.Modules.Post.UpdatePost;

public class UpdatePostValidator: AbstractValidator<UpdatePostCommand>
{
    public UpdatePostValidator()
    {
        RuleFor(x => x.Body)
            .Length(2, 99999)
            .WithMessage("Body length must be between 2 and 99999");

        RuleFor(x => x.Title)
            .Length(2, 200)
            .WithMessage("Title length must be between 2 and 200");
    }
}
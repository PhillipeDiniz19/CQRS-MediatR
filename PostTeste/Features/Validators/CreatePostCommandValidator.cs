using FluentValidation;
using PostTeste.Application.Commands;

public class CreatePostCommandValidator : AbstractValidator<CreatePostCommand>
{
    public CreatePostCommandValidator()
    {
        RuleFor(x => x.Content).NotEmpty().WithMessage("O conteúdo do post é obrigatório.");
        RuleFor(x => x.UserId).NotEmpty().WithMessage("O ID do usuário é obrigatório.");
        RuleFor(x => x.UserName).NotEmpty().WithMessage("O nome do usuário é obrigatório.");
    }
}

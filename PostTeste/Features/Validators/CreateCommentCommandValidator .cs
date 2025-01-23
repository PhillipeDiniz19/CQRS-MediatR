using FluentValidation;

namespace PostTeste.Features.Validators
{
    public class CreateCommentCommandValidator : AbstractValidator<CreateCommentCommand>
    {
        public CreateCommentCommandValidator()
        {
            RuleFor(x => x.Content).NotEmpty().WithMessage("O conteúdo do comentário é obrigatório.");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("O nome do usuário é obrigatório.");
        }
    }

}

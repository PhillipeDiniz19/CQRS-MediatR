using FluentValidation;

namespace PostTeste.Features.Validators
{
    public class CreateParabensCommandValidator : AbstractValidator<CreateParabensCommand>
    {
        public CreateParabensCommandValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("O nome do usuário é obrigatório.");
        }
    }

}

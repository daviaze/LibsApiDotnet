using EstudosApi.Dtos;
using FluentValidation;

namespace EstudosApi.Validators
{
    public class MedicoValidator : AbstractValidator<MedicoDTO>
    {
        //Fluent Validation
        public MedicoValidator()
        {
            RuleFor(x => x.Crm)
                .NotEmpty()
                .WithMessage("O Crm não pode ser nulo ou vazio.")
                .WithErrorCode("001");

            RuleFor(x => x.Crm)
                .MinimumLength(10)
                .WithMessage("O Crm deve ter 10 dígitos.")
                .MaximumLength(10)
                .WithMessage("O Crm deve ter 10 dígitos.")
                .WithErrorCode("002");

            RuleFor(x => x.Nome)
                .NotEmpty()
                .WithMessage("O Nome não pode ser nulo ou vazio.")
                .WithErrorCode("003");
        }
    }
}

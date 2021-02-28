using FluentValidation;
using RoomManager.Domain.TransferObjects;

namespace RoomManager.Domain.Validation
{
    public class PersonValidator : AbstractValidator<PersonModel>
    {
        public PersonValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Nome não pode ser vazio ou nulo.");

            RuleFor(x => x.LastName)
                .NotEmpty()
                .WithMessage("Sobrenome não pode ser vazio ou nulo.");
        }
    }
}
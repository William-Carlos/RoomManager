using FluentValidation;
using RoomManager.Domain.TransferObjects;

namespace RoomManager.Domain.Validation
{
    public class CoffeeSpaceValidator : AbstractValidator<CoffeeSpaceModel>
    {
        public CoffeeSpaceValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Nome não pode ser vazio ou nulo.");
        }
    }
}
using FluentValidation;
using RoomManager.Domain.TransferObjects;

namespace RoomManager.Domain.Validation
{
    public class RoomValidator : AbstractValidator<RoomModel>
    {
        public RoomValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Nome não pode ser vazio ou nulo.");

            RuleFor(x => x.Capacity)
                .NotEmpty()
                .WithMessage("A capacidade não pode ser vazia ou nula.");
        }
    }
}
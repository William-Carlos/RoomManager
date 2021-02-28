using FluentValidation.Results;

namespace RoomManager.Domain.TransferObjects
{
    public abstract class EntityModelBase
    {
        public ValidationResult ValidationResult { get; set; }
        public abstract bool IsValid();
    }
}

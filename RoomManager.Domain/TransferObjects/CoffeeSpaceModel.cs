using RoomManager.Domain.Validation;

namespace RoomManager.Domain.TransferObjects
{
    public class CoffeeSpaceModel : EntityModelBase
    {
        public string Name { get; set; }

        public override bool IsValid()
        {
            ValidationResult = new CoffeeSpaceValidator().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}

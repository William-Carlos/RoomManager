using RoomManager.Domain.Entities;
using RoomManager.Domain.Validation;

namespace RoomManager.Domain.TransferObjects
{
    public class RoomModel : EntityModelBase
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public override bool IsValid()
        {
            ValidationResult = new RoomValidator().Validate(this);
            return ValidationResult.IsValid;
        }

        public static RoomModel BuildModel(Room room)
        {
            return new RoomModel
            {
                Id = room.Id,
                Name = room.Name,
                Capacity = room.Capacity
            };
        }
    }
}

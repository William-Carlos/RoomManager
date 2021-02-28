using RoomManager.Domain.Entities;
using RoomManager.Domain.Validation;
using System.Collections.Generic;

namespace RoomManager.Domain.TransferObjects
{
    public class RoomModel : EntityModelBase
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Quantity { get; set; }
        public IList<Person> FirstStepPeople { get; set; }
        public IList<Person> SecondStepPeople { get; set; }

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
                Capacity = room.Capacity,
                Quantity = room.Quantity
            };
        }

        public void SetPeople(IList<Person> firstStep, IList<Person> secondStep)
        {
            FirstStepPeople = firstStep;
            SecondStepPeople = secondStep;
        }
    }
}

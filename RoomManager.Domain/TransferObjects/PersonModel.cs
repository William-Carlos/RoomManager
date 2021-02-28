using RoomManager.Domain.Entities;
using RoomManager.Domain.Validation;

namespace RoomManager.Domain.TransferObjects
{
    public class PersonModel : EntityModelBase
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Room FirstStepRoom { get; set; }
        public Room SecondStepRoom { get; set; }
        public CoffeeSpace FirstStepCoffeeSpace { get; set; }
        public CoffeeSpace SecondStepCoffeeSpace { get; set; }

        public override bool IsValid()
        {
            ValidationResult = new PersonValidator().Validate(this);
            return ValidationResult.IsValid;
        }

        public static PersonModel BuildModel(Person person)
        {
            return new PersonModel
            {
                Id = person.Id,
                Name = person.Name,
                LastName = person.LastName,
                FirstStepRoom = person.FirstStepRoom,
                SecondStepRoom = person.SecondStepRoom,
                FirstStepCoffeeSpace = person.FirstStepCoffeeSpace,
                SecondStepCoffeeSpace = person.SecondStepCoffeeSpace
            };
        }
    }
}

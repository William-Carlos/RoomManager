using RoomManager.Domain.Entities;
using RoomManager.Domain.Validation;
using System.Collections.Generic;

namespace RoomManager.Domain.TransferObjects
{
    public class CoffeeSpaceModel : EntityModelBase
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public IList<Person> FirstStepPeople { get; set; }
        public IList<Person> SecondStepPeople { get; set; }

        public override bool IsValid()
        {
            ValidationResult = new CoffeeSpaceValidator().Validate(this);
            return ValidationResult.IsValid;
        }

        public static CoffeeSpaceModel BuildModel(CoffeeSpace coffeeSpace)
        {
            return new CoffeeSpaceModel
            {
                Id = coffeeSpace.Id,
                Name = coffeeSpace.Name,
                Quantity = coffeeSpace.Quantity
            };
        }

        public void SetPeople(IList<Person> firstStep, IList<Person> secondStep)
        {
            FirstStepPeople = firstStep;
            SecondStepPeople = secondStep;
        }
    }
}

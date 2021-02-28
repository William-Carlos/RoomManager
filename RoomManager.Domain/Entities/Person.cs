using RoomManager.Domain.Entities.Base;

namespace RoomManager.Domain.Entities
{
    public class Person : EntityBase
    {
        public Person() { }

        public Person(string name, string lastName, long firstStepRoomId, long secondStepRoomId, long firstStepCoffeeSpaceId, long secondStepCoffeeSpaceId)
        {
            Name = name;
            LastName = lastName;
            FirstStepRoomId = firstStepRoomId;
            SecondStepRoomId = secondStepRoomId;
            FirstStepCoffeeSpaceId = firstStepCoffeeSpaceId;
            SecondStepCoffeeSpaceId = secondStepCoffeeSpaceId;
        }

        public string Name { get; private set; }
        public string LastName { get; private set; }
        public long FirstStepRoomId { get; private set; }
        public long SecondStepRoomId { get; private set; }
        public virtual Room FirstStepRoom { get; private set; }
        public virtual Room SecondStepRoom { get; private set; }
        public long FirstStepCoffeeSpaceId { get; private set; }
        public long SecondStepCoffeeSpaceId { get; private set; }
        public virtual CoffeeSpace FirstStepCoffeeSpace { get; private set; }
        public virtual CoffeeSpace SecondStepCoffeeSpace { get; private set; }
    }
}

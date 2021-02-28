using RoomManager.Domain.Entities.Base;

namespace RoomManager.Domain.Entities
{
    public class CoffeeSpace : EntityBase
    {
        public CoffeeSpace() { }

        public CoffeeSpace(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}

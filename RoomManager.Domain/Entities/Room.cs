using RoomManager.Domain.Entities.Base;
using RoomManager.Domain.TransferObjects;

namespace RoomManager.Domain.Entities
{
    public class Room : EntityBase
    {
        public Room() { }

        public Room(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Quantity = 0;
        }

        public string Name { get; private set; }
        public int Capacity { get; private set; }
        public int Quantity { get; private set; }

        public void Update(RoomModel model)
        {
            Name = model.Name;
            Capacity = model.Capacity;
            Quantity = model.Quantity;
        }

        public void Increment()
        {
            Quantity++;
        }
    }
}

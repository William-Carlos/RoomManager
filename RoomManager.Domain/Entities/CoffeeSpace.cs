using RoomManager.Domain.Entities.Base;
using RoomManager.Domain.TransferObjects;

namespace RoomManager.Domain.Entities
{
    public class CoffeeSpace : EntityBase
    {
        public CoffeeSpace() { }

        public CoffeeSpace(string name)
        {
            Name = name;
            Quantity = 0;
        }

        public string Name { get; private set; }
        public int Quantity { get; private set; }

        public void Update(CoffeeSpaceModel model)
        {
            Name = model.Name;
            Quantity = model.Quantity;
        }

        public void Increment()
        {
            Quantity++;
        }
    }
}

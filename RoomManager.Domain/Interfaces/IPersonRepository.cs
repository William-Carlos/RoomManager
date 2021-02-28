using RoomManager.Domain.Entities;
using System.Collections.Generic;

namespace RoomManager.Domain.Interfaces
{
    public interface IPersonRepository : IRepositoryBase<Person>
    {
        Person GetByIdWithRoomsAndSpaces(long id);
        IList<Person> GetByRoomId(long roomId);
        IList<Person> GetByCoffeeSpaceId(long coffeeSpaceId);
    }
}

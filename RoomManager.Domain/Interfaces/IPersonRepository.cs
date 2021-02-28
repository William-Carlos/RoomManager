using RoomManager.Domain.Entities;

namespace RoomManager.Domain.Interfaces
{
    public interface IPersonRepository : IRepositoryBase<Person>
    {
        public Person GetByIdWithRoomsAndSpaces(long id);
    }
}

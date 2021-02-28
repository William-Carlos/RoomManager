using Microsoft.EntityFrameworkCore;
using RoomManager.Domain.Entities;
using RoomManager.Domain.Interfaces;

namespace RoomManager.DataAccess.Repositories
{
    public class RoomRepository : RepositoryBase<Room>, IRoomRepository
    {
        public RoomRepository(DbContext context) : base(context) { }
    }
}

using Microsoft.EntityFrameworkCore;
using RoomManager.Domain.Entities;
using RoomManager.Domain.Interfaces;

namespace RoomManager.DataAccess.Repositories
{
    public class CoffeeSpaceRepository : RepositoryBase<CoffeeSpace>, ICoffeeSpaceRepository
    {
        public CoffeeSpaceRepository(DbContext context) : base(context) { }
    }
}

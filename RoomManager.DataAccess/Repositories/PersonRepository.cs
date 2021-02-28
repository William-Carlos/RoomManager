using Microsoft.EntityFrameworkCore;
using RoomManager.Domain.Entities;
using RoomManager.Domain.Interfaces;
using System.Linq;

namespace RoomManager.DataAccess.Repositories
{
    public class PersonRepository : RepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(DbContext context) : base(context) { }

        public Person GetByIdWithRoomsAndSpaces(long id)
        {
            return _dbContext.Set<Person>()
                .Include(d => d.FirstStepRoom)
                .Include(d => d.SecondStepRoom)
                .Include(d => d.FirstStepCoffeeSpace)
                .Include(d => d.SecondStepCoffeeSpace)
                .Where(d => d.Id == id)
                .FirstOrDefault();
        }
    }
}

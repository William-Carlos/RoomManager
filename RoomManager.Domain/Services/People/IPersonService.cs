using RoomManager.Domain.TransferObjects;
using System.Collections.Generic;

namespace RoomManager.Domain.Services.People
{
    public interface IPersonService
    {
        void Create(PersonModel request);
        IList<PersonModel> GetAll();
        PersonModel GetById(long id);
    }
}

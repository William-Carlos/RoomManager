using RoomManager.Domain.TransferObjects;
using System.Collections.Generic;

namespace RoomManager.Domain.Services.Rooms
{
    public interface IRoomService
    {
        void Create(RoomModel request);
        void Update(RoomModel request);
        IList<RoomModel> GetAll();
        RoomModel GetById(long id);
    }
}

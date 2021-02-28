using RoomManager.Domain.Entities;
using RoomManager.Domain.Interfaces;
using RoomManager.Domain.TransferObjects;
using System.Collections.Generic;
using System.Linq;

namespace RoomManager.Domain.Services.Rooms
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _repository;

        public RoomService(IRoomRepository repository)
        {
            _repository = repository;
        }

        public void Create(RoomModel request)
        {
            if (request.IsValid())
            {
                var room = new Room(request.Name, request.Capacity);
                _repository.Create(room);
            }
        }

        public IList<RoomModel> GetAll()
        {
            var people = _repository.GetAll();

            return people.Select(x => new RoomModel { Name = x.Name, Capacity = x.Capacity }).ToList();
        }

        public void Update(RoomModel request)
        {
            if (request.Id == null || !request.IsValid())
            {
                return;
            }

            var room = _repository.GetById((long)request.Id);

            if (room == null)
            {
                Create(request);
            }

            room.Update(request);

            _repository.Update(room);
        }
    }
}

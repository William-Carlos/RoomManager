using RoomManager.Domain.Entities;
using RoomManager.Domain.Interfaces;
using RoomManager.Domain.TransferObjects;
using System.Collections.Generic;
using System.Linq;

namespace RoomManager.Domain.Services.Rooms
{
    public class RoomService : IRoomService
    {
        private readonly IPersonRepository _personRepository;
        private readonly IRoomRepository _roomRepository;

        public RoomService(IPersonRepository personRepository, IRoomRepository roomRepository)
        {
            _personRepository = personRepository;
            _roomRepository = roomRepository;
        }

        public void Create(RoomModel request)
        {
            if (request.IsValid())
            {
                var room = new Room(request.Name, request.Capacity);
                _roomRepository.Create(room);
            }
        }

        public IList<RoomModel> GetAll()
        {
            var rooms = _roomRepository.GetAll();

            return rooms.Select(x => new RoomModel { Name = x.Name, Capacity = x.Capacity }).ToList();
        }

        public void Update(RoomModel request)
        {
            if (request.Id == null || !request.IsValid())
            {
                return;
            }

            var room = _roomRepository.GetById((long)request.Id);

            if (room == null)
            {
                Create(request);
            }

            room.Update(request);

            _roomRepository.Update(room);
        }

        public RoomModel GetById(long id)
        {
            var room = _roomRepository.GetById(id);
            var people = _personRepository.GetByCoffeeSpaceId(id);

            var peopleFirstStep = people.Where(x => x.FirstStepRoomId == id).ToList();
            var peopleSecondStep = people.Where(x => x.SecondStepRoomId == id).ToList();

            var model = RoomModel.BuildModel(room);
            model.SetPeople(peopleFirstStep, peopleSecondStep);

            return model;
        }
    }
}

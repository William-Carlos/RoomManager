using RoomManager.Domain.Entities;
using RoomManager.Domain.Interfaces;
using RoomManager.Domain.Services.CoffeeSpaces;
using RoomManager.Domain.Services.Rooms;
using RoomManager.Domain.TransferObjects;
using System.Collections.Generic;
using System.Linq;

namespace RoomManager.Domain.Services.People
{
    public class PersonService : IPersonService
    {
        private readonly ICoffeeSpaceRepository _coffeeSpaceRepository;
        private readonly ICoffeeSpaceService _coffeeSpaceService;
        private readonly IPersonRepository _personRepository;
        private readonly IRoomRepository _roomRepository;
        private readonly IRoomService _roomService;

        public PersonService(ICoffeeSpaceRepository coffeeSpaceRepository, ICoffeeSpaceService coffeeSpaceService, IPersonRepository personRepository, IRoomRepository roomRepository, IRoomService roomService)
        {
            _coffeeSpaceRepository = coffeeSpaceRepository;
            _coffeeSpaceService = coffeeSpaceService;
            _personRepository = personRepository;
            _roomRepository = roomRepository;
            _roomService = roomService;
        }

        public void Create(PersonModel request)
        {
            if (!request.IsValid())
            {
                return;
            }

            var selectedFirstRoom = SelectRoom();
            var selectedSecondRoom = SelectRoom();

            var selectedFirstCoffeeSpace = SelectCoffeeSpace();
            var selectedSecondCoffeeSpace = SelectCoffeeSpace();

            var person = new Person
                (request.Name, 
                request.LastName, 
                selectedFirstRoom.Id, 
                selectedSecondRoom.Id, 
                selectedFirstCoffeeSpace.Id, 
                selectedSecondCoffeeSpace.Id);

            _personRepository.Create(person);
        }

        private Room SelectRoom()
        {
            var rooms = _roomRepository.GetAll();

            var availableRooms = rooms.Where(x => x.Capacity <= (x.Quantity + 1));
            var min = availableRooms.Min(x => x.Quantity);
            var room = availableRooms.FirstOrDefault(x => x.Quantity == min);

            room.Increment();

            _roomService.Update(RoomModel.BuildModel(room));

            return room;
        }

        private CoffeeSpace SelectCoffeeSpace()
        {
            var coffeSpaces = _coffeeSpaceRepository.GetAll();

            var min = coffeSpaces.Min(x => x.Quantity);
            var spaceSelected = coffeSpaces.FirstOrDefault(x => x.Quantity == min);

            spaceSelected.Increment();

            _coffeeSpaceService.Update(CoffeeSpaceModel.BuildModel(spaceSelected));

            return spaceSelected;
        }

        public IList<PersonModel> GetAll()
        {
            var people = _personRepository.GetAll();

            return people.Select(x => new PersonModel { Name = x.Name, LastName = x.LastName }).ToList();
        }
   
        public PersonModel GetById(long id)
        {
            var person = _personRepository.GetByIdWithRoomsAndSpaces(id);

            return PersonModel.BuildModel(person);
        }
    }
}

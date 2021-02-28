using RoomManager.Domain.Entities;
using RoomManager.Domain.Interfaces;
using RoomManager.Domain.TransferObjects;
using System.Collections.Generic;
using System.Linq;

namespace RoomManager.Domain.Services.CoffeeSpaces
{
    public class CoffeeSpaceService : ICoffeeSpaceService
    {
        private readonly ICoffeeSpaceRepository _coffeeSpaceRepository;
        private readonly IPersonRepository _personRepository;

        public CoffeeSpaceService(ICoffeeSpaceRepository coffeeSpaceRepository, IPersonRepository personRepository)
        {
            _coffeeSpaceRepository = coffeeSpaceRepository;
            _personRepository = personRepository;
        }

        public void Create(CoffeeSpaceModel request)
        {
            if (request.IsValid())
            {
                var coffeeSpace = new CoffeeSpace(request.Name);
                _coffeeSpaceRepository.Create(coffeeSpace);
            }
        }

        public void Update(CoffeeSpaceModel request)
        {
            if (request.Id == null || !request.IsValid())
            {
                return;
            }

            var coffeeSpace = _coffeeSpaceRepository.GetById((long)request.Id);

            if (coffeeSpace == null)
            {
                Create(request);
            }

            coffeeSpace.Update(request);

            _coffeeSpaceRepository.Update(coffeeSpace);
        }

        public IList<CoffeeSpaceModel> GetAll()
        {
            var coffeSpaces = _coffeeSpaceRepository.GetAll();

            return coffeSpaces.Select(x => new CoffeeSpaceModel { Name = x.Name }).ToList();
        }

        public CoffeeSpaceModel GetById(long id)
        {
            var coffeeSpace = _coffeeSpaceRepository.GetById(id);
            var people = _personRepository.GetByCoffeeSpaceId(id);

            var peopleFirstStep = people.Where(x => x.FirstStepCoffeeSpaceId == id).ToList();
            var peopleSecondStep = people.Where(x => x.SecondStepCoffeeSpaceId == id).ToList();

            var model = CoffeeSpaceModel.BuildModel(coffeeSpace);
            model.SetPeople(peopleFirstStep, peopleSecondStep);

            return model;
        }
    }
}

using RoomManager.Domain.Entities;
using RoomManager.Domain.Interfaces;
using RoomManager.Domain.TransferObjects;
using System.Collections.Generic;
using System.Linq;

namespace RoomManager.Domain.Services.CoffeeSpaces
{
    public class CoffeeSpaceService : ICoffeeSpaceService
    {
        private readonly ICoffeeSpaceRepository _repository;

        public CoffeeSpaceService(ICoffeeSpaceRepository repository)
        {
            _repository = repository;
        }

        public void Create(CoffeeSpaceModel request)
        {
            if (request.IsValid())
            {
                var coffeeSpace = new CoffeeSpace(request.Name);
                _repository.Create(coffeeSpace);
            }
        }

        public IList<CoffeeSpaceModel> GetAll()
        {
            var coffeSpaces = _repository.GetAll();

            return coffeSpaces.Select(x => new CoffeeSpaceModel { Name = x.Name }).ToList();
        }
    }
}

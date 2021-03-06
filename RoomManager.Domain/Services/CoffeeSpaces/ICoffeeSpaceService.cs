﻿using RoomManager.Domain.TransferObjects;
using System.Collections.Generic;

namespace RoomManager.Domain.Services.CoffeeSpaces
{
    public interface ICoffeeSpaceService
    {
        void Create(CoffeeSpaceModel request);
        void Update(CoffeeSpaceModel request);
        IList<CoffeeSpaceModel> GetAll();
        CoffeeSpaceModel GetById(long id);
    }
}

using RoomManager.Domain.Entities.Base;
using System.Collections.Generic;

namespace RoomManager.Domain.Interfaces
{
    public interface IRepositoryBase<T> where T : EntityBase
    {
        void Create(T entity);
        void Update(T entity);
        void Remove(T entity);
        IList<T> GetAll();
        T GetById(long id);
    }
}

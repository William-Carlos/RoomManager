using RoomManager.Domain.Entities.Base;
using System.Collections.Generic;

namespace RoomManager.Domain.Interfaces
{
    public interface IRepositoryBase<T> where T : EntityBase
    {
        public void Create(T entity);
        public void Update(T entity);
        public void Remove(T entity);
        public IList<T> GetAll();
        public T GetById(long id);
    }
}

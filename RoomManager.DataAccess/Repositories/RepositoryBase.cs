using Microsoft.EntityFrameworkCore;
using RoomManager.Domain.Entities.Base;
using RoomManager.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace RoomManager.DataAccess.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : EntityBase
    {
        protected readonly DbContext _dbContext;
        protected readonly DbSet<T> _dbSet;

        public RepositoryBase(DbContext context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<T>();
        }

        public void Create(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public IList<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(long id)
        {
            return _dbSet.Find(id);
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }
    }
}

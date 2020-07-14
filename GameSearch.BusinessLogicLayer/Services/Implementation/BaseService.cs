using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using GameSearch.BusinessLogicLayer.Services.Interface;
using GameSearch.DataLayer.Interface;
using TournamentPlatform.DAL.Repository.Interface;

namespace GameSearch.BusinessLogicLayer.Services.Implementation
{
    public abstract class BaseService<T> : IBaseService<T> where T : class, IEntity
    {
        protected readonly IRepository<T> _repository;

        protected BaseService(IRepository<T> repository)
        {
            _repository = repository;
        }

        public Task AddAsync(T item)
        {
            return _repository.AddAsync(item);
        }

        public Task UpdateAsync(T item)
        {
            return _repository.UpdateAsync(item);
        }

        public Task DeleteAsync(int id)
        {
            return _repository.DeleteAsync(id);
        }

        public virtual Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null)
        {
            return _repository.GetAllAsync(predicate);
        }

        public virtual Task<T> GetByIdAsync(int id, Expression<Func<T, bool>> predicate = null)
        {
            return _repository.GetByIdAsync(id, predicate);
        }
    }
}
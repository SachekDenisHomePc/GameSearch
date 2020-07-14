using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using GameSearch.DataLayer.Interface;

namespace GameSearch.BusinessLogicLayer.Services.Interface
{
    public interface IBaseService<T> where T : class, IEntity
    {
        Task AddAsync(T item);
        Task UpdateAsync(T item);
        Task DeleteAsync(int id);
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null);
        Task<T> GetByIdAsync(int id, Expression<Func<T, bool>> predicate = null);
    }
}
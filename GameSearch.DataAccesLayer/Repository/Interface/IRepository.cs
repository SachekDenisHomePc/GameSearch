using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GameSearch.DataAccessLayer.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T item);
        Task DeleteAsync(int id);
        Task UpdateAsync(T item);
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllByPredicateAsync(Expression<Func<T, bool>> predicate);
        Task<T> GetByPredicateAsync(Expression<Func<T, bool>> predicate);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using GameSearch.Data.Interface;
using GameSearch.DataAccessLayer.EFContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Extensions.Internal;

namespace GameSearch.DataAccessLayer.Repository
{
    public class Repository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly GameSearchContext _context;

        public Repository(GameSearchContext context)
        {
            _context = context;
        }

        public async Task AddAsync(T item)
        {
            await _context.Set<T>().AddAsync(item);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var item = await _context.FindAsync<T>(id);

            if (item == null)
            {
                return;
            }

            _context.Remove(item);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<IEnumerable<T>> GetAllByPredicateAsync(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().AsNoTracking().Where(predicate).ToListAsync();
        }

        public async Task<T> GetByPredicateAsync(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().AsNoTracking().Where(predicate).FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(T item)
        {
            var entry = await _context.Set<T>().FirstAsync(e => e.Id == item.Id);
            _context.Entry(entry).CurrentValues.SetValues(item);
            await _context.SaveChangesAsync();
        }
    }
}
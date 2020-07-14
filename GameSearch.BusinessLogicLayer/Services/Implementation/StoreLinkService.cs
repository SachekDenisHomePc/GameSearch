using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using GameSearch.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using TournamentPlatform.DAL.Repository.Interface;

namespace GameSearch.BusinessLogicLayer.Services.Implementation
{
    public class StoreLinkService : BaseService<StoreLink>
    {
        public StoreLinkService(IRepository<StoreLink> repository) : base(repository)
        {
        }

        public override Task<StoreLink> GetByIdAsync(int id, Expression<Func<StoreLink, bool>> predicate = null)
        {
            return _repository.GetByIdAsync(id, predicate, query => query.Include(store => store.Game));
        }

        public override Task<IEnumerable<StoreLink>> GetAllAsync(Expression<Func<StoreLink, bool>> predicate = null)
        {
            return _repository.GetAllAsync(predicate, query => query.Include(store => store.Game));
        }
    }
}
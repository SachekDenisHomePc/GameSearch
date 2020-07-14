using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using GameSearch.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using TournamentPlatform.DAL.Repository.Interface;

namespace GameSearch.BusinessLogicLayer.Services.Implementation
{
    public class RatingCharacteristicService : BaseService<RatingCharacteristic>
    {
        public RatingCharacteristicService(IRepository<RatingCharacteristic> repository) : base(repository)
        {
        }

        public override Task<RatingCharacteristic> GetByIdAsync(int id, Expression<Func<RatingCharacteristic, bool>> predicate = null)
        {
            return _repository.GetByIdAsync(id, predicate, query=>query.Include(characteristic=>characteristic.Genre));
        }

        public override Task<IEnumerable<RatingCharacteristic>> GetAllAsync(Expression<Func<RatingCharacteristic, bool>> predicate = null)
        {
            return _repository.GetAllAsync(predicate, query=>query.Include(characteristic=>characteristic.Genre));
        }
    }
}
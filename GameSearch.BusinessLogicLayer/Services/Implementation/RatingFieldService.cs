using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using GameSearch.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using TournamentPlatform.DAL.Repository.Interface;

namespace GameSearch.BusinessLogicLayer.Services.Implementation
{
    public class RatingFieldService : BaseService<RatingField>
    {
        public RatingFieldService(IRepository<RatingField> repository) : base(repository)
        {
        }

        public override Task<IEnumerable<RatingField>> GetAllAsync(Expression<Func<RatingField, bool>> predicate = null)
        {
            return _repository.GetAllAsync(predicate, query => query
                                                               .Include(ratingField => ratingField.Game)
                                                               .Include(ratingField => ratingField.RatingCharacteristic));
        }

        public override Task<RatingField> GetByIdAsync(int id, Expression<Func<RatingField, bool>> predicate = null)
        {
            return _repository.GetByIdAsync(id, predicate, query => query
                                                                    .Include(ratingField => ratingField.Game)
                                                                    .Include(ratingField => ratingField.RatingCharacteristic));
        }
    }
}
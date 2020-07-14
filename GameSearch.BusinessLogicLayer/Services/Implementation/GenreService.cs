using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using GameSearch.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using TournamentPlatform.DAL.Repository.Interface;

namespace GameSearch.BusinessLogicLayer.Services.Implementation
{
    public class GenreService : BaseService<Genre>
    {
        public GenreService(IRepository<Genre> repository) : base(repository)
        {
        }

        public override Task<IEnumerable<Genre>> GetAllAsync(Expression<Func<Genre, bool>> predicate = null)
        {
            return _repository.GetAllAsync(predicate, query => query
                                                               .Include(genre => genre.Games)
                                                               .Include(genre => genre.RatingCharacteristics));
        }

        public override Task<Genre> GetByIdAsync(int id, Expression<Func<Genre, bool>> predicate = null)
        {
            return _repository.GetByIdAsync(id, predicate, query => query
                                                                    .Include(genre => genre.Games)
                                                                    .Include(genre => genre.RatingCharacteristics));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using GameSearch.BusinessLogicLayer.Services.Interface;
using GameSearch.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using TournamentPlatform.DAL.Repository.Interface;

namespace GameSearch.BusinessLogicLayer.Services.Implementation
{
    public class GameService : BaseService<Game>, IGameService
    {
        public GameService(IRepository<Game> repository) : base(repository)
        {
        }

        public override Task<IEnumerable<Game>> GetAllAsync(Expression<Func<Game, bool>> predicate = null)
        {
            return _repository.GetAllAsync(predicate, query => query.Include(game => game.Developer)
                                                                    .Include(game => game.Genre)
                                                                    .Include(game => game.StoreLinks)
                                                                    .Include(game => game.RatingFields));
        }

        public override Task<Game> GetByIdAsync(int id, Expression<Func<Game, bool>> predicate = null)
        {
            return _repository.GetByIdAsync(id, predicate, query => query.Include(game => game.Developer)
                                                                         .Include(game => game.Genre)
                                                                         .Include(game => game.StoreLinks)
                                                                         .Include(game => game.RatingFields));
        }
    }
}
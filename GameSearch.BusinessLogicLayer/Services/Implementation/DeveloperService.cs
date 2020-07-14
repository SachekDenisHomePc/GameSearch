using GameSearch.DataLayer.Entities;
using TournamentPlatform.DAL.Repository.Interface;

namespace GameSearch.BusinessLogicLayer.Services.Implementation
{
    public class DeveloperService : BaseService<Developer>
    {
        public DeveloperService(IRepository<Developer> repository) : base(repository)
        {
        }
    }
}
using System.Reflection;
using AutoMapper;
using AutoMapper.Configuration;
using GameSearch.DataAccessLayer.EFContext;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TournamentPlatform.DAL.Repository.Implementation;
using TournamentPlatform.DAL.Repository.Interface;

namespace GameSearch.Configuration
{
    public static class DiInitializer
    {
        public static void ConfigureServices(this IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration configuration)
        {
            var businessAssembly = Assembly.Load("GameSearch.BusinessLogicLayer");

            services.AddDbContext<GameSearchContext>(options =>
                                                         options.UseSqlServer(configuration.GetConnectionString("GameSearch")));

            services.Scan(scan => scan.FromAssemblies(businessAssembly)
                                      .AddClasses(classes => classes.Where(type => type.Name.EndsWith("Service")))
                                      .AsImplementedInterfaces())
                    .AddAutoMapper(typeof(MapperProfile))
                    .AddScoped(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}
using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Services;
using HouseRentingSystem.Infrastructure.Data.Common;

namespace HouseRentingSystem.Extensions
{
    public static class HouseRentingSystemServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IHouseService, HouseService>();
            services.AddScoped<IAgentService, AgentService>();

            return services;
        }
    }
}

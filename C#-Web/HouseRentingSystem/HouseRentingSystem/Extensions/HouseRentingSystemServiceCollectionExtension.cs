using HouseRentingSystem.Infrastructure.Data.Common;

namespace HouseRentingSystem.Extensions
{
    public static class HouseRentingSystemServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();

            return services;
        }
    }
}

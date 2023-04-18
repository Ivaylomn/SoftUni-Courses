using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Models.House;
using HouseRentingSystem.Infrastructure.Data.Common;
using HouseRentingSystem.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Core.Services
{
    public class HouseService : IHouseService
    {
        private readonly IRepository dbRepo;

        public HouseService(IRepository _dbRepo)
        {
            this.dbRepo = _dbRepo;
        }

        public async Task<IEnumerable<HouseIndexServiceModel>> LastThreeHouses()
        {
            var lastThreeHouses = await dbRepo
                .AllReadonly<House>()
                .OrderByDescending(x => x.Id)
                .Select(x => new HouseIndexServiceModel()
                {
                    Id = x.Id,
                    Title = x.Title,
                    ImageUrl = x.ImageUrl
                })
                .Take(3)
                .ToListAsync();

            return lastThreeHouses;
        }
    }
}

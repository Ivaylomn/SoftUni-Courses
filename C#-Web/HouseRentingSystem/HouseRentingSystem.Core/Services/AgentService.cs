using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Infrastructure.Data.Common;
using HouseRentingSystem.Infrastructure.Data.Entities;

namespace HouseRentingSystem.Core.Services
{
    public class AgentService : IAgentService
    {
        private readonly IRepository dbRepo;

        public AgentService(IRepository _dbRepo)
        {
            this.dbRepo = _dbRepo;
        }

        public void Create(string userId, string phoneNumber)
        {
            var agent = new Agent()
            {
                UserId = userId,
                PhoneNumber = phoneNumber
            };

            dbRepo.AddAsync(agent);
            dbRepo.SaveChangesAsync();
        }

        public bool ExistsById(string agentId)
        {
            return dbRepo.All<Agent>().Any(a => a.UserId == agentId);
        }

        public bool UserHasRents(string userId)
        {
            return dbRepo.All<Agent>().Any(a => a.UserId == userId);
        }

        public bool UserWithPhoneNumberExists(string phoneNumber)
        {
            return dbRepo.All<Agent>()
                .Any(a => a.PhoneNumber == phoneNumber);
        }

    }
}

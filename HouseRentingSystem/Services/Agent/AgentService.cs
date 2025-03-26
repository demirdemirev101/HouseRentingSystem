using HouseRentingSystem.Contacts.Agent;
using HouseRentingSystem.Data;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Services.Agent
{
    public class AgentService : IAgentService
    {
        private readonly HouseRentingDbContext _data;
        public AgentService(HouseRentingDbContext data)
        {
            _data = data;
        }

        public async Task<bool> ExistsById(string userId)
        {
            return await _data
                        .Agents.AnyAsync(x => x.UserId == userId);
        }
        public async Task<bool> UserWithPhoneNumberExists(string phoneNumber)
        {
            return  await _data.Agents.AnyAsync(a => a.PhoneNumber == phoneNumber);
        }
        public async Task<bool> UserHasRents(string userId)
        {
            return await
                _data.Houses.AnyAsync(h=>h.RenterId == userId);
        }
        public async Task Create(string userId, string phoneNumber)
        {
            var agent = new Data.Models.Agent()
            {
                UserId = userId,
                PhoneNumber = phoneNumber
            };

            await _data.Agents.AddAsync(agent);
            await _data.SaveChangesAsync();
        }

        public async Task<int> GetAgentId(string userId)
        {
            return _data.Agents.FirstOrDefaultAsync(a => a.UserId == userId).Id;
        }
    }
}

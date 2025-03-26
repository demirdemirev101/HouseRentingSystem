using HouseRentingSystem.Contacts.House;
using HouseRentingSystem.Data;
using HouseRentingSystem.Models.House;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Services.House
{
    public class HouseService : IHouseService
    {
        private readonly HouseRentingDbContext _data;
        public HouseService(HouseRentingDbContext context)
        {
            _data = context;
        }

        public async Task<IList<HouseIndexServiceModel>> LastThreeHouses()
        {
            return _data
                        .Houses
                        .OrderByDescending(h => h.Id)
                        .Select(h => new HouseIndexServiceModel()
                        {
                            Id = h.Id,
                            Title = h.Title,
                            ImageUrl = h.ImageUrl
                        })
                        .Take(3)
                        .ToList();
        }
        public async Task<IList<HouseCategoryServiceModel>> AllCategories()
        {
            return await _data
                      .Categories
                      .Select(c => new HouseCategoryServiceModel()
                      {
                          Id = c.Id,
                          Name = c.Name
                      })
                      .ToListAsync();
        }
        public async Task<bool> CategoryExists(int categoryId)
        {
            return await _data.Categories.AnyAsync(c => c.Id == categoryId);
        }
        public async Task<int> Create(string title, string address, string description, string imageUrl, decimal price, int categoryId, int agentId)
        {
            var house = new Data.Models.House()
            {
                Title = title,
                Address = address,
                Description = description,
                ImageUrl = imageUrl,
                PricePerMonth = price,
                CategoryId = categoryId,
                AgentId = agentId
            };

            await _data.Houses.AddAsync(house);
            await _data.SaveChangesAsync();

            return house.Id;
        }
    }
}

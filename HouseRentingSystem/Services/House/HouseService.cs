using HouseRentingSystem.Contacts.House;
using HouseRentingSystem.Data;
using HouseRentingSystem.Infrastructure;
using HouseRentingSystem.Models.House;
using HouseRentingSystem.Services.House.Models;
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

        public HouseQueryServiceModel All(string category = null, string searchTerm = null, HouseSorting sorting = HouseSorting.Newest, int currentPage = 1, int housesPerPage = 1)
        {
            var housesQuery = _data.Houses.AsQueryable();

            if(!string.IsNullOrWhiteSpace(category))
            {
                housesQuery = _data
                    .Houses
                    .Where(h => h.Category.Name == category);
            }

            if(!string.IsNullOrWhiteSpace(searchTerm))
            {
                housesQuery = housesQuery
                    .Where(h =>
                    h.Title.ToLower().Contains(searchTerm.ToLower()) ||
                    h.Address.ToLower().Contains(searchTerm.ToLower()) ||
                    h.Description.ToLower().Contains(searchTerm.ToLower()));
            }

            housesQuery = sorting switch
            {
                HouseSorting.Price => housesQuery
                    .OrderBy(h => h.PricePerMonth),
                HouseSorting.NotRentedFirst => housesQuery
                    .OrderBy(h => h.RenterId != null)
                    .ThenByDescending(h => h.Id),
                _ => housesQuery.OrderByDescending(h => h.Id)
            };

            var houses=housesQuery
                .Skip((currentPage-1)*housesPerPage)
                .Take(housesPerPage)
                .Select(h=> new HouseServiceModel
                {
                    Id = h.Id,
                    Title = h.Title,
                    Address = h.Address,
                    ImageUrl = h.ImageUrl,
                    IsRented=h.RenterId!=null,
                    PricePerMonth=h.PricePerMonth
                })
                .ToList();

            var totoalHouses = housesQuery.Count();

            return new HouseQueryServiceModel()
            {
                TotalHousesCount = totoalHouses,
                Houses = houses
            };
        }

        public async Task<IList<string>> AllCategoriesNames()
        {
            return await _data
                            .Categories
                            .Select(c => c.Name)
                            .Distinct()
                            .ToListAsync();
        }
    }
}

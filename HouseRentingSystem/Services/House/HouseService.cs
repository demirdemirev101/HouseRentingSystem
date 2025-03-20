using HouseRentingSystem.Contacts.House;
using HouseRentingSystem.Data;
using HouseRentingSystem.Models.House;

namespace HouseRentingSystem.Services.House
{
    public class HouseService : IHouseService
    {
        private readonly HouseRentingDbContext _data;
        public HouseService(HouseRentingDbContext context)
        {
            _data = context;
        }
        public async Task<IEnumerable<HouseIndexServiceModel>> LastThreeHouses()
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
                        .Take(3);
        }
    }
}

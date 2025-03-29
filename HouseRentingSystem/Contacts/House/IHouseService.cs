using HouseRentingSystem.Infrastructure;
using HouseRentingSystem.Models.House;
using HouseRentingSystem.Services.House.Models;

namespace HouseRentingSystem.Contacts.House
{
    public interface IHouseService
    {
        Task<IList<HouseIndexServiceModel>> LastThreeHouses();
        Task<IList<HouseCategoryServiceModel>> AllCategories();

        Task<bool> CategoryExists(int categoryId);
        Task<int> Create(string title, string address, string description, string ImageUrl, decimal price, int categoryId, int agentId);

        Task<HouseQueryServiceModel> All(string category = null, string searchTerm = null,
            HouseSorting sorting = HouseSorting.Newest, int currentPage = 1, int housesPerPage = 1);
        Task<IList<string>> AllCategoriesNames();

        Task<IList<HouseServiceModel>> AllHousesByAgentId(int agentId);
        Task<IList<HouseServiceModel>> AllHousesByUserId(string userId);

        Task<bool> Exists(int id);
        Task<HouseDetailsServiceModel> HouseDetailsById(int id);

        Task Edit(int houseId, string title, string address, string description, string imageUrl, decimal price, int categoryId);

        Task<bool> HasAgentWithId(int houseId, string currentUserId);
        Task<int> GetHouseCategoryId(int houseId);  
    }
}

using HouseRentingSystem.Models.House;

namespace HouseRentingSystem.Contacts.House
{
    public interface IHouseService
    {
        Task<IList<HouseIndexServiceModel>> LastThreeHouses();
        Task<IList<HouseCategoryServiceModel>> AllCategories();

        Task<bool> CategoryExists(int categoryId);
        Task<int> Create(string title, string address, string description, string ImageUrl, decimal price, int categoryId, int agentId);
    }
}

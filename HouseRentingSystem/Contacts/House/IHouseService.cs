using HouseRentingSystem.Models.House;

namespace HouseRentingSystem.Contacts.House
{
    public interface IHouseService
    {
        Task<IEnumerable<HouseIndexServiceModel>> LastThreeHouses();
    }
}

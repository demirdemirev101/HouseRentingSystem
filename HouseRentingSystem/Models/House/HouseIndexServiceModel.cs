using HouseRentingSystem.Contacts;

namespace HouseRentingSystem.Models.House
{
    public class HouseIndexServiceModel : IHouseModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public string Address { get; set; } = null!;
    }
}

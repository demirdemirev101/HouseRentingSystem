namespace HouseRentingSystem.Services.House.Models
{
    public class HouseQueryServiceModel
    {
        public int TotalHousesCount { get; set; }
        public IList<HouseServiceModel> Houses { get; set; } =
            new List<HouseServiceModel>();
    }
}

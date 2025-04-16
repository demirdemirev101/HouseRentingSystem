using HouseRentingSystem.Contacts.Statistic;
using HouseRentingSystem.Data;
using HouseRentingSystem.Models.Statistic;

namespace HouseRentingSystem.Services.Statistic
{
    public class StatisticService : IStatisticsService
    {
        private readonly HouseRentingDbContext data;
        public StatisticService(HouseRentingDbContext _data)
        {
            data = _data;
        }
        public StatisticServiceModel Total()
        {
            var totalHouses = data.Houses.Count();
            var totalRents=data
                    .Houses
                    .Where(h=>h.RenterId!=null)
                    .Count();

            return new StatisticServiceModel()
            { 
                TotalHouses = totalHouses,
                TotalRents = totalRents 
            };
        }
    }
}

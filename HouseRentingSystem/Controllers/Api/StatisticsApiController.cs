using HouseRentingSystem.Contacts.Statistic;
using HouseRentingSystem.Models.Statistic;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.Controllers.Api
{
    [ApiController]
    [Route("api/statistics")]
    public class StatisticsApiController : ControllerBase
    {
        private readonly IStatisticsService statistics;

        public StatisticsApiController( IStatisticsService _statistics)
        {
            statistics = _statistics;
        }

        [HttpGet]
        public StatisticServiceModel GetStatistic()
        {
            return statistics.Total();
        }
    }
}

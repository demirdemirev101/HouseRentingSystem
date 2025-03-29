using HouseRentingSystem.Services.Agent.Models;

namespace HouseRentingSystem.Services.House.Models
{
    public class HouseDetailsServiceModel : HouseServiceModel
    {
        public string Description { get; set; } = null!;
        public string Category { get; set; } = null!;
        public AgentServiceModel Agent { get; set; } = null!;
    }
}

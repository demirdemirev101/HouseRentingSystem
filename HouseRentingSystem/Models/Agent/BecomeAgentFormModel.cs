using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem.Data.DataConstants.Agent;
namespace HouseRentingSystem.Models.Agent
{
    public class BecomeAgentFormModel
    {
        [Required]
        [StringLength(AgentMaxPhoneNumber,
            MinimumLength = AgentMinPhoneNumber)]
        [Display(Name = "Phone number")]
        [Phone]
        public string PhoneNumber { get; set; } = null!;
    }
}

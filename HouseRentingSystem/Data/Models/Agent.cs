using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem.Data.DataConstants.Agent;
namespace HouseRentingSystem.Data.Models
{
    public class Agent
    {
        public int Id { get; set; }
        [Required]
        [StringLength(AgentMaxPhoneNumber,
            MinimumLength =AgentMinPhoneNumber)]
        public string PhoneNumber { get; set; }=string.Empty;
        [Required]
        public string UserId { get; set; }=string.Empty;
        public ApplicationUser User { get; set; }
    }
}
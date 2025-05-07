using HouseRentingSystem.Data.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
namespace HouseRentingSystem.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(DataConstants.ApplicationUser.UserFirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(DataConstants.ApplicationUser.UserLastNameMaxLength)]
        public string LastName { get; set; } = null!;
    }
}

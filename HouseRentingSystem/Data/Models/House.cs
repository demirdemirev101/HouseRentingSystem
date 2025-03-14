using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem.Data.DataConstants.House;
namespace HouseRentingSystem.Data.Models
{
    public class House
    {
        public int Id { get; set; }
        [Required]
        [StringLength(HouseTitleMaxLength,
            MinimumLength = HouseTitleMinLength)]
        public string Title { get; set; } = string.Empty;
        [Required]
        [StringLength(HouseAddressMaxLength,
            MinimumLength =HouseAddressMinLength)]
        public string Address { get; set; }=string.Empty;
        [Required]
        [StringLength(HouseDescriptionMaxLength, 
            MinimumLength =HouseDescriptionMinLength)]
        public string Description { get; set; } = string.Empty;
        [Required]
        public string ImageUrl { get; set; } = string.Empty;
        [MaxLength(HousePricePerMonthMax),
        MinLength(HousePricePerMonthMin)]
        public decimal PricePerMonth { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int AgentId { get; set; }
        public Agent Agent { get; set; }
        public string? RenterId { get; set; }
    }
}
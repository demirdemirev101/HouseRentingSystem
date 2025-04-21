using HouseRentingSystem.Contacts;
using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem.Data.DataConstants.House;
namespace HouseRentingSystem.Models.House
{
    public class HouseFormModel : IHouseModel
    {
        [Required]
        [StringLength(HouseTitleMaxLength,
            MinimumLength = HouseTitleMinLength)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(HouseAddressMaxLength,
            MinimumLength = HouseAddressMinLength)]
        public string Address { get; set; } = null!;

        [Required]
        [StringLength(HouseDescriptionMaxLength,
            MinimumLength =HouseDescriptionMinLength)]
        public string Description { get; set; }= null!;
        
        [Required]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [Range(0.00, HousePricePerMonthMax,
            ErrorMessage = "Price per Month must be a positive number and less than {2} leva.")]
        public decimal PricePerMonth { get; set; }

        [Display(Name ="Category")]
        public int CategoryId { get; set; }
        public IList<HouseCategoryServiceModel> Categories { get; set; } =
            new List<HouseCategoryServiceModel>();
    }
}

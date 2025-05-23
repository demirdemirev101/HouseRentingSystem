﻿using HouseRentingSystem.Infrastructure;
using HouseRentingSystem.Services.House.Models;
using System.ComponentModel.DataAnnotations;

namespace HouseRentingSystem.Models.House
{
    public class AllHousesQueryModel
    {
        public const int HousesPerPage = 3;
        public string Category { get; init; } = null!;
        [Display(Name = "Search by text")]
        public string SearchTerm { get; init; } = null!;
        public HouseSorting Sorting { get; init; }
        public int CurrentPage { get; init; } = 1;
        public int TotalHousesCount { get; set; }
        public IEnumerable<string> Categories { get; set; } = null!;
        public IList<HouseServiceModel> Houses { get; set; } =
            new List<HouseServiceModel>();

    }
}

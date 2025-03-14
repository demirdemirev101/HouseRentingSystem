using HouseRentingSystem.Models.House;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.Controllers
{
    public class HouseController : Controller
    {
        public async Task<IActionResult> All()
        {
            return View(new AllHousesQueryModel());
        }
        [Authorize]
        public async Task<IActionResult> Mine()
        {
            return View(new AllHousesQueryModel());
        }
        public async Task<IActionResult> Details(int id)
        {
            return View(new HouseDetailsViewModel());
        }
        [Authorize]
        public async Task<IActionResult> Add()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Add(HouseFormModel model)
        {
            return RedirectToAction(nameof(Details), new { id = "1" });
        }
        [Authorize]
        public async Task<IActionResult> Edit(int id)
        {
            return View(new HouseFormModel());
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Edit(int id, HouseFormModel house)
        {
            return RedirectToAction(nameof(Details), new { id = "1" });
        }
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            return View(new HouseFormModel());
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Delete(HouseDetailsViewModel house)
        {
            return RedirectToAction(nameof(All));
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Rent(int id)
        {
            return RedirectToAction(nameof(Mine));
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Leave(int id)
        {
            return RedirectToAction(nameof(Mine));
        }
    }
}

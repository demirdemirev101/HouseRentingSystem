using HouseRentingSystem.Contacts.Agent;
using HouseRentingSystem.Contacts.House;
using HouseRentingSystem.Data;
using HouseRentingSystem.Infrastructure;
using HouseRentingSystem.Models.House;
using HouseRentingSystem.Services.House.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Controllers
{
    [Authorize]
    public class HouseController : Controller
    {
        private readonly IHouseService houses;
        private readonly IAgentService agents;
        private readonly HouseRentingDbContext data;
        public HouseController(IHouseService _houses, IAgentService _agents, HouseRentingDbContext _data)
        {
            houses = _houses;
            agents=_agents;
            data = _data;
        }
        public async Task<IActionResult> Add()
        {
            if(await agents.ExistsById(User.Id())==false)
            {
                return RedirectToAction(nameof(AgentController.Become), "Agent");
            }

            return View(new HouseFormModel
            {
                Categories= await houses.AllCategories()
            });
        }
        [HttpPost]
        public async Task<IActionResult> Add(HouseFormModel model)
        {
            if (await agents.ExistsById(User.Id()) == false)
            {
                return RedirectToAction(nameof(AgentController.Become), "Agent");
            }       
            
            if (await houses.CategoryExists(model.CategoryId)==false)
            {
                this.ModelState.AddModelError(nameof(model.CategoryId),
                    "Category does not exist.");
            }

            if (!ModelState.IsValid)
            {
                model.Categories=await houses.AllCategories();

                return View(model);
            }

            var agentId = agents.GetAgentId(User.Id());

            var newHouseId= await houses.Create(model.Title, model.Address, model.Description, model.ImageUrl,model.PricePerMonth,model.CategoryId,await agentId);

            return RedirectToAction(nameof(Details), new { id = newHouseId });
        }
        [AllowAnonymous]
        public async Task<IActionResult> All([FromQuery] AllHousesQueryModel query)
        {
            var queryResult = await houses.All(
                query.Category,
                query.SearchTerm,
                query.Sorting,
                query.CurrentPage,
                AllHousesQueryModel.HousesPerPage
                );

            query.TotalHousesCount = queryResult.TotalHousesCount;
            query.Houses = queryResult.Houses;

            var houseCategories=houses.AllCategoriesNames();
            query.Categories = await houseCategories;

            return View(query);
        }
        public async Task<IActionResult> Mine()
        {
            IList<HouseServiceModel> myHouses = null;

            var userId = User.Id();

            if(await agents.ExistsById(userId))
            {
                var currentAgentId=  await agents.GetAgentId(userId);

                myHouses = await houses.AllHousesByAgentId(currentAgentId);
            }
            else
            {
                myHouses=  await houses.AllHousesByUserId(userId);
            }

            return View(myHouses);
        }
        public async Task<IActionResult> Details(int id)
        {
            return View(new HouseDetailsViewModel());
        }
        public async Task<IActionResult> Edit(int id)
        {
            return View(new HouseFormModel());
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, HouseFormModel house)
        {
            return RedirectToAction(nameof(Details), new { id = "1" });
        }
        public async Task<IActionResult> Delete(int id)
        {
            return View(new HouseFormModel());
        }
        [HttpPost]
        public async Task<IActionResult> Delete(HouseDetailsViewModel house)
        {
            return RedirectToAction(nameof(All));
        }
        [HttpPost]
        public async Task<IActionResult> Rent(int id)
        {
            return RedirectToAction(nameof(Mine));
        }
        [HttpPost]
        public async Task<IActionResult> Leave(int id)
        {
            return RedirectToAction(nameof(Mine));
        }
    }
}

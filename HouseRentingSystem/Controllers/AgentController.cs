using HouseRentingSystem.Models.Agent;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.Controllers
{
    public class AgentController : Controller
    {
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Become(BecomeAgentFormModel agent)
        {
            return RedirectToAction(nameof(HouseController.All), "House");
        }
    }
}

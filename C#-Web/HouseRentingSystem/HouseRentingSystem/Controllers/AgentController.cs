using HouseRentingSystem.Core.Models.Agent;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.Controllers
{
    public class AgentController : Controller
    {
        public IActionResult Become()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Become(BecomeAgentFormModel becomeAgentModel)
        {
            return RedirectToAction(nameof(HouseController.All), "House");
        }
    }
}
